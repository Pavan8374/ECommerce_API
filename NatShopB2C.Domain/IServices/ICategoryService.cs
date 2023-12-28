using NatShopB2C.Domain.DTO;
using NatShopB2C.Domain.Models;
using NatShopB2C.Domain.StoredProcedureModels;
using NatShopB2C.EF.Common.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NatShopB2C.Domain.IServices
{
    public interface ICategoryService
    {
        Task<List<select_CategoryDetailsByFilter>> GetCategories(int? StartIndex, int? EndIndex, bool? IsActive, bool? IsArchieve);
        Task<List<CategoryHierarchyDTO>> GetcategoryHierarchy(int? StartIndex, int? EndIndex, bool? IsActive, bool? IsArchieve, string? SearchString);
        Task<List<Category>> GetCategory(string? CategoryName, int? Id);
        //Task<List<CategorySliderDTO>> GetCategoriesSlider();

    }
}
