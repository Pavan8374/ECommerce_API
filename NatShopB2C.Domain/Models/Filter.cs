using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NatShopB2C.Domain.Models
{
    public partial class Filter
    {
        public Filter()
        {
            CategoryFilters = new HashSet<CategoryFilter>();
        }

        public int Id { get; set; }
        public string? FilterName { get; set; }
        public string? Caption { get; set; }
        public string? ControlType { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsDelete { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }

        public virtual ICollection<CategoryFilter> CategoryFilters { get; set; }
    }
}
