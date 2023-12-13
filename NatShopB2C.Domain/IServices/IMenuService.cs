using NatShopB2C.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NatShopB2C.Domain.IServices
{
    public interface IMenuService
    {
        Task<List<Menu>> GetRootMenus();
        Task<List<Menu>> GetSubMenus(int RootID);
    }
}
