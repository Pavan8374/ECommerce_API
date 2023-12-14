using NatShopB2C.Domain.AccountModels;
using NatShopB2C.Domain.Models;
using NatShopB2C.Domain.StoredProcedureModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NatShopB2C.Domain.IServices
{
    public interface IProductService
    {
        Task<Product> AddProduct(Product product);
        Task<Product> UpdateProduct(Product product);
        Task<Product> DeleteProduct(Product product);
        Task<List<Product>> GetProducts();
        //Task<List<ProductImagePathDTO>> GetProducts();
        Task <Product> GetProduct(Guid? id);
        Task<ProductVariation> AddProductVarient(ProductVariation varient);
        //Task<List<Product>> LoadProductData(int? Start, int? End, string ProductID, string BrandID, string CategoryID, string UsageTypeID, string Keyword, string SpecificationValueList, string DiscountIDList, decimal? MinPrice, decimal? MaxPrice, string OrderColumn, bool IsAscending);
        Task<List<ProductByAllFilterOptions>> GetProductsByFilterOptions(int? Start, int? End, string? ProductID, string? BrandID, string? CategoryID, string? UsageTypeID, string? Keyword, string? SpecificationValueList, string? DiscountIDList, decimal? MinPrice, decimal? MaxPrice, string? OrderColumn, bool? IsAscending);
        Task<List<ProductByAllFilterOptionsDTO>> GetProductByFilterOption(string ID);
    }
}
