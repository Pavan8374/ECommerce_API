using NatShopB2C.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NatShopB2C.Domain.IRepositories
{
    public interface IProductRepository
    {        
        Task<Product> AddProduct(Product product);
        Task<Product> UpdateProduct(Product product);
        Task<Product> DeleteProduct(Product product);
        Task<List<Product>> GetProducts();
        Task<Product> GetProduct(Guid? id);
        Task<ProductVariation> AddProductVarient(ProductVariation varient);
    }
}
