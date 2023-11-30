using NatShopB2C.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NatShopB2C.Domain.IRepositories
{
    public interface IAddressBookRepository
    {
        Task<Address> AddAddress(Address address);
        Task<Address> UpdateAddress(Address address);
        Task<Address> DeleteAddress(Address address);
        Task<List<Address>> GetAddresses();
        Task<Address> GetAddress(int? Id);
        Task<List<AddressType>> GetAddressTypes();
        Task<UserAddress> AddUserAddress(UserAddress address);
        Task<UserAddress> UpdateUserAddress(UserAddress address);
        Task<UserAddress> DeleteUserAddress(UserAddress address);
        Task<UserAddress>GetUserAddress(int? Id);

    }
}
