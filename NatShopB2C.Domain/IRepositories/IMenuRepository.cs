using NatShopB2C.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NatShopB2C.Domain.IRepositories
{
    public interface IMenuRepository
    {
        Task<List<Menu>> GetRootMenus();   
        Task<List<Menu>> GetSubMenus(int RootID);           
    }
}
