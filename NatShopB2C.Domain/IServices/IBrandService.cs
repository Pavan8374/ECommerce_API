using NatShopB2C.Domain.IRepositories;
using NatShopB2C.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NatShopB2C.Domain.IServices
{
    public interface IBrandService
    {
        Task<Brand> AddBrand(Brand brand);
        Task<Brand> UpdateBrand(Brand brand);
        Task<Brand> DeleteBrand(Brand brand);
        Task<List<Brand>> GetBrands();
        Task<Brand> GetBrand(int id);
        
    }
}
