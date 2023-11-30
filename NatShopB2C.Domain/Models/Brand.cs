using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NatShopB2C.Domain.Models
{
    public partial class Brand
    {
        public Brand()
        {
            BrandImages = new HashSet<BrandImage>();
            ProductDiscounts = new HashSet<ProductDiscount>();
            Products = new HashSet<Product>();
            Seocontents = new HashSet<Seocontent>();
            TopicMails = new HashSet<TopicMail>();
            UserSubscriptions = new HashSet<UserSubscription>();
        }

        public int Id { get; set; }
        public string BrandName { get; set; } = null!;
        public string? Description { get; set; }
        public decimal? Rating { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsDelete { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }

        public virtual ICollection<BrandImage> BrandImages { get; set; }
        public virtual ICollection<ProductDiscount> ProductDiscounts { get; set; }
        public virtual ICollection<Product> Products { get; set; }
        public virtual ICollection<Seocontent> Seocontents { get; set; }
        public virtual ICollection<TopicMail> TopicMails { get; set; }
        public virtual ICollection<UserSubscription> UserSubscriptions { get; set; }
    }
}
