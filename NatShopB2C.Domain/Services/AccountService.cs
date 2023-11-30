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
    public class AccountService : IAccountService
    {
        public readonly IAccountRepository _accountRepository;
        public AccountService(IAccountRepository accountRepository)
        {
            _accountRepository = accountRepository;
        }
        public async Task<User> ConfirmUser(User user)
        {
            await _accountRepository.ConfirmUser(user);
            return user;
        }
        public async Task<UserDetail> AddUserDetails(UserDetail userDetail)
        {
            await _accountRepository.AddUserDetails(userDetail);
            return userDetail;
        }
        public async Task<UserDetail> UpdateUserDetails(UserDetail userDetail)
        {
            await _accountRepository.UpdateUserDetails(userDetail);
            return userDetail;
        }
        public async Task<UserDetail> DeleteUserDetails(UserDetail userDetail)
        {
            await _accountRepository.DeleteUserDetails(userDetail);
            return userDetail;
        }
        public async Task<List<UserDetail>> GetUserDetails()
        {
            return await _accountRepository.GetUserDetails();
        }
        public async Task<UserDetail> GetUserDetailsById(Guid? Id)
        {
            return await _accountRepository.GetUserDetailsById(Id);
        }
    }
}
