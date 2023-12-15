using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NatShopB2C.Domain.StoredProcedureModels
{
    public class search_CategoryDetailsTree
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
    }
}
