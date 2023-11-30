using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NatShopB2C.Domain.Models
{
    public partial class Cart
    {
        public long Id { get; set; }
        public Guid? UserId { get; set; }
        public Guid? ProductVariationId { get; set; }
        public double? Quantity { get; set; }
        public short? UnitId { get; set; }
        public Guid? PriceId { get; set; }
        public string? Remark { get; set; }
        public Guid? ProductDiscountId { get; set; }
        public bool? IsWishList { get; set; }
        public bool? IsOrdered { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsDelete { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }

        public virtual Price? Price { get; set; }
        public virtual ProductDiscount? ProductDiscount { get; set; }
        public virtual ProductVariation? ProductVariation { get; set; }
        public virtual Unit? Unit { get; set; }
        public virtual UserDetail? User { get; set; }
    }
}
