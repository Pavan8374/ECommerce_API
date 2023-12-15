using NatShopB2C.Domain.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NatShopB2C.Domain.IRepositories
{
    public interface IGlobalSearchRepository
    {
        Task<List<GlobalSearchDTO>> GlobalSearch(string SearchKeyword);
    }
}
