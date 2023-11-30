using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using NatShopB2C.Domain.AccountModels;
using NatShopB2C.Domain.IRepositories;
using NatShopB2C.Domain.Models;
using NatShopB2C.EF.Data;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace NatShopB2C.EF.Repositories
{
    public class AccountRepository : IAccountRepository
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly IConfiguration _configuration;
        public readonly ApplicationDbContext _db;
        public AccountRepository(
            UserManager<IdentityUser> userManager,
            RoleManager<IdentityRole> roleManager,
            IConfiguration configuration, ApplicationDbContext db)
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _configuration = configuration;
            _db = db;
        }

        public async Task<User> ConfirmUser(User user)
        {
            await _db.Users.AddAsync(user);
            await _db.SaveChangesAsync();
            return user;
        }
        public async Task<UserDetail> AddUserDetails(UserDetail userDetail) 
        {
            await _db.UserDetails.AddAsync(userDetail);
            await _db.SaveChangesAsync();
            return userDetail;
        }
        public async Task<UserDetail> UpdateUserDetails(UserDetail userDetail) 
        {
            _db.UserDetails.Update(userDetail);
            await _db.SaveChangesAsync();
            return userDetail;
        }
        public async Task<UserDetail> DeleteUserDetails(UserDetail userDetail) 
        {
             _db.UserDetails.Remove(userDetail);
            await _db.SaveChangesAsync();
            return userDetail;
        }
        public async Task<List<UserDetail>> GetUserDetails() 
        {
            return await _db.UserDetails.AsNoTracking().ToListAsync(); ;

        }
        public async Task<UserDetail> GetUserDetailsById(Guid? Id) 
        {
            return await _db.UserDetails.AsNoTracking().Where(x => x.UserId == Id).FirstOrDefaultAsync();
        }

    }
}
