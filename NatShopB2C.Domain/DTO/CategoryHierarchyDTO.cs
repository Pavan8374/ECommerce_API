using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NatShopB2C.EF.Common.DTO
{
    public class CategoryHierarchyDTO
    {
        public int? CategoryID { get; set; }
        public int? ParentCategoryID { get; set; }
        public string? CategoryName { get; set; }
        public string? Description { get; set; }
        public int? Depth { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsParentActive { get; set; }
        public bool? IsDelete { get; set; }
        public bool? IsParentDelete { get; set; }

        public List<CategoryHierarchyDTO> SubCategory { get; set; }
    }
    public class CategoryDTO
    {
        public int? CategoryID { get; set; }
        public string? CategoryName { get; set; }
    }
}
