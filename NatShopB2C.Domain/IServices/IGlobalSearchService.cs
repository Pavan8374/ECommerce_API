using NatShopB2C.Domain.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NatShopB2C.Domain.IServices
{
    public interface IGlobalSearchService
    {
        Task<List<GlobalSearchDTO>> GlobalSearch(string SearchKeyword = "");
    }
}
