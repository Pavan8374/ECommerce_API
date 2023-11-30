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
    public class BrandRepository : IBrandRepository
    {
        private readonly ApplicationDbContext _db;
        public BrandRepository(ApplicationDbContext db)
        {
            _db = db;
        }
        public async Task<Brand> AddBrand(Brand brand)
        {
            await _db.Brands.AddAsync(brand);
            await _db.SaveChangesAsync();
            return brand;
        }
        public async Task<Brand> UpdateBrand(Brand brand)
        {
             _db.Brands.Update(brand);
             await _db.SaveChangesAsync();
            return brand;
        }
        public async Task<Brand> DeleteBrand(Brand brand)
        {
            _db.Brands.Remove(brand); 
            await _db.SaveChangesAsync(); 
            return brand;
        }
        public async Task<List<Brand>> GetBrands()
        {
            var brands = await _db.Brands.AsNoTracking().ToListAsync();
            return brands;
        }
        public async Task<Brand> GetBrand(int id)
        {
            var brand = await _db.Brands.AsNoTracking().Where(x => x.Id == id).FirstOrDefaultAsync();
            if(brand == null)
            {
                Console.WriteLine("Data not Found");
            }
            return brand;
            
        }
    }
}
