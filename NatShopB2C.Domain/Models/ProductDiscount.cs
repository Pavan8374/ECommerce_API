using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NatShopB2C.Domain.Models
{
    public partial class ProductDiscount
    {
        public ProductDiscount()
        {
            Carts = new HashSet<Cart>();
        }

        public Guid Id { get; set; }
        public int? DiscountId { get; set; }
        public int? CategoryId { get; set; }
        public int? BrandId { get; set; }
        public Guid? ProductId { get; set; }
        public Guid? ProductVariationId { get; set; }
        public Guid? UserId { get; set; }
        public byte? DiscountTypeId { get; set; }
        public Guid? DiscountOptionId { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsDelete { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }

        public virtual Brand? Brand { get; set; }
        public virtual Category? Category { get; set; }
        public virtual Discount? Discount { get; set; }
        public virtual DiscountOptioin? DiscountOption { get; set; }
        public virtual DiscountType? DiscountType { get; set; }
        public virtual Product? Product { get; set; }
        public virtual ProductVariation? ProductVariation { get; set; }
        public virtual UserDetail? User { get; set; }
        public virtual ICollection<Cart> Carts { get; set; }
    }
}
