using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NatShopB2C.Domain.Models
{
    public partial class DiscountOptioin
    {
        public DiscountOptioin()
        {
            ProductDiscounts = new HashSet<ProductDiscount>();
        }

        public Guid Id { get; set; }
        public int? DiscountId { get; set; }
        public string? Caption { get; set; }
        public int? MinBreakPoint { get; set; }
        public int? MaxBreakPoin { get; set; }
        public byte? DiscountValueTypeId { get; set; }
        public decimal? DiscountValue { get; set; }
        public byte? Priority { get; set; }
        public string? BreakPointCode { get; set; }
        public string? Note { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsDelete { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }

        public virtual Discount? Discount { get; set; }
        public virtual DiscountValueType? DiscountValueType { get; set; }
        public virtual ICollection<ProductDiscount> ProductDiscounts { get; set; }
    }
}
