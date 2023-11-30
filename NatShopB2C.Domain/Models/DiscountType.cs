using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NatShopB2C.Domain.Models
{
    public partial class DiscountType
    {
        public DiscountType()
        {
            ProductDiscounts = new HashSet<ProductDiscount>();
        }

        public byte Id { get; set; }
        public string DiscountTypeName { get; set; } = null!;
        public string? Description { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsDelete { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }

        public virtual ICollection<ProductDiscount> ProductDiscounts { get; set; }
    }
}
