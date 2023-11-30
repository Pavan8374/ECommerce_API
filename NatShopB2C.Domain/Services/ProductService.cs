using NatShopB2C.Domain.IRepositories;
using NatShopB2C.Domain.IServices;
using NatShopB2C.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NatShopB2C.Domain.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _repository;
        public ProductService(IProductRepository repository)
        {
            _repository = repository;
        }

        public async Task<Product> AddProduct(Product product)
        {
            var obj = await _repository.AddProduct(product);
            return obj;
        }
        public async Task<Product> UpdateProduct(Product product)
        {
            var obj = await _repository.UpdateProduct(product);
            return obj;
        }
        public async Task<Product> DeleteProduct(Product product)
        {
            var obj = await _repository.DeleteProduct(product);
            return obj;
        }
        public async Task<List<Product>> GetProducts()
        {
            var products = await _repository.GetProducts();
            return products;
        }
        public async Task<Product> GetProduct(Guid? id)
        {
            var product = await _repository.GetProduct(id);
            return product;
        }
    }
}
