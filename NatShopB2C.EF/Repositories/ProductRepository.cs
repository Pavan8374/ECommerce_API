using Microsoft.EntityFrameworkCore;
using NatShopB2C.Domain.IRepositories;
using NatShopB2C.Domain.Models;
using NatShopB2C.EF.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NatShopB2C.EF.Repositories
{
    public class ProductRepository : IProductRepository
    {
        public readonly ApplicationDbContext _db;
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
            var products = await _db.Products.AsNoTracking().ToListAsync();
            return products;
        }
        public async Task<Product> GetProduct(Guid? id)
        {
            var product = await _db.Products.AsNoTracking().Where(x => x.Id == id).FirstOrDefaultAsync();
            return product;
        }
    }
}
