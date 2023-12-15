using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NatShopB2C.Domain.StoredProcedureModels
{
    public class select_SubCategoriesByCategoryID
    {
        public int? ID { get; set; }
        public string? CategoryName { get; set; }
        public int? ParentCategoryID { get; set; }
        public string? Description { get; set; }
        public bool IsActive { get; set; }
        public bool? IsDelete { get; set; }
        public bool? IsLeaf { get; set; }
        public int? Depth { get; set; }
        public string? ImagePath { get; set; }
        public int ProductCount { get; set; }
    }
}
