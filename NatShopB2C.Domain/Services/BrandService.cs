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
    public class BrandService : IBrandService
    {
        private readonly IBrandRepository _brandRepsitory;
        public BrandService(IBrandRepository brandRepsitory)
        {
            _brandRepsitory= brandRepsitory;
        }
        public async Task<Brand> AddBrand(Brand brand)
        {
            await _brandRepsitory.AddBrand(brand);
            return brand;
        }
        public async Task<Brand> UpdateBrand(Brand brand)
        {
            await _brandRepsitory.UpdateBrand(brand);
            return brand;
        }
        public async Task<Brand> DeleteBrand(Brand brand)
        {
            await _brandRepsitory.DeleteBrand(brand);
            return brand;
        }
        public async Task<List<Brand>> GetBrands()
        {
            var brands = await _brandRepsitory.GetBrands();
            return brands;
        }
        public async Task<Brand> GetBrand(int id)
        {
            var brand = await _brandRepsitory.GetBrand(id);
            return brand;
        }
    }
}
