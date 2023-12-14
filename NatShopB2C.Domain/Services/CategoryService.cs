using NatShopB2C.Domain.IRepositories;
using NatShopB2C.Domain.IServices;
using NatShopB2C.Domain.Models;
using NatShopB2C.Domain.StoredProcedureModels;
using NatShopB2C.EF.Common.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NatShopB2C.Domain.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _categoryRepository;
        public CategoryService(ICategoryRepository categoryRepository)
        {
            _categoryRepository= categoryRepository;
        }

        public async Task<List<select_CategoryDetailsByFilter>> GetCategories(int? StartIndex, int? EndIndex, bool? IsActive, bool? IsArchieve)
        {
            return await _categoryRepository.GetCategories(StartIndex, EndIndex, IsActive, IsArchieve);
        }

        public async Task<List<CategoryHierarchyDTO>> GetcategoryHierarchy()
        {
            return await _categoryRepository.GetcategoryHierarchy();
        }
    }
}
