using AutoMapper;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using NatShopB2C.Domain.DTO;
using NatShopB2C.Domain.IRepositories;
using NatShopB2C.EF.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NatShopB2C.EF.Repositories
{
    public class GlobalSearchRepository : IGlobalSearchRepository
    {
        private readonly ApplicationDbContext _db;
        private readonly IMapper _mapper;
        public GlobalSearchRepository(ApplicationDbContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }
        public async Task<List<GlobalSearchDTO>> GlobalSearch(string SearchKeyword)
        {
            int StartIndex = 1;
            int EndIndex = 10;
            List<GlobalSearchDTO> searchList = new List<GlobalSearchDTO>();

            var objsysflag = _db.SystemFlags.Where(x => x.SystemFlagName.Equals("SysMainSearchStartIndex")).FirstOrDefault();
            if (objsysflag != null)
            {
                if (!string.IsNullOrEmpty(objsysflag.Value))
                {
                    StartIndex = Convert.ToInt32(objsysflag.Value.ToString());
                }
                else if (!string.IsNullOrEmpty(objsysflag.DefaultValue))
                {
                    StartIndex = Convert.ToInt32(objsysflag.DefaultValue.ToString());
                }
            }
            objsysflag = _db.SystemFlags.Where(x => x.SystemFlagName.Equals("SysMainSearchEndIndex")).FirstOrDefault();
            if (objsysflag != null)
            {
                if (!string.IsNullOrEmpty(objsysflag.Value))
                {
                    EndIndex = Convert.ToInt32(objsysflag.Value.ToString());
                }
                else if (!string.IsNullOrEmpty(objsysflag.DefaultValue))
                {
                    EndIndex = Convert.ToInt32(objsysflag.DefaultValue.ToString());
                }
            }


            //string sql = "EXEC usp_search_ProductPopup @StartIndex, @EndIndex, @SearchKeyword";
            //SqlParameter[] parms = new SqlParameter[]
            //{
            //        new SqlParameter("@StartIndex", StartIndex),
            //        new SqlParameter("@EndIndex", EndIndex),
            //        new SqlParameter("@SearchKeyword", SearchKeyword)
            //};

            //var GlobalSearchList = await _db.search_ProductPopup
            //        .FromSqlRaw(sql, parms)
            //        .ToListAsync();
            var GlobalSearchList = await _db.search_ProductPopup.FromSqlRaw($"EXEC usp_search_ProductPopup {StartIndex}, {EndIndex}, {SearchKeyword}").ToListAsync();
            if(GlobalSearchList.Count < 0)
            {
                return null;
            }

            if (GlobalSearchList != null)
            {
                foreach (var item in GlobalSearchList)
                {
                    searchList.Add(_mapper.Map<GlobalSearchDTO>(item));
                }
                return searchList;
            }
            else
            {
                return null;
            }
        }
    }
}
