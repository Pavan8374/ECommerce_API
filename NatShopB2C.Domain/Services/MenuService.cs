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
    public class MenuService : IMenuService
    {
        private readonly IMenuRepository _menuRepository;
        public MenuService(IMenuRepository menuRepository)
        {
            _menuRepository = menuRepository;
        }
        public async Task<List<Menu>> GetRootMenus()
        {
           return await _menuRepository.GetRootMenus();
        }

        public async Task<List<Menu>> GetSubMenus(int RootID)
        {
            return await _menuRepository.GetSubMenus(RootID);
        }
    }
}
