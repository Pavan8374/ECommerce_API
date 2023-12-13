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
    public class MenuRepository : IMenuRepository
    {
        private readonly ApplicationDbContext _db;
        public MenuRepository(ApplicationDbContext db)
        {
            _db = db;
        }
        public async Task<List<Menu>> GetRootMenus()
        {
            try
            {

                var obj = await _db.Menus.Where(x => x.Level == 0 && x.IsActive == true && x.IsDelete == false).ToListAsync();
                return obj;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public async Task<List<Menu>> GetSubMenus(int RootID)
        {
            try
            {
                var obj = await _db.Menus.Where(x => x.ParentMenuId == RootID && x.IsActive == true && x.IsDelete == false).ToListAsync();
                return obj;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
