using NatShopB2C.Domain.DTO;
using NatShopB2C.Domain.IRepositories;
using NatShopB2C.Domain.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NatShopB2C.Domain.Services
{
    public class GlobalSearchService : IGlobalSearchService
    {
        private readonly IGlobalSearchRepository _globalSearchRepository;
        public GlobalSearchService(IGlobalSearchRepository globalSearchRepository)
        {
            _globalSearchRepository= globalSearchRepository;
        }   
        public async Task<List<GlobalSearchDTO>> GlobalSearch(string SearchKeyword = "")
        {
            return await _globalSearchRepository.GlobalSearch(SearchKeyword);
        }


    }
}
