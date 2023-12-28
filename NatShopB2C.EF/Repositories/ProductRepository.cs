using Microsoft.EntityFrameworkCore;
using NatShopB2C.Domain.IRepositories;
using NatShopB2C.Domain.Models;
using NatShopB2C.EF.Common.Products;
using NatShopB2C.EF.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using NatShopB2C.EF.Common;
using System.Runtime.CompilerServices;
using NatShopB2C.Domain.AccountModels;
using Microsoft.Data.SqlClient;
using NatShopB2C.Domain.StoredProcedureModels;
using System.Data;
using System.Collections;
using System.Web;
using Microsoft.AspNetCore.Http;
using AutoMapper;
using NatShopB2C.EF.Common.DTO.ProdutDTOs;
using System.Drawing;

namespace NatShopB2C.EF.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly ApplicationDbContext _db;
        private readonly IMapper _mapper;
        public ProductRepository(ApplicationDbContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }

        public async Task<Product> AddProduct(Product product)
        {
            product.Id = Guid.NewGuid();
            await _db.Products.AddRangeAsync(product);
            await _db.SaveChangesAsync();
            return product;
        }
        public async Task<Product> UpdateProduct(Product product)
        {
            _db.Products.Update(product);
            await _db.SaveChangesAsync();
            return product;
        }
        public async Task<Product> DeleteProduct(Product product)
        {
            _db.Products.Remove(product);
            await _db.SaveChangesAsync();
            return product;
        }
        public async Task<List<Product>> GetProducts()
        {
            var products = await _db.Products
                .Include(x => x.ProductVariations)
                    .ThenInclude(y => y.ProductVariationImages)
                        .ThenInclude(o => o.Image)
                .AsNoTracking()
                .ToListAsync();
            return products;
        }
        public async Task<List<select_ProductsDetailsByFilter>> GetProductsByFilter(int? startIndex, int? endIndex, string? ProductID, bool? isActive, bool? isDelete)
        {
            //var objParam = new SqlParameter("@TotalRecords", SqlDbType.Int)
            //{
            //    Direction = ParameterDirection.Output
            //};

            string sql = "EXEC usp_select_ProductsDetailsByFilter  @startIndex, @endIndex, @ProductID, @isActive,  @isDelete";

            SqlParameter[] parms = new SqlParameter[]
            { 
                // Create parameters    
                new SqlParameter("@startIndex", startIndex),
                new SqlParameter("@endIndex", endIndex),
                new SqlParameter("@ProductID", string.IsNullOrEmpty(ProductID) ? DBNull.Value : (object)ProductID),
                new SqlParameter("@isActive", isActive),
                new SqlParameter("@isDelete", isDelete)
            };

            var products = await _db.select_ProductsDetailsByFilter
                .FromSqlRaw(sql, parms)
                .ToListAsync();

            // Access the output parameter value
            //var totalRecords = (int)objParam.Value;

            return products;
        }
        //public async Task<List<ProductImagePathDTO>> GetProducts()
        //{
        //    //var products = await _db.Products
        //    //    .Include(x => x.ProductVariations)
        //    //        .ThenInclude(y => y.ProductVariationImages)
        //    //            .ThenInclude(o => o.Image)
        //    //    .AsNoTracking()
        //    //    .ToListAsync();

        //    var productsWithImages = _db.Products
        //.Include(p => p.ProductVariations)
        //    .ThenInclude(pv => pv.ProductVariationImages)
        //        .ThenInclude(img => img.Image)
        //.Select(product => new ProductImagePathDTO
        //{
        //    ProductID = product.Id,
        //    ProductName = product.ProductName,
        //    ProductVariationID = product.ProductVariations.Select(y => y.Id).FirstOrDefault(),
        //    ProductVariationImageID = product.ProductVariations.SelectMany(y => y.ProductVariationImages.Select(y => y.Id)).FirstOrDefault(),
        //    ImageID = product.ProductVariations
        //        .SelectMany(variation => variation.ProductVariationImages
        //            .Select(image => image.Image.Id))
        //        .FirstOrDefault(),
        //    ProductVariantPriceID = product.ProductVariations.SelectMany(y => y.ProductVariationPrices.Select(y => y.Id)).FirstOrDefault(),
        //    BrandId = product.,
        //    BrandName = product.,
        //    CategoryName = product.,
        //    ProductCode = product.,
        //    Price = product.,
        //    Rating = product.,
        //    Description = product.,
        //    StockTypeName = product.,
        //    ImagePath = product.ProductVariations
        //        .SelectMany(variation => variation.ProductVariationImages
        //            .Select(image => image.Image.ImagePath))
        //        .FirstOrDefault()
        //})
        //.ToList();

        //    return productsWithImages;
        //}

        public async Task<Product> GetProduct(Guid? id)
        {
            var product = await _db.Products.AsNoTracking().Where(x => x.Id == id).FirstOrDefaultAsync();
            return product;
        }
        public Product GetProductById(Guid? id)
        {
            var product = _db.Products.AsNoTracking().Where(x => x.Id == id).FirstOrDefault();
            return product;
        }
        public async Task<ProductVariation> AddProductVarient(ProductVariation varient)
        {
            varient.Id = Guid.NewGuid();
            await _db.ProductVariations.AddAsync(varient);
            await _db.SaveChangesAsync();
            return varient;
        }


        public async Task<List<ProductByAllFilterOptionsDTO>> GetProductByFilterOption(string ID)
        {
            string typeName = "";
            string BrandID = null, CategoryID = null, UsageTypeID = null, KeywordString = "", DiscountID = "";
            int StartCatalogIndex = 0;
            int EndCatalogIndex = 0;
            decimal? _dMinPrice = 0;
            decimal? _dMaxPrice = 0;
            List<ProductByAllFilterOptionsDTO> ProductList = new List<ProductByAllFilterOptionsDTO>();

            var objsysflag = await _db.SystemFlags.Where(x => x.SystemFlagName == "SysShowDefaultProducts").FirstOrDefaultAsync();
            if (objsysflag != null)
            {
                if (!string.IsNullOrEmpty(objsysflag.Value))
                {
                    StartCatalogIndex = 0;
                    EndCatalogIndex = Convert.ToInt32(objsysflag.Value);
                }
            }
            string SpecificationValueString = null;


            char[] delimeters = { '~', '|' };
            string[] types = ID.Split(delimeters, StringSplitOptions.RemoveEmptyEntries);

            if (types.Length > 1)
            {

                foreach (string item in types)
                {
                    if (item.Substring(0, 1).ToUpper() == "B")
                    {
                        BrandID = (item.Substring(1));
                    }

                    if (item.Substring(0, 1).ToUpper() == "C")
                    {
                        CategoryID = (item.Substring(1));
                    }

                    if (item.Substring(0, 1).ToUpper() == "U")
                    {
                        UsageTypeID = (item.Substring(1));
                    }
                }

                Brand objBrand = null;
                Category objCategory = null;
                if (!string.IsNullOrEmpty(BrandID))
                {
                    objBrand = _db.Brands.AsEnumerable().Where(x => x.Id == int.Parse(BrandID)).FirstOrDefault();
                }
                if (!string.IsNullOrEmpty(CategoryID))
                {
                    Convert.ToInt32(CategoryID);
                    objCategory = _db.Categories.AsEnumerable().Where(x => x.Id == int.Parse(CategoryID)).FirstOrDefault();
                }
                //loadproductdata function
                var products = await GetProductsByFilterOptions(StartCatalogIndex, EndCatalogIndex, null, BrandID, CategoryID, UsageTypeID, null, SpecificationValueString, null, _dMinPrice, _dMaxPrice, "CreatedDate", false);
                if(products.Count > 0)
                {
                    foreach (var product in products)
                    {
                        ProductList.Add(new ProductByAllFilterOptionsDTO()
                        {
                            BrandName = product.BrandName,
                            ProductVariationRating = product.ProductVariationRating,
                            Caption = product.Caption,
                            ImagePath = product.ImagePath,
                            alt = product.alt,
                            UnitCode = product.UnitCode,
                            CategoryName = product.CategoryName,
                            ProductCode = product.ProductCode,
                            ProductName = product.ProductName,
                            LinkURL = product.LinkURL,
                            Quantity = product.Quantity,
                            Price = product.Price,
                            MinOrderQuantity = product.MinOrderQuantity,
                            MaxOrderQuantity = product.MaxOrderQuantity,
                            SKUID = product.SKUID,
                            Rating = product.Rating,
                            LaunchDate = product.LaunchDate,
                            Popularity = product.Popularity,
                            IsNew = product.IsNew,
                            IsCOD = product.IsCOD,
                            IsEMI = product.IsEMI,
                            IsTaxable = product.IsSubscribable,
                            StockQuantity = product.StockQuantity,
                            Description = product.Description
                            
                        });
                    }
                }
                
                return ProductList;
            }
            else
            {
                //bool _bIsExists = false;
                typeName = ID.Substring(0, 1).ToUpper();
                if (typeName == "C")
                {
                    Category objCategory = _db.Categories.AsEnumerable().Where(x => x.Id == int.Parse(CategoryID)).FirstOrDefault();
                    var _objSubCategories = GetSubCategoriesByCategoryID(Convert.ToInt32(CategoryID));
                    var products = await GetProductsByFilterOptions(StartCatalogIndex, EndCatalogIndex, null, BrandID, CategoryID, UsageTypeID, null, SpecificationValueString, null, _dMinPrice, _dMaxPrice, "CreatedDate", false);
                    if (products.Count > 0)
                    {
                        foreach (var product in products)
                        {
                            ProductList.Add(new ProductByAllFilterOptionsDTO()
                            {
                                BrandName = product.BrandName,
                                ProductVariationRating = product.ProductVariationRating,
                                Caption = product.Caption,
                                ImagePath = product.ImagePath,
                                alt = product.alt,
                                UnitCode = product.UnitCode,
                                CategoryName = product.CategoryName,
                                ProductCode = product.ProductCode,
                                ProductName = product.ProductName,
                                LinkURL = product.LinkURL,
                                Quantity = product.Quantity,
                                Price = product.Price,
                                MinOrderQuantity = product.MinOrderQuantity,
                                MaxOrderQuantity = product.MaxOrderQuantity,
                                SKUID = product.SKUID,
                                Rating = product.Rating,
                                LaunchDate = product.LaunchDate,
                                Popularity = product.Popularity,
                                IsNew = product.IsNew,
                                IsCOD = product.IsCOD,
                                IsEMI = product.IsEMI,
                                IsTaxable = product.IsSubscribable,
                                StockQuantity = product.StockQuantity,
                                Description = product.Description

                            });
                        }
                    }

                    return ProductList;
                    //_bIsExists = true;
                }
                if (typeName == "B")
                {
                    Brand objBrand = _db.Brands.AsEnumerable().Where(x => x.Id == int.Parse(BrandID)).FirstOrDefault();
                    //loadproductdata function
                    var products = await GetProductsByFilterOptions(StartCatalogIndex, EndCatalogIndex, null, BrandID, CategoryID, UsageTypeID, null, SpecificationValueString, null, _dMinPrice, _dMaxPrice, "CreatedDate", false);
                    if (products.Count > 0)
                    {
                        foreach (var product in products)
                        {
                            ProductList.Add(new ProductByAllFilterOptionsDTO()
                            {
                                BrandName = product.BrandName,
                                ProductVariationRating = product.ProductVariationRating,
                                Caption = product.Caption,
                                ImagePath = product.ImagePath,
                                alt = product.alt,
                                UnitCode = product.UnitCode,
                                CategoryName = product.CategoryName,
                                ProductCode = product.ProductCode,
                                ProductName = product.ProductName,
                                LinkURL = product.LinkURL,
                                Quantity = product.Quantity,
                                Price = product.Price,
                                MinOrderQuantity = product.MinOrderQuantity,
                                MaxOrderQuantity = product.MaxOrderQuantity,
                                SKUID = product.SKUID,
                                Rating = product.Rating,
                                LaunchDate = product.LaunchDate,
                                Popularity = product.Popularity,
                                IsNew = product.IsNew,
                                IsCOD = product.IsCOD,
                                IsEMI = product.IsEMI,
                                IsTaxable = product.IsSubscribable,
                                StockQuantity = product.StockQuantity,
                                Description = product.Description

                            });
                        }
                    }

                    return ProductList;
                    //_bIsExists = true;
                }
                if (typeName == "K")
                {
                    KeywordString = HttpUtility.UrlDecode(ID.Substring(1));
                    //loadproductdata function
                    var products = await GetProductsByFilterOptions(StartCatalogIndex, EndCatalogIndex, null, BrandID, CategoryID, UsageTypeID, null, SpecificationValueString, null, _dMinPrice, _dMaxPrice, "CreatedDate", false);
                    if (products.Count > 0)
                    {
                        foreach (var product in products)
                        {
                            ProductList.Add(new ProductByAllFilterOptionsDTO()
                            {
                                BrandName = product.BrandName,
                                ProductVariationRating = product.ProductVariationRating,
                                Caption = product.Caption,
                                ImagePath = product.ImagePath,
                                alt = product.alt,
                                UnitCode = product.UnitCode,
                                CategoryName = product.CategoryName,
                                ProductCode = product.ProductCode,
                                ProductName = product.ProductName,
                                LinkURL = product.LinkURL,
                                Quantity = product.Quantity,
                                Price = product.Price,
                                MinOrderQuantity = product.MinOrderQuantity,
                                MaxOrderQuantity = product.MaxOrderQuantity,
                                SKUID = product.SKUID,
                                Rating = product.Rating,
                                LaunchDate = product.LaunchDate,
                                Popularity = product.Popularity,
                                IsNew = product.IsNew,
                                IsCOD = product.IsCOD,
                                IsEMI = product.IsEMI,
                                IsTaxable = product.IsSubscribable,
                                StockQuantity = product.StockQuantity,
                                Description = product.Description

                            });
                        }
                    }

                    return ProductList;
                    // _bIsExists = true;
                }
                if (typeName == "D")
                {
                    
                    if (!string.IsNullOrEmpty(DiscountID))
                    {
                        Discount objDiscount = _db.Discounts.AsEnumerable().Where(x => x.Id == int.Parse(DiscountID) && x.IsActive == true && x.IsDelete == false).FirstOrDefault();
                        //loadproductdata function
                        var products = await GetProductsByFilterOptions(StartCatalogIndex, EndCatalogIndex, null, BrandID, CategoryID, UsageTypeID, null, SpecificationValueString, null, _dMinPrice, _dMaxPrice, "CreatedDate", false);
                        if (products.Count > 0)
                        {
                            foreach (var product in products)
                            {
                                ProductList.Add(new ProductByAllFilterOptionsDTO()
                                {
                                    BrandName = product.BrandName,
                                    ProductVariationRating = product.ProductVariationRating,
                                    Caption = product.Caption,
                                    ImagePath = product.ImagePath,
                                    alt = product.alt,
                                    UnitCode = product.UnitCode,
                                    CategoryName = product.CategoryName,
                                    ProductCode = product.ProductCode,
                                    ProductName = product.ProductName,
                                    LinkURL = product.LinkURL,
                                    Quantity = product.Quantity,
                                    Price = product.Price,
                                    MinOrderQuantity = product.MinOrderQuantity,
                                    MaxOrderQuantity = product.MaxOrderQuantity,
                                    SKUID = product.SKUID,
                                    Rating = product.Rating,
                                    LaunchDate = product.LaunchDate,
                                    Popularity = product.Popularity,
                                    IsNew = product.IsNew,
                                    IsCOD = product.IsCOD,
                                    IsEMI = product.IsEMI,
                                    IsTaxable = product.IsSubscribable,
                                    StockQuantity = product.StockQuantity,
                                    Description = product.Description

                                });
                            }
                        }

                        return ProductList;
                        // _bIsExists = true;
                    }
                }
            }
            return ProductList;
        }

        
        public async Task<List<ProductByAllFilterOptions>> GetProductsByFilterOptions(int? Start, int? End, string? ProductID, string? BrandID, string? CategoryID, string? UsageTypeID, string? Keyword, string? SpecificationValueList, string? DiscountIDList, decimal? MinPrice, decimal? MaxPrice, string? OrderColumn, bool? IsAscending)
        {
            // Call the stored procedure using FromSqlRaw
            bool IsShowOutofStockProducts = true;

            // Specify SqlDbType.Int for objParam
            var objParam = new SqlParameter("@TotalRecords", SqlDbType.Int)
            {
                Direction = ParameterDirection.Output
            };

            string sql = "EXEC usp_select_ProductByAllFilterOptions  @Start, @End, @ProductID, @BrandID, @CategoryID, @UsageTypeID, @Keyword, @SpecificationValueList, @DiscountIDList, @MinPrice, @MaxPrice, @OrderColumn, @IsAscending, @IsShowOutofStockProducts, @TotalRecords OUTPUT";

            SqlParameter[] parms = new SqlParameter[]
            { 
        // Create parameters    
        new SqlParameter("@Start", Start),
        new SqlParameter("@End", End),
        new SqlParameter("@ProductID", string.IsNullOrEmpty(ProductID) ? DBNull.Value : (object)ProductID),
        new SqlParameter("@BrandID", string.IsNullOrEmpty(BrandID) ? DBNull.Value : (object)BrandID),
        new SqlParameter("@CategoryID", string.IsNullOrEmpty(CategoryID) ? DBNull.Value : (object)CategoryID),
        new SqlParameter("@UsageTypeID", string.IsNullOrEmpty(UsageTypeID) ? DBNull.Value : (object)UsageTypeID),
        new SqlParameter("@Keyword", string.IsNullOrEmpty(Keyword) ? DBNull.Value : (object)Keyword),
        new SqlParameter("@SpecificationValueList", string.IsNullOrEmpty(SpecificationValueList) ? DBNull.Value : (object)SpecificationValueList),
        new SqlParameter("@DiscountIDList", string.IsNullOrEmpty(DiscountIDList) ? DBNull.Value : (object)DiscountIDList),
        new SqlParameter("@MinPrice", MinPrice),
        new SqlParameter("@MaxPrice", MaxPrice),
        new SqlParameter("@OrderColumn", string.IsNullOrEmpty(OrderColumn) ? DBNull.Value : (object)OrderColumn),
        new SqlParameter("@IsAscending", IsAscending),
        new SqlParameter("@IsShowOutofStockProducts", IsShowOutofStockProducts),
        objParam // Use objParam directly
            };

            var products = await _db.ProductByAllFilterOptions
                .FromSqlRaw(sql, parms)
                .ToListAsync();

            // Access the output parameter value
            var totalRecords = (int)objParam.Value;

            return products;
        }

        public async Task<List<select_SubCategoriesByCategoryID>> GetSubCategoriesByCategoryID(int categoryID)
        {
            string sql = "EXEC usp_select_SubCategoriesByCategoryID  @categoryID";

            SqlParameter[] parms = new SqlParameter[]
            {
                // Create parameters    
             new SqlParameter("@Start", categoryID)
            };
            var categories = await _db.usp_select_SubCategoriesByCategoryID
                .FromSqlRaw(sql, parms)
                .ToListAsync();
            return categories;
        }
        public bool IsAllowedOutofStockInCart = true;
        public async Task<List<select_Slider_NewProduct>> GetNewProduct(int? StartIndex, int? EndIndex)
        {
            List<NewProdcutDTO> newproductlist = new List<NewProdcutDTO>();
            var productlist = await _db.select_Slider_NewProduct.FromSqlRaw($"usp_select_Slider_NewProduct {StartIndex}, {EndIndex}").ToListAsync();
            if (productlist != null)
            {
                foreach (var productitem in productlist)
                {
                    Product objNewProduct = GetProductById(productitem.ProductID);


                    if (objNewProduct == null)
                    {
                        continue;
                    }
                    int AvailableStockQty = 0;
                    string ProductName = string.Empty;
                    string ProductImage = string.Empty;
                    string ProductPriceID = string.Empty;
                    ProductVariation objProductVarient = objNewProduct.ProductVariations.Where(x => x.IsDefaultProductVariation == true).FirstOrDefault();
                    if (objProductVarient != null)
                    {
                        ProductName = (objProductVarient.Caption != null) ? objProductVarient.Caption.ToString() : objProductVarient.Product.ProductName.ToString();
                        if (objProductVarient.ProductVariationImages.Count > 0)
                        {
                            ProductVariationImage objProductVarientImage = objProductVarient.ProductVariationImages.Where(x => x.ImageOrderNo == 0).FirstOrDefault();
                            if (objProductVarientImage != null)
                            {
                                int Position = objProductVarientImage.Image.ImagePath.IndexOf(objProductVarientImage.Image.Id.ToString());
                                string ImageName = objProductVarientImage.Image.ImagePath.Substring(Position);
                                string DirectoryName = objProductVarientImage.Image.ImagePath.Replace(ImageName, "").Replace("~/", "");
                                DirectoryName += "Medium/";
                                ImageName = DirectoryName + ImageName;
                                //if (!File.Exists(HttpContext.Current.Server.MapPath(Subdomain + ImageName)))
                                //{
                                //    ProductImage = Subdomain + ImageName;
                                //}
                                //else
                                //{
                                //    ProductImage = "/img/NoImage.jpg";
                                //}
                            }
                            else
                            {
                                ProductImage = "/img/NoImage.jpg";
                            }
                        }
                        else
                        {
                            ProductImage = "/img/NoImage.jpg";
                        }

                        if (objProductVarient.ProductVariationPrices.Count() > 0)
                        {
                            ProductVariationPrice objProductVarientPrice = objProductVarient.ProductVariationPrices.Where(x => x.IsDefaultPrice == true).FirstOrDefault();
                            if (objProductVarientPrice != null)
                            {
                                ProductPriceID = objProductVarientPrice.PriceId.ToString();
                            }
                            else
                            {
                                ProductPriceID = null;
                            }
                        }
                        else
                        {
                            ProductPriceID = null;
                        }
                    }


                    //    else
                    //    {
                    //        ProductName = objNewProduct.ProductName.ToString();
                    //        ProductImage = "";
                    //        ProductPriceID = "";
                    //    }
                    //    bool IsAddToCartVisiable = true;
                    //    SystemFlag objsysflag = null;
                    //    bool IsOutofStock = true;
                    //    objsysflag = await _db.SystemFlags.Where(x => x.SystemFlagName.Equals("SysShowAddToCartButton")).FirstOrDefaultAsync();
                    //    if (objsysflag != null)
                    //    {
                    //        if (!string.IsNullOrEmpty(objsysflag.Value))
                    //        {
                    //            IsAddToCartVisiable = Convert.ToBoolean(objsysflag.Value);
                    //        }
                    //    }

                    //    if (IsAddToCartVisiable)
                    //    {
                    //        IsOutofStock = IsProductOutofStock(objNewProduct, 1, out AvailableStockQty);
                    //        if (IsOutofStock == true && IsAllowedOutofStockInCart == false)
                    //        {
                    //            IsAddToCartVisiable = false;
                    //        }
                    //    }

                    //    bool IsAddToWishListVisiable = true;
                    //    objsysflag = await _db.SystemFlags.Where(x => x.SystemFlagName.Equals("SysShowAddToWishListButton")).FirstOrDefaultAsync();
                    //    if (objsysflag != null)
                    //    {
                    //        if (!string.IsNullOrEmpty(objsysflag.Value))
                    //        {
                    //            IsAddToWishListVisiable = Convert.ToBoolean(objsysflag.Value);
                    //        }
                    //    }

                    //    bool IsAddToCompareVisiable = true;
                    //    objsysflag = _db.SystemFlags.Where(x => x.SystemFlagName.Equals("SysShowAddToCompareButton")).FirstOrDefault();
                    //    if (objsysflag != null)
                    //    {
                    //        if (!string.IsNullOrEmpty(objsysflag.Value))
                    //        {
                    //            IsAddToCompareVisiable = Convert.ToBoolean(objsysflag.Value);
                    //        }
                    //    }

                    //    bool IsPriceVisiable = true;
                    //    objsysflag = _db.SystemFlags.Where(x => x.SystemFlagName.Equals("SysShowPrice")).FirstOrDefault();
                    //    if (objsysflag != null)
                    //    {
                    //        if (!string.IsNullOrEmpty(objsysflag.Value))
                    //        {
                    //            IsPriceVisiable = Convert.ToBoolean(objsysflag.Value);
                    //        }
                    //    }

                    //    newproductlist.Add(new NewProdcutDTO()
                    //    {
                    //        ProductID = objNewProduct.ToString(),
                    //        ProductVariationID = objProductVarient.Id.ToString(),
                    //        ProductName = ProductName,
                    //        ProdcutDesc = objNewProduct.Description,
                    //        Price = Convert.ToDecimal(productitem.Price),
                    //        ProductCode = productitem.ProductCode,
                    //        ImagePath = ProductImage,
                    //        ProductPriceID = ProductPriceID,
                    //        Rating = Convert.ToDecimal(productitem.Rating),
                    //        IsAddToCartVisiable = IsAddToCartVisiable,
                    //        IsAddToWishListVisiable = IsAddToWishListVisiable,
                    //        IsAddToCompareVisiable = IsAddToCompareVisiable,
                    //        IsPriceVisiable = IsPriceVisiable,
                    //        IsOutofStock = IsOutofStock
                    //    });
                    //}
                    //return _mapper.Map<List<select_Slider_NewProduct>>(newproductlist);
                }
                return productlist;
            }
            else
            {
                return null;
            }


        }
     

        public async Task<List<select_Slider_UpCommingProduct>> GetUpcomingProducts(int? StartIndex, int? EndIndex)
        {
            List<UpCommingProductDTO> _objUpcommingProduct = new List<UpCommingProductDTO>();
            var productlist = await _db.select_Slider_UpCommingProduct.FromSqlRaw($"usp_select_Slider_UpCommingProduct {StartIndex}, {EndIndex}").ToListAsync();
            if (productlist != null)
            {
                foreach (var productitem in productlist)
                {
                    Product objUpcommingProduct = GetProductById(productitem.ProductID);


                    if (objUpcommingProduct == null)
                    {
                        continue;
                    }
                    int AvailableStockQty = 0;
                    string ProductName = string.Empty;
                    string ProductImage = string.Empty;
                    string ProductPriceID = string.Empty;
                    ProductVariation objProductVarient = objUpcommingProduct.ProductVariations.Where(x => x.IsDefaultProductVariation == true).FirstOrDefault();
                    if (objProductVarient != null)
                    {
                        ProductName = (objProductVarient.Caption != null) ? objProductVarient.Caption.ToString() : objProductVarient.Product.ProductName.ToString();
                        if (objProductVarient.ProductVariationImages.Count > 0)
                        {
                            ProductVariationImage objProductVarientImage = objProductVarient.ProductVariationImages.Where(x => x.ImageOrderNo == 0).FirstOrDefault();
                            if (objProductVarientImage != null)
                            {
                                int Position = objProductVarientImage.Image.ImagePath.IndexOf(objProductVarientImage.Image.Id.ToString());
                                string ImageName = objProductVarientImage.Image.ImagePath.Substring(Position);
                                string DirectoryName = objProductVarientImage.Image.ImagePath.Replace(ImageName, "").Replace("~/", "");
                                DirectoryName += "Medium/";
                                ImageName = DirectoryName + ImageName;
                                //if (!File.Exists(HttpContext.Current.Server.MapPath(Subdomain + ImageName)))
                                //{
                                //    ProductImage = Subdomain + ImageName;
                                //}
                                //else
                                //{
                                //    ProductImage = "/img/NoImage.jpg";
                                //}
                            }
                            else
                            {
                                ProductImage = "/img/NoImage.jpg";
                            }
                        }
                        else
                        {
                            ProductImage = "/img/NoImage.jpg";
                        }

                        if (objProductVarient.ProductVariationPrices.Count() > 0)
                        {
                            ProductVariationPrice objProductVarientPrice = objProductVarient.ProductVariationPrices.Where(x => x.IsDefaultPrice == true).FirstOrDefault();
                            if (objProductVarientPrice != null)
                            {
                                ProductPriceID = objProductVarientPrice.PriceId.ToString();
                            }
                            else
                            {
                                ProductPriceID = null;
                            }
                        }
                        else
                        {
                            ProductPriceID = null;
                        }
                    }
                    //    else
                    //    {
                    //        ProductName = productitem.ProductName.ToString();
                    //        ProductImage = "";
                    //        ProductPriceID = "";
                    //    }

                    //    bool IsAddToCartVisiable = true;
                    //    SystemFlag objsysflag = null;
                    //    bool IsOutofStock = true;
                    //    objsysflag = _db.SystemFlags.Where(x => x.SystemFlagName.Equals("SysShowAddToCartButton")).FirstOrDefault();
                    //    {
                    //        if (objsysflag != null)
                    //        {
                    //            if (!string.IsNullOrEmpty(objsysflag.Value))
                    //            {
                    //                IsAddToCartVisiable = Convert.ToBoolean(objsysflag.Value);
                    //            }
                    //        }
                    //    }
                    //    if (IsAddToCartVisiable)
                    //    {
                    //        IsOutofStock = IsProductOutofStock(objUpcommingProduct, 1, out AvailableStockQty);
                    //        if (IsOutofStock == true && IsAllowedOutofStockInCart == false)
                    //        {
                    //            IsAddToCartVisiable = false;
                    //        }
                    //    }
                    //    bool IsAddToWishListVisiable = true;
                    //    objsysflag = _db.SystemFlags.Where(x => x.SystemFlagName.Equals("SysShowAddToWishListButton")).FirstOrDefault();
                    //    if (objsysflag != null)
                    //    {
                    //        if (!string.IsNullOrEmpty(objsysflag.Value))
                    //        {
                    //            IsAddToWishListVisiable = Convert.ToBoolean(objsysflag.Value);
                    //        }
                    //    }
                    //    bool IsAddToCompareVisiable = true;
                    //    objsysflag = _db.SystemFlags.Where(x => x.SystemFlagName.Equals("SysShowAddToCompareButton")).FirstOrDefault();
                    //    if (objsysflag != null)
                    //    {
                    //        if (!string.IsNullOrEmpty(objsysflag.Value))
                    //        {
                    //            IsAddToCompareVisiable = Convert.ToBoolean(objsysflag.Value);
                    //        }
                    //    }
                    //    bool IsPriceVisiable = true;
                    //    objsysflag = _db.SystemFlags.Where(x => x.SystemFlagName.Equals("SysShowPrice")).FirstOrDefault();
                    //    if (objsysflag != null)
                    //    {
                    //        if (!string.IsNullOrEmpty(objsysflag.Value))
                    //        {
                    //            IsPriceVisiable = Convert.ToBoolean(objsysflag.Value);
                    //        }
                    //    }
                    //    IsOutofStock = IsProductOutofStock(objProductVarient.Product, 1, out AvailableStockQty);
                    //    _objUpcommingProduct.Add(new UpCommingProductDTO()
                    //    {
                    //        ProductID = productitem.ProductID.ToString(),
                    //        ProductVariationID = productitem.ProductVariationID.ToString(),
                    //        ProductName = ProductName,
                    //        ProdcutDesc = objUpcommingProduct.Description,
                    //        Price = Convert.ToDecimal(productitem.Price),
                    //        ProductCode = productitem.ProductCode,
                    //        ImagePath = ProductImage,
                    //        ProductPriceID = ProductPriceID,
                    //        Rating = Convert.ToDecimal(productitem.Rating),
                    //        IsAddToCartVisiable = IsAddToCartVisiable,
                    //        IsAddToWishListVisiable = IsAddToWishListVisiable,
                    //        IsAddToCompareVisiable = IsAddToCompareVisiable,
                    //        IsPriceVisiable = IsPriceVisiable,
                    //        IsOutofStock = IsOutofStock

                    //    });
                    //}
                    //return _mapper.Map<List<select_Slider_UpCommingProduct>>(_objUpcommingProduct);
                }
                return productlist;
            }
            else
            {
                return null;
            }
            
            
        }

        public bool IsProductOutofStock(Product objProduct, int quantity, out int AvailableStockQty)
        {
            bool IsOutOfStock = true;
            AvailableStockQty = 0;
            try
            {
                if (objProduct != null)
                {
                    switch (objProduct.StockTypeId)
                    {
                        case 1:
                            //Available
                            IsOutOfStock = false;
                            break;
                        case 2:
                            //InStock
                            if (objProduct.StockQuantity != null)
                            {
                                if (objProduct.StockQuantity >= quantity)
                                {
                                    IsOutOfStock = false;
                                }
                                else
                                {
                                    AvailableStockQty = (int)objProduct.StockQuantity;
                                    IsOutOfStock = true;
                                }
                            }
                            else
                            {
                                IsOutOfStock = true;
                            }
                            break;
                        case 3:
                            //Not available
                            IsOutOfStock = true;
                            break;
                        case 4:
                            //Pre-Order
                            IsOutOfStock = true;
                            break;
                        default:
                            break;
                    }
                }
                else
                {
                    IsOutOfStock = true;
                }
            }
            catch (Exception ex)
            {
                IsOutOfStock = true;
            }
            return IsOutOfStock;
        }

        public async Task<List<Advertiesment>> GetAdvertiesments()
        {
            var ads = await _db.Advertiesments.AsNoTracking().ToListAsync();
            return ads;
        }

        public async Task<List<select_Slider_PopularProduct>> GetPopularProducts(int? StartIndex = null, int? EndIndex = null, bool? IsShowOutofStock = true)
        {
            List<PopularProductDTO> _objPopularProducts = new List<PopularProductDTO>();
            //var plist = _objPopularProducts.ToList();
            var productlist = await _db.select_Slider_PopularProduct.FromSqlRaw($"usp_select_Slider_PopularProduct {StartIndex}, {EndIndex}").ToListAsync();
            if (productlist != null)
            {
                
                foreach (var productitem in productlist)
                {
                    Product objPopularProduct = GetProductById(productitem.ProductID);

                    if (objPopularProduct == null)
                    {
                        continue;
                    }

                    string Rating = string.Empty;
                    string ProductName = string.Empty;
                    string ImagePath = string.Empty;
                    string ProductPriceID = string.Empty;
                    int AvailableStockQty = 0;
                    ProductVariation objProductVarient = objPopularProduct.ProductVariations.Where(x => x.IsDefaultProductVariation == true).FirstOrDefault();
                    if (objProductVarient != null)
                    {
                        if (objProductVarient.Rating != null)
                        {
                            Rating = Math.Round((decimal)objProductVarient.Rating).ToString();
                        }
                        else
                        {
                            Rating = "0";
                        }

                        ProductName = (objProductVarient.Caption != null) ? objProductVarient.Caption.ToString() : objProductVarient.Product.ProductName.ToString();
                        if (objProductVarient.ProductVariationImages.Count > 0)
                        {
                            ProductVariationImage objProductVarientImage = objProductVarient.ProductVariationImages.Where(x => x.ImageOrderNo == 0).FirstOrDefault();
                            if (objProductVarientImage != null)
                            {
                                int Position = objProductVarientImage.Image.ImagePath.IndexOf(objProductVarientImage.Image.Id.ToString());
                                string ImageName = objProductVarientImage.Image.ImagePath.Substring(Position);
                                string DirectoryName = objProductVarientImage.Image.ImagePath.Replace(ImageName, "").Replace("~/", "");
                                //DirectoryName += "Medium/";
                                ImageName = DirectoryName + ImageName;
                                //if (!File.Exists(HttpContext.Current.Server.MapPath(Subdomain + ImageName)))
                                //{
                                //    ImagePath = Subdomain + ImageName;
                                //}
                                //else
                                //{
                                //    ImagePath = "/img/NoImage.jpg";
                                //}
                            }
                            else
                            {
                                ImagePath = "/img/NoImage.jpg";
                            }
                        }
                        else
                        {
                            ImagePath = "/img/NoImage.jpg";
                        }

                        if (objProductVarient.ProductVariationPrices.Count() > 0)
                        {
                            ProductVariationPrice objProductVarientPrice = objProductVarient.ProductVariationPrices.Where(x => x.IsDefaultPrice == true).FirstOrDefault();
                            if (objProductVarientPrice != null)
                            {
                                ProductPriceID = objProductVarientPrice.PriceId.ToString();
                            }
                            else
                            {
                                ProductPriceID = "";
                            }
                        }
                        else
                        {
                            ProductPriceID = "";
                        }

                    }
                    //bool IsAddToCartVisiable = true;
                    //SystemFlag objsysflag = null;
                    //bool IsOutofStock = true;
                    //objsysflag = _db.SystemFlags.Where(x => x.SystemFlagName.Equals("SysShowAddToCartButton")).FirstOrDefault();
                    //if (objsysflag != null)
                    //{
                    //    if (!string.IsNullOrEmpty(objsysflag.Value))
                    //    {
                    //        IsAddToCartVisiable = Convert.ToBoolean(objsysflag.Value);
                    //    }
                    //}

                    //if (IsAddToCartVisiable)
                    //{
                    //    //IsOutofStock = IsProductOutofStock(objProductVarient.Product, 1, out AvailableStockQty);
                    //    if (IsOutofStock == true && IsAllowedOutofStockInCart == false)
                    //    {
                    //        IsAddToCartVisiable = false;
                    //    }
                    //}

                    //bool IsAddToWishListVisiable = true;
                    //objsysflag = _db.SystemFlags.Where(x => x.SystemFlagName.Equals("SysShowAddToWishListButton")).FirstOrDefault();
                    //if (objsysflag != null)
                    //{
                    //    if (!string.IsNullOrEmpty(objsysflag.Value))
                    //    {
                    //        IsAddToWishListVisiable = Convert.ToBoolean(objsysflag.Value);
                    //    }
                    //}

                    //bool IsAddToCompareVisiable = true;
                    //objsysflag = _db.SystemFlags.Where(x => x.SystemFlagName.Equals("SysShowAddToCompareButton")).FirstOrDefault();
                    //if (objsysflag != null)
                    //{
                    //    if (!string.IsNullOrEmpty(objsysflag.Value))
                    //    {
                    //        IsAddToCompareVisiable = Convert.ToBoolean(objsysflag.Value);
                    //    }
                    //}

                    //bool IsPriceVisiable = true;
                    //objsysflag = _db.SystemFlags.Where(x => x.SystemFlagName.Equals("SysShowPrice")).FirstOrDefault();
                    //if (objsysflag != null)
                    //{
                    //    if (!string.IsNullOrEmpty(objsysflag.Value))
                    //    {
                    //        IsPriceVisiable = Convert.ToBoolean(objsysflag.Value);
                    //    }
                    //}

                    //IsOutofStock = IsProductOutofStock(objProductVarient.Product, 1, out AvailableStockQty);

                    //_objPopularProducts.Add(new PopularProductDTO()
                    //{
                    //    ProductID = productitem.ProductID.ToString(),
                    //    ProductVariationID = objProductVarient.Id.ToString(),
                    //    ProductName = ProductName,
                    //    ProdcutDesc = objProductVarient.Product.Description,
                    //    Rating = Rating,
                    //    Price = productitem.Price,
                    //    ProductCode = objProductVarient.Product.ProductCode,
                    //    ImagePath = ImagePath,
                    //    ProductPriceID = ProductPriceID,
                    //    IsAddToCartVisiable = IsAddToCartVisiable,
                    //    IsAddToWishListVisiable = IsAddToWishListVisiable,
                    //    IsAddToCompareVisiable = IsAddToCompareVisiable,
                    //    IsPriceVisiable = IsPriceVisiable,
                    //    IsOutofStock = IsOutofStock
                    //});
                    
                }
                return productlist;
            }
            else
            {
                return null;
            }
        }









        //public async Task<ProductDetailDTO> GetProduct(Guid? ProductVariationID)
        //{
        //    try
        //    {
        //        string ProductDiscountID = "", PriceID = "", ProductVariantPriceID = "", variantimagepath = "";
        //        string ProductVariationImageID = "", ImageID = "", ProductStockStatus = "", productdefaultdesc = "";
        //        string ProductPrice = "", UnitCode = "", Quantity = "";
        //        bool IsImageZoom = true, IsOutofStock = false, IsPriceVisiable = true;


        //        if (ProductVariationID != null)
        //        {
        //            ProductDetailDTO _objProduct = new ProductDetailDTO();
        //            _objProduct.ProductImages = new List<ProductImageDTO>();
        //            _objProduct.ProductSpecification = new List<ProductSpecificationDTO>();
        //            _objProduct.OtherPack = new List<ProductOtherPackDTO>();


        //            ProductVariation _objProductVariant = await _pc.GetProductVarientsByProductVarientID(ProductVariationID);

        //            if (_objProductVariant != null && _objProductVariant.Product.Brand.IsActive == true && _objProductVariant.Product.Brand.IsDelete == false && _objProductVariant.Product.Category.IsActive == true && _objProductVariant.Product.Category.IsDelete == false)
        //            {
        //                ProductDiscount objProductDiscount = _objProductVariant.Product.ProductDiscounts.Where(x => x.ProductId.Equals(_objProductVariant.ProductId)).FirstOrDefault();
        //                if (objProductDiscount != null)
        //                {
        //                    ProductDiscountID = _ac.Encrypt(objProductDiscount.Id.ToString());
        //                }

        //                #region Product General Settings

        //                SystemFlag objsysflag = null;
        //                objsysflag = await _db.SystemFlags.Where(x => x.SystemFlagName.Equals("SysIsEnableImageZoomOption")).AsNoTracking().FirstOrDefaultAsync();
        //                if (objsysflag != null)
        //                {
        //                    if (!string.IsNullOrEmpty(objsysflag.Value))
        //                    {
        //                        IsImageZoom = Convert.ToBoolean(objsysflag.Value);
        //                    }
        //                }

        //                objsysflag = await _db.SystemFlags.Where(x => x.SystemFlagName.Equals("SysShowPrice")).AsNoTracking().FirstOrDefaultAsync();
        //                if (objsysflag != null)
        //                {
        //                    if (!string.IsNullOrEmpty(objsysflag.Value))
        //                    {
        //                        IsPriceVisiable = Convert.ToBoolean(objsysflag.Value);
        //                    }
        //                }

        //                bool IsShowAddtoCart = false;
        //                bool IsShowBuy = false;

        //                objsysflag = await _db.SystemFlags.Where(x => x.SystemFlagName.Equals("SysShowAddToCartButton")).AsNoTracking().FirstOrDefaultAsync();
        //                if (objsysflag != null)
        //                {
        //                    if (!string.IsNullOrEmpty(objsysflag.Value))
        //                    {
        //                        IsShowAddtoCart = Convert.ToBoolean(objsysflag.Value);
        //                    }
        //                }

        //                objsysflag = await _db.SystemFlags.Where(x => x.SystemFlagName.Equals("SysShowBuyButton")).AsNoTracking().FirstOrDefaultAsync();
        //                if (objsysflag != null)
        //                {
        //                    if (!string.IsNullOrEmpty(objsysflag.Value))
        //                    {
        //                        IsShowBuy = Convert.ToBoolean(objsysflag.Value);
        //                    }
        //                }
        //                #endregion


        //                decimal? VariantPrice = null;
        //                ProductVariationPrice objVarientPrice = _objProductVariant.ProductVariationPrices.Where(x => x.IsDefaultPrice == true).FirstOrDefault();
        //                if (objVarientPrice != null)
        //                {
        //                    VariantPrice = objVarientPrice.Price.Price1;
        //                    PriceID = objVarientPrice.Price.Id.ToString();
        //                    ProductVariantPriceID = objVarientPrice.Id.ToString();
        //                }

        //                if (IsPriceVisiable)
        //                {
        //                    ProductPrice = _pc.CalculateDiscountOnProduct(_objProductVariant.Product, true, VariantPrice);
        //                    ProductVariationPrice objProductVariationPrice = _objProductVariant.ProductVariationPrices.Where(x => x.IsDefaultPrice == true).FirstOrDefault();
        //                    if (objProductVariationPrice != null)
        //                    {
        //                        if (objProductVariationPrice.Price != null)
        //                        {
        //                            UnitCode = "[ " + objProductVariationPrice.Price.Quantity + " " + _objProductVariant.Product.Unit.UnitCode + " ]";
        //                        }
        //                    }
        //                }

        //                if (_objProductVariant.ProductVariationImages.Count > 0)
        //                {
        //                    ProductVariationImage objVarientImage = _objProductVariant.ProductVariationImages.Where(x => x.ImageOrderNo == 0).FirstOrDefault();
        //                    if (objVarientImage != null)
        //                    {
        //                        //variantimagepath = objVarientImage.Image.ImagePath.Replace("~", "");
        //                        variantimagepath = objVarientImage.Image.ImagePath;
        //                        ProductVariationImageID = objVarientImage.Id.ToString();
        //                        ImageID = objVarientImage.Image.Id.ToString();
        //                    }
        //                }

        //                int AvailableStockQty = 0;
        //                IsOutofStock = _pc.IsProductOutofStock(_objProductVariant.Product, 1, out AvailableStockQty);
        //                if (!IsOutofStock)
        //                {
        //                    ProductStockStatus = "In Stock";
        //                }
        //                else
        //                {
        //                    ProductStockStatus = "Out of Stock";
        //                }

        //                if (IsShowAddtoCart == true || IsShowBuy == true)
        //                {

        //                }


        //                #region Get Product Images
        //                //List<ProductImageDTO> _objProductImages = _pc.GetProductImagesForClient(ProductVariationID);
        //                //if (_objProductImages != null)
        //                //{
        //                //    foreach (ProductImageDTO item in _objProductImages)
        //                //    {
        //                //        if (File.Exists(HttpContext.Current.Server.MapPath("~/" + item.LargeImagePath)))
        //                //        {
        //                //            Image img = Image.FromFile(HttpContext.Current.Server.MapPath("~/" + item.LargeImagePath));
        //                //            if (img.Width > 500 && img.Height > 500)
        //                //            {
        //                //                item.IsImageZoom = true;
        //                //            }
        //                //            else
        //                //            {
        //                //                item.IsImageZoom = false;
        //                //            }
        //                //        }
        //                //        else
        //                //        {
        //                //            item.IsImageZoom = false;
        //                //        }
        //                //    }
        //                //    if (_objProductImages.Count() > 0)
        //                //    {
        //                //        _objProduct.ProductImages.AddRange(_objProductImages);
        //                //    }
        //                //}
        //                #endregion

        //                #region  Product Description
        //                if (!string.IsNullOrEmpty(_objProductVariant.Product.Description))
        //                {
        //                    productdefaultdesc = _objProductVariant.Product.Description.ToString();
        //                }
        //                #endregion

        //                #region Product Specification

        //                List<ProductSpecificationDTO> _objProductSpecification = _pc.GetAllProductSpecificationByProductID(_objProductVariant.Product.Id);
        //                if (_objProductSpecification != null)
        //                {
        //                    if (_objProductSpecification.Count() > 0)
        //                    {
        //                        _objProduct.ProductSpecification.AddRange(_objProductSpecification);
        //                    }
        //                }
        //                #endregion

        //                #region Product Other Pack

        //                List<ProductVariationPrice> objProductVarienPrice = _pc.GetProductVarientPriceByProductVarientID(ProductVariationID, "1");
        //                if (objProductVarienPrice != null)
        //                {
        //                    if (objProductVarienPrice.Count() > 0)
        //                    {
        //                        List<ProductOtherPackDTO> objOtherPack = new List<ProductOtherPackDTO>();
        //                        string UnitName = "", Price = "";
        //                        foreach (ProductVariationPrice PP in objProductVarienPrice)
        //                        {
        //                            if (PP.Price.Caption != null)
        //                                UnitName = PP.Price.Caption.ToString();
        //                            else
        //                                UnitName = PP.Price.Quantity + " " + PP.Price.Unit.UnitName.ToString().Trim() + " Pack";

        //                            List<object> PriceList = _bc.ConvertPriceAccordingToCurrency(PP.Price.Price1);
        //                            if (PriceList != null)
        //                            {
        //                                Price = "<span class='currency-icon'><i class='" + PriceList[0] + "'></i></span><span>" + PriceList[1] + "</span>";
        //                            }
        //                            objOtherPack.Add(new ProductOtherPackDTO()
        //                            {
        //                                ProductVariantPriceID = _ac.Encrypt(PP.Id.ToString()),
        //                                ProductID = _ac.Encrypt(PP.ProductVariation.ProductId.ToString()),
        //                                ProductVariantID = _ac.Encrypt(PP.ProductVariation.Id.ToString()),
        //                                PriceID = _ac.Encrypt(PP.PriceId.ToString()),
        //                                UnitID = PP.Price.UnitId,
        //                                UnitCode = PP.Price.Unit.UnitCode.ToString().Trim(),
        //                                UnitName = UnitName,
        //                                Quantity = PP.Price.Quantity,
        //                                Price = Price,
        //                                IsBasePrice = Convert.ToBoolean(PP.IsBasePrice),
        //                                IsDefaultPrice = Convert.ToBoolean(PP.IsDefaultPrice),
        //                                LinkUrl = PP.ProductVariation.Product.LinkUrl,
        //                                ProductPriceID = _ac.Encrypt(PP.PriceId.ToString()),
        //                                IsOutofStock = IsOutofStock,
        //                                IsShowAddToCart = IsShowAddtoCart,
        //                                IsShowBuy = IsShowBuy
        //                            });
        //                            _objProduct.OtherPack.AddRange(objOtherPack);
        //                        }
        //                    }
        //                }

        //                #endregion

        //                _objProduct.ProductID = _objProductVariant.Product.Id;
        //                _objProduct.ProductVariationID = _objProductVariant.Id;
        //                _objProduct.ProductVariationImageID = ProductVariationImageID;
        //                _objProduct.ImageID = ImageID;
        //                _objProduct.ProductVariantPriceID = ProductVariantPriceID;
        //                _objProduct.PriceID = PriceID;
        //                _objProduct.ProductName = _objProductVariant.Product.ProductName;
        //                _objProduct.BrandName = _objProductVariant.Product.Brand.BrandName;
        //                _objProduct.BrandUrl = "/Products/B" + _ac.Encrypt(_objProductVariant.Product.Brand.Id.ToString());
        //                _objProduct.Caption = _objProductVariant.Caption;
        //                _objProduct.ProductCode = _objProductVariant.Product.ProductCode;
        //                _objProduct.Price = ProductPrice;
        //                _objProduct.UnitCode = UnitCode;
        //                _objProduct.ImagePath = variantimagepath;
        //                _objProduct.Rating = _objProductVariant.Rating;
        //                _objProduct.StockStatus = ProductStockStatus;
        //                _objProduct.Description = productdefaultdesc;
        //                _objProduct.Quantity = Quantity;
        //                _objProduct.IsShowAddtoCart = IsShowAddtoCart;
        //                _objProduct.IsShowBuy = IsShowBuy;



        //                return _objProduct;
        //            }
        //            else
        //            {
        //                return null;
        //            }
        //        }
        //        else
        //        {
        //            return null;
        //        }

        //    }
        //    catch (Exception ex)
        //    {
        //        return null;
        //    }
        //}
    }
}
