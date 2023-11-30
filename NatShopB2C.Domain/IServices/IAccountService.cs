using NatShopB2C.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NatShopB2C.Domain.IServices
{
    public interface IAccountService
    {
        Task<User>ConfirmUser(User user);
        Task<UserDetail> AddUserDetails(UserDetail userDetail);
        Task<UserDetail> UpdateUserDetails(UserDetail userDetail);
        Task<UserDetail> DeleteUserDetails(UserDetail userDetail);
        Task<List<UserDetail>> GetUserDetails();
        Task<UserDetail> GetUserDetailsById(Guid? id);
        
    }
}
