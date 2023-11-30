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
    public class AddressBookRepository : IAddressBookRepository
    {
        private readonly ApplicationDbContext _db;
        public AddressBookRepository(ApplicationDbContext db)
        {
            _db = db;
        }

        public async Task<Address> AddAddress(Address address)
        {
            await _db.Addresses.AddAsync(address);
            await _db.SaveChangesAsync();
            return address;
        }
        public async Task<Address> UpdateAddress(Address address)
        {
            _db.Addresses.Update(address);
            await _db.SaveChangesAsync();
            return address;
        }
        public async Task<Address> DeleteAddress(Address address)
        {
            _db.Addresses.Remove(address);
            await _db.SaveChangesAsync();
            return address;
        }
        public async Task<List<Address>> GetAddresses()
        {
            var addressList = await _db.Addresses
                .AsNoTracking()
                .Include(x => x.City)
                .Include(x => x.State)
                .Include(x => x.Country)
                .Include(x => x.UserAddresses)
                .ToListAsync();

            return addressList;
        }
        public async Task<Address> GetAddress(int? Id)
        {
            var address = await _db.Addresses.AsNoTracking().Include(x => x.UserAddresses).Where(x => x.Id == Id).FirstOrDefaultAsync();
            if (address == null)
            {
                Console.WriteLine("Address not Found");
            }
            return address;
        }
        public async Task<List<AddressType>> GetAddressTypes()
        {
            var addressTypes = await _db.AddressTypes.AsNoTracking().ToListAsync();
            return addressTypes;
        }
        public async Task<UserAddress> AddUserAddress(UserAddress address)
        {
            await _db.UserAddresses.AddAsync(address);
            await _db.SaveChangesAsync();
            return address;
        }
        public async Task<UserAddress> UpdateUserAddress(UserAddress address)
        {
            _db.UserAddresses.Update(address);
            await _db.SaveChangesAsync();
            return address;
        }
        public async Task<UserAddress> DeleteUserAddress(UserAddress address)
        {
            _db.UserAddresses.Remove(address);
            await _db.SaveChangesAsync();
            return address;
        }
        public async Task<UserAddress> GetUserAddress(int? Id)
        {
            var address = await _db.UserAddresses.Where(x => x.AddressId == Id).FirstOrDefaultAsync();
            if (address == null)
            {
                Console.WriteLine("Address not Found");
            }
            return address;
        }
    }
}
