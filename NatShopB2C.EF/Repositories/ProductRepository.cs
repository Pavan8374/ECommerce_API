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

namespace NatShopB2C.EF.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly ApplicationDbContext _db;
        
        public ProductRepository(ApplicationDbContext db)
        {
            _db = db;
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

        public async Task<List<usp_select_SubCategoriesByCategoryID>> GetSubCategoriesByCategoryID(int categoryID)
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
