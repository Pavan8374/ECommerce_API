using AutoMapper;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using NatShopB2C.Domain.IRepositories;
using NatShopB2C.Domain.Models;
using NatShopB2C.Domain.StoredProcedureModels;
using NatShopB2C.EF.Common.DTO;
using NatShopB2C.EF.Data;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NatShopB2C.EF.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly ApplicationDbContext _db;
        private readonly IMapper _mapper;
        public CategoryRepository(ApplicationDbContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }

        public async Task<List<select_CategoryDetailsByFilter>> GetCategories(int? StartIndex, int? EndIndex, bool? IsActive, bool? IsArchieve)
        {
            bool IsShowOutofStockProducts = true;

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

        public async  Task<List<CategoryHierarchyDTO>> GetcategoryHierarchy()
        {
            List<CategoryHierarchyDTO> Categories = new List<CategoryHierarchyDTO>();
            var objParam = new SqlParameter("@TotalRecords", SqlDbType.Int)
            {
                Direction = ParameterDirection.Output
            };
            int? StartIndex = 1; int? EndIndex = 1000; bool? IsActive = true;bool? IsArchieve = false; string? SearchString = null;
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
                        List<CategoryHierarchyDTO> subCategory2 = new List<CategoryHierarchyDTO>();
                        foreach (var item2 in SubCategoryList2)
                        {
                            subCategory2.Add(_mapper.Map<CategoryHierarchyDTO>(item2));
                        }
                        CategoryHierarchyDTO subCategory1 = new CategoryHierarchyDTO();

                        subCategory1 = _mapper.Map<CategoryHierarchyDTO>(item1);
                        subCategory1.SubCategory = new List<CategoryHierarchyDTO>();
                        subCategory1.SubCategory.AddRange(subCategory2);    //Add Sub Category List 2
                        MainCategory.SubCategory.Add(subCategory1);     //Add Sub Category List 1
                    }
                    Categories.Add(MainCategory);
                }
                return Categories;
            }
            else
            {
                return null;
            }
        }

    }
}
