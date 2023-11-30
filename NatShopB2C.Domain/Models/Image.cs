using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NatShopB2C.Domain.Models
{
    public partial class Image
    {
        public Image()
        {
            BrandImages = new HashSet<BrandImage>();
            CategoryImages = new HashSet<CategoryImage>();
            Contents = new HashSet<Content>();
            Discounts = new HashSet<Discount>();
            InquiryMessages = new HashSet<InquiryMessage>();
            MailResources = new HashSet<MailResource>();
            ProductVariationImages = new HashSet<ProductVariationImage>();
        }

        public Guid Id { get; set; }
        public string? ImagePath { get; set; }
        public string? Description { get; set; }
        public string? Alt { get; set; }
        public bool? IsActive { get; set; }
        public bool IsDelete { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }

        public virtual ICollection<BrandImage> BrandImages { get; set; }
        public virtual ICollection<CategoryImage> CategoryImages { get; set; }
        public virtual ICollection<Content> Contents { get; set; }
        public virtual ICollection<Discount> Discounts { get; set; }
        public virtual ICollection<InquiryMessage> InquiryMessages { get; set; }
        public virtual ICollection<MailResource> MailResources { get; set; }
        public virtual ICollection<ProductVariationImage> ProductVariationImages { get; set; }
    }
}
