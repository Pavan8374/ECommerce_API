using NatShopB2C.Domain.IRepositories;
using NatShopB2C.Domain.IServices;
using NatShopB2C.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace NatShopB2C.Domain.Services
{
    public class AddressBookService : IAddressBookService
    {
        public readonly IAddressBookRepository _addressBookRepository;
        public AddressBookService(IAddressBookRepository addressBookRepository)
        {
            _addressBookRepository = addressBookRepository;
        }

        public async Task<Address> AddAddress(Address address)
        {
            await _addressBookRepository.AddAddress(address);
            return address;
        }
        public async Task<Address> UpdateAddress(Address address)
        {
            await _addressBookRepository.UpdateAddress(address);
            return address;
        }
        public async Task<Address> DeleteAddress(Address address)
        {
            await _addressBookRepository.DeleteAddress(address);
            return address;
        }
        public async Task<List<Address>> GetAddresses()
        {
            var addressList = await _addressBookRepository.GetAddresses();
            return addressList;
        }
        public async Task<Address> GetAddress(int? Id)
        {
            var address = await _addressBookRepository.GetAddress(Id);
            return address;
        }
        public async Task<List<AddressType>> GetAddressTypes()
        {
            var addressType = await _addressBookRepository.GetAddressTypes();
            return addressType;
        }
        public async Task<UserAddress> AddUserAddress(UserAddress address)
        {
            await _addressBookRepository.AddUserAddress(address);
            return address;
        }
        public async Task<UserAddress> UpdateUserAddress(UserAddress address)
        {
            await _addressBookRepository.UpdateUserAddress(address);
            return address;
        }
        public async Task<UserAddress> DeleteUserAddress(UserAddress address)
        {
            await _addressBookRepository.DeleteUserAddress(address);
            return address;
        }
        public async Task<UserAddress> GetUserAddress(int? Id)
        {
            return await _addressBookRepository.GetUserAddress(Id);
        }
    }
}
