using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NatShopB2C.Domain.StoredProcedureModels
{
    public class select_CategoryDetailsByFilter
    {
        public long? RowNo { get; set; }
        public int? CategoryID { get; set; }
        public string? CategoryName { get; set; }
        public string? Description { get; set; }
        //public Nullable<int> Depth { get; set; }
        public int? ParentCategoryID { get; set; }
        public bool? IsLeaf { get; set; }
        //public Nullable<bool> IsSubscribable { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsDelete { get; set; }
        public bool? IsParentActive { get; set; }
        public bool? IsParentDelete { get; set; }
        public int? ProductCount { get; set; }
        //public Nullable<System.DateTime> CreatedDate { get; set; }
        //public Nullable<System.DateTime> ModifiedDate { get; set; }
    }
}
