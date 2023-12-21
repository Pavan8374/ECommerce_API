using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using NatShopB2C.Domain.DTO;
using NatShopB2C.Domain.IRepositories;
using NatShopB2C.Domain.Models;
using NatShopB2C.Domain.StoredProcedureModels;
using NatShopB2C.EF.Common;
using NatShopB2C.EF.Common.DTO;
using NatShopB2C.EF.Data;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace NatShopB2C.EF.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly ApplicationDbContext _db;
        private readonly IMapper _mapper;
        protected Category CategorySliderCategory = null;
        protected readonly ProductRepository _productRepository;
        private readonly BusinessClass bc;



        private string _Subdomain = string.Empty;
        public string Subdomain
        {
            get { return _Subdomain; }
            set { _Subdomain = value; }
        }

        public CategoryRepository(ApplicationDbContext db, IMapper mapper, ProductRepository productRepository, BusinessClass bc)
        {
            _db = db;
            _mapper = mapper;
            _productRepository = productRepository;
            this.bc = bc;
        }

        public async Task<List<select_CategoryDetailsByFilter>> GetCategories(int? StartIndex, int? EndIndex, bool? IsActive, bool? IsArchieve)
        {

            // Specify SqlDbType.Int for objParam
            var objParam = new SqlParameter("@TotalRecords", SqlDbType.Int)
            {
                Direction = ParameterDirection.Output
            };

            string sql = "EXEC usp_select_CategoryDetailsByFilter  @StartIndex, @EndIndex, @IsActive, @IsArchieve, @TotalRecords OUTPUT";

            SqlParameter[] parms = new SqlParameter[]
            {
                // Create parameters    
                new SqlParameter("@StartIndex", StartIndex),
                new SqlParameter("@EndIndex", EndIndex),
                new SqlParameter("@IsActive", IsActive),
                new SqlParameter("@IsArchieve", IsArchieve),
                objParam // Use objParam directly
            };

            var categories = await _db.select_CategoryDetailsByFilter
                .FromSqlRaw(sql, parms)
                .ToListAsync();

            // Access the output parameter value
            var totalRecords = (int)objParam.Value;

            return categories;
        }

        public async  Task<List<CategoryHierarchyDTO>> GetcategoryHierarchy(int? StartIndex, int? EndIndex, bool? IsActive, bool? IsArchieve, string? SearchString)
        {
            List<CategoryHierarchyDTO> Categories = new List<CategoryHierarchyDTO>();
            var objParam = new SqlParameter("@TotalRecords", SqlDbType.Int)
            {
                Direction = ParameterDirection.Output
            };
            ;
            string sql = "EXEC usp_search_CategoryDetailsTree  @StartIndex, @EndIndex, @IsActive, @IsArchieve, @SearchString, @TotalRecords OUTPUT";

            SqlParameter[] parms = new SqlParameter[]
            {
                // Create parameters    
                new SqlParameter("@StartIndex", StartIndex),
                new SqlParameter("@EndIndex", EndIndex),
                new SqlParameter("@IsActive", IsActive),
                new SqlParameter("@IsArchieve", IsArchieve),
                new SqlParameter("@SearchString", SearchString),
                objParam // Use objParam directly
            };

            var categoriesList = await _db.search_CategoryDetailsTree
                                    .FromSqlRaw(sql, parms)
                                    .ToListAsync();
            var totalRecords = (int)objParam.Value;

            if (categoriesList != null)
            {
                foreach (var item in categoriesList)
                {
                    CategoryHierarchyDTO MainCategory = new CategoryHierarchyDTO();
                    MainCategory = _mapper.Map<CategoryHierarchyDTO>(item);
                    MainCategory.SubCategory = new List<CategoryHierarchyDTO>();

                    var SubCategoryList1 = _db.Categories.Where(x => x.ParentCategoryId == item.CategoryID).ToList();
                    foreach (var item1 in SubCategoryList1)
                    {
                        var SubCategoryList2 = _db.Categories.Where(x => x.ParentCategoryId == item1.Id).ToList();
                        CategoryHierarchyDTO subCategory1 = new CategoryHierarchyDTO();
                        List<CategoryHierarchyDTO> subCategory2 = new List<CategoryHierarchyDTO>();
                        if (SubCategoryList2.Count > 0)
                        {
                            
                            foreach (var item2 in SubCategoryList2)
                            {
                                subCategory2.Add(_mapper.Map<CategoryHierarchyDTO>(item2));
                            }                           
                            subCategory1 = _mapper.Map<CategoryHierarchyDTO>(item1);
                            subCategory1.SubCategory = new List<CategoryHierarchyDTO>();
                            subCategory1.SubCategory.AddRange(subCategory2);
                            MainCategory.SubCategory.Add(subCategory1);
                        }                      
                    }
                    Categories.Add(MainCategory);
                }
                return Categories;
            }
            else
            {
                return null;
            }
            //var categories = _mapper.Map<List<CategoryHierarchyDTO>>(categoriesList);
            //return categories;
        }

        public async Task<List<Category>>GetCategory(string? CategoryName, int? Id)
        {
            List<Category> Categories = new List<Category>();
            if(CategoryName == null && (Id !=null || Id != 0))
            {
                Categories = await _db.Categories.AsNoTracking().Where(x =>x.Id== Id).ToListAsync();
                return Categories;
            }
            if (CategoryName != null && (Id == null || Id == 0))
            {
                Categories = await _db.Categories.Where(x => x.CategoryName == CategoryName).AsNoTracking().ToListAsync();
                return Categories;
            }
            if (CategoryName == null && (Id == null || Id == 0))
            {
                Categories = await _db.Categories.AsNoTracking().ToListAsync();
                return Categories;
            }
            else
            {
                Categories = await _db.Categories.AsNoTracking().Where(x => x.Id == Id && x.CategoryName == CategoryName).ToListAsync();
                return Categories;
            }
        }
        
        public async Task<List<CategorySliderDTO>> GetCategoriesSlider()
        {

            
            //SystemFlag objsysflag = new SystemFlag();
            bool IncludeLeaf = true;
            bool IsTopContent = true;

            List<CategorySliderDTO> _objCategoryList = new List<CategorySliderDTO>();
            var objsysflag = await _db.SystemFlags.Where(x => x.SystemFlagName.Equals("SysCategorySliderCategory")).FirstOrDefaultAsync();
            string CategoryName = null;
            if (objsysflag != null)
            {
                if (!string.IsNullOrEmpty(objsysflag.Value))
                {
                    int CategoryID = Convert.ToInt32(objsysflag.Value);
                    Category objCatgegory = await _db.Categories.Where(x => x.Id == CategoryID).FirstOrDefaultAsync();
                    if (objCatgegory != null && objCatgegory.IsActive == true && objCatgegory.IsDelete == false)
                    {
                        CategorySliderCategory = objCatgegory;
                    }
                }
            }
            if (CategorySliderCategory != null)
            {
                //for With Leaf and Subcategory setting
                objsysflag = _db.SystemFlags.Where(x => x.SystemFlagName.Equals("SysCategorySliderCategoryWithLeaf")).FirstOrDefault();
                if (objsysflag != null)
                {
                    if (!string.IsNullOrEmpty(objsysflag.Value))
                    {
                        IncludeLeaf = Convert.ToBoolean(objsysflag.Value);
                    }
                }

                //for Category Contents setting
                objsysflag = _db.SystemFlags.Where(x => x.SystemFlagName.Equals("SysCategorySliderContentsIsTop10")).FirstOrDefault();
                if (objsysflag != null)
                {
                    if (!string.IsNullOrEmpty(objsysflag.Value))
                    {
                        IsTopContent = Convert.ToBoolean(objsysflag.Value);
                    }
                }

                List<select_SubCategoriesByCategoryID> objSubcategorylist = null;
                if (IncludeLeaf)
                {
                    if (IsTopContent)
                    {
                        List<select_SubCategoriesByCategoryID> subcattest = await _productRepository.GetSubCategoriesByCategoryID(CategorySliderCategory.Id);
                        if (subcattest != null && subcattest.Count > 0)
                        {
                            objSubcategorylist = subcattest.Where(x => x.IsLeaf == true).Take(10).ToList();
                        }
                    }
                    else
                    {
                        List<select_SubCategoriesByCategoryID> subcattest = await _productRepository.GetSubCategoriesByCategoryID(CategorySliderCategory.Id);
                        if (subcattest != null && subcattest.Count > 0)
                        {
                            objSubcategorylist = subcattest.Where(x => x.IsLeaf == true).ToList();
                        }
                    }
                }
                else
                {
                    if (IsTopContent)
                    {
                        List<select_SubCategoriesByCategoryID> subcattest = await _productRepository.GetSubCategoriesByCategoryID(CategorySliderCategory.Id);
                        if (subcattest != null && subcattest.Count > 0)
                        {
                            objSubcategorylist = subcattest.Where(x => x.Depth == ((int)CategorySliderCategory.Depth + 1)).ToList();
                            if (objSubcategorylist.Count > 0)
                            {
                                objSubcategorylist = objSubcategorylist.Take(10).ToList();
                            }
                        }
                    }
                    else
                    {
                        List<select_SubCategoriesByCategoryID> subcattest = await _productRepository.GetSubCategoriesByCategoryID(CategorySliderCategory.Id);
                        if (subcattest != null && subcattest.Count > 0)
                        {
                            objSubcategorylist = subcattest.Where(x => x.Depth == ((int)CategorySliderCategory.Depth + 1)).ToList();
                        }
                    }
                }
                if (objSubcategorylist != null && objSubcategorylist.Count > 0)
                {
                    foreach (var catitem in objSubcategorylist)
                    {
                        string CategoryID = null;
                        //string CategoryName = string.Empty;
                        string CategoryImgPath = string.Empty;
                        var objCategory = await _db.Categories.Where(x => x.Id == (int)catitem.ID).FirstOrDefaultAsync();
                        if (objCategory != null)
                        {
                            bool IsVisiableCategory = false;
                            List<select_SubCategoriesByCategoryID> objSubcategorylistofSubCategory = null;
                            List<ProductVariation> objsubcategoryallvariants = new List<ProductVariation>();
                            if (!IncludeLeaf)
                            {
                                objSubcategorylistofSubCategory = await _productRepository.GetSubCategoriesByCategoryID(CategorySliderCategory.Id);
                                if (objSubcategorylistofSubCategory.Count() > 0)
                                {
                                    IsVisiableCategory = true;
                                }
                                else
                                {
                                    if (catitem.ProductCount == 0)
                                    {
                                        IsVisiableCategory = false;
                                    }
                                    else
                                    {
                                        IsVisiableCategory = true;
                                    }
                                }
                                if (string.IsNullOrEmpty(catitem.ImagePath))
                                {
                                    if (IsVisiableCategory)
                                    {
                                        List<ProductVariation> objTempSubCatvariant = bc.GetTop4PoplarProductVariant(objCategory.Id, null);
                                        if (objTempSubCatvariant != null && objTempSubCatvariant.Count > 0)
                                        {
                                            foreach (ProductVariation item in objTempSubCatvariant)
                                            {
                                                objsubcategoryallvariants.Add(item);
                                            }
                                        }

                                        foreach (select_SubCategoriesByCategoryID Subcategoryofsubcategory in objSubcategorylistofSubCategory)
                                        {
                                            
                                            objTempSubCatvariant = bc.GetTop4PoplarProductVariant((int)Subcategoryofsubcategory.ID, null);
                                            if (objTempSubCatvariant != null && objTempSubCatvariant.Count > 0)
                                            {
                                                foreach (ProductVariation item in objTempSubCatvariant)
                                                {
                                                    objsubcategoryallvariants.Add(item);
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                            else
                            {
                                if (catitem.ProductCount == 0)
                                {
                                    IsVisiableCategory = false;
                                }
                                else
                                {
                                    IsVisiableCategory = true;
                                    List<ProductVariation> objTempSubCatvariant = bc.GetTop4PoplarProductVariant(objCategory.Id, null);
                                    if (objTempSubCatvariant != null && objTempSubCatvariant.Count > 0)
                                    {
                                        foreach (ProductVariation item in objTempSubCatvariant)
                                        {
                                            objsubcategoryallvariants.Add(item);
                                        }
                                    }
                                }
                            }

                            if (IsVisiableCategory)
                            {
                                CategoryName = objCategory.CategoryName.ToString().Trim();
                                //CategoryID = AE.Encrypt(objCategory.ID.ToString());

                                if (objCategory.CategoryImages.Count > 0)
                                {
                                    // Assuming you are in a Controller or Razor Page
                                    // You can use dependency injection to access the HttpContext

                                    CategoryImage objCategoryImage = objCategory.CategoryImages.FirstOrDefault(x => x.ImageOrderNo == 0);

                                    //if (objCategoryImage != null)
                                    //{
                                    //    // Accessing HttpContext in ASP.NET Core
                                    //    string subdomain = $"{this.Request.Scheme}://{this.Request.Host}";

                                    //    // Note: The "~" in ASP.NET Core is not used for path resolution, so you may need to adjust the path accordingly
                                    //    CategoryImgPath = $"{subdomain}/{objCategoryImage.Image.ImagePath.Replace("~", "")}";

                                    //    // Using IHostingEnvironment to map the path in ASP.NET Core
                                    //    string filePath = this.HostingEnvironment.WebRootPath + CategoryImgPath;

                                    //    if (System.IO.File.Exists(filePath))
                                    //    {
                                    //        CategoryImgPath = "/img/NoImage.jpg";
                                    //    }
                                    //}

                                    //else
                                    //{
                                    //    foreach (CategoryImage objCategoryImageTemp in objCategory.CategoryImages)
                                    //    {
                                    //        if (objCategoryImageTemp != null)
                                    //        {
                                    //            CategoryImgPath = Subdomain + objCategoryImage.Image.ImagePath.Replace("~", "");
                                    //            if (!File.Exists(HttpContext.Current.Server.MapPath(CategoryImgPath)))
                                    //            {
                                    //                CategoryImgPath = "/img/NoImage.jpg";
                                    //            }
                                    //            break;
                                    //        }
                                    //    }
                                    //}
                                }
                                else
                                {
                                    CategoryImgPath = "/img/NoImage.jpg";
                                }
                            }
                        }
                        _objCategoryList.Add(new CategorySliderDTO()
                        {
                            CategoryID = CategoryID,
                            CategoryName = CategoryName,
                            CategoryImage = CategoryImgPath
                        });
                    }
                }
                else
                {
                    return null;
                }
            }
            return null;
        }

    }
}
