using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NatShopB2C.Domain.Models
{
    public partial class DiscountValueType
    {
        public DiscountValueType()
        {
            DiscountOptioins = new HashSet<DiscountOptioin>();
        }

        public byte Id { get; set; }
        public string DiscountValueTypeName { get; set; } = null!;
        public string? Description { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsDelete { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }

        public virtual ICollection<DiscountOptioin> DiscountOptioins { get; set; }
    }
}
