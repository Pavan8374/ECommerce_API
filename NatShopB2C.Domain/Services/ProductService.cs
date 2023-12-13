using NatShopB2C.Domain.AccountModels;
using NatShopB2C.Domain.IRepositories;
using NatShopB2C.Domain.IServices;
using NatShopB2C.Domain.Models;
using NatShopB2C.Domain.StoredProcedureModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NatShopB2C.Domain.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productrepository;
        public ProductService(IProductRepository productrepository)
        {
            _productrepository = productrepository;
        }

        public async Task<Product> AddProduct(Product product)
        {
            var obj = await _productrepository.AddProduct(product);
            return obj;
        }
        public async Task<Product> UpdateProduct(Product product)
        {
            var obj = await _productrepository.UpdateProduct(product);
            return obj;
        }
        public async Task<Product> DeleteProduct(Product product)
        {
            var obj = await _productrepository.DeleteProduct(product);
            return obj;
        }
        public async Task<List<Product>> GetProducts()
        {
            var products = await _productrepository.GetProducts();
            return products;
        }
        //public async Task<List<ProductImagePathDTO>> GetProducts()
        //{
        //    var products = await _productrepository.GetProducts();
        //    return products;
        //}
        public async Task<Product> GetProduct(Guid? id)
        {
            var product = await _productrepository.GetProduct(id);
            return product;
        }
        public async Task<ProductVariation>AddProductVarient(ProductVariation varient)
        {
            await _productrepository.AddProductVarient(varient);
            return varient;
        }
        //public async Task<List<Product>> LoadProductData(int? Start, int? End, string ProductID, string BrandID, string CategoryID, string UsageTypeID, string Keyword, string SpecificationValueList, string DiscountIDList, decimal? MinPrice, decimal? MaxPrice, string OrderColumn, bool IsAscending)
        //{
        //    return await _productrepository.LoadProductData(Start, End, ProductID, BrandID, CategoryID, UsageTypeID, Keyword, SpecificationValueList, DiscountIDList,  MinPrice, MaxPrice, OrderColumn, IsAscending);
        //}
        public async Task<List<ProductByAllFilterOptions>> GetProductsByFilterOptions(int? Start, int? End, string? ProductID, string? BrandID, string? CategoryID, string? UsageTypeID, string? Keyword, string? SpecificationValueList, string? DiscountIDList, decimal? MinPrice, decimal? MaxPrice, string? OrderColumn, bool? IsAscending)
        {
            return await _productrepository.GetProductsByFilterOptions(Start, End, ProductID, BrandID, CategoryID, UsageTypeID, Keyword, SpecificationValueList, DiscountIDList, MinPrice, MaxPrice, OrderColumn, IsAscending);
        }
        public async Task<List<ProductByAllFilterOptionsDTO>> GetProductByFilterOption(string ID)
        {
            return await _productrepository.GetProductByFilterOption(ID);
        }
    }
}
