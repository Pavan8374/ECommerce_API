using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NatShopB2C.Domain.Models
{
    public partial class Category
    {
        public Category()
        {
            CategoryFilters = new HashSet<CategoryFilter>();
            CategoryImages = new HashSet<CategoryImage>();
            CategorySpecificationGroupsSpecifications = new HashSet<CategorySpecificationGroupsSpecification>();
            CategoryUsageTypes = new HashSet<CategoryUsageType>();
            InverseParentCategory = new HashSet<Category>();
            ProductDiscounts = new HashSet<ProductDiscount>();
            Products = new HashSet<Product>();
            Seocontents = new HashSet<Seocontent>();
            TopicMails = new HashSet<TopicMail>();
            UserSubscriptions = new HashSet<UserSubscription>();
        }

        public int Id { get; set; }
        public string CategoryName { get; set; } = null!;
        public string? Description { get; set; }
        public int? Depth { get; set; }
        public int? ParentCategoryId { get; set; }
        public bool? IsLeaf { get; set; }
        public bool? IsSubscribable { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsDelete { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }

        public virtual Category? ParentCategory { get; set; }
        public virtual ICollection<CategoryFilter> CategoryFilters { get; set; }
        public virtual ICollection<CategoryImage> CategoryImages { get; set; }
        public virtual ICollection<CategorySpecificationGroupsSpecification> CategorySpecificationGroupsSpecifications { get; set; }
        public virtual ICollection<CategoryUsageType> CategoryUsageTypes { get; set; }
        public virtual ICollection<Category> InverseParentCategory { get; set; }
        public virtual ICollection<ProductDiscount> ProductDiscounts { get; set; }
        public virtual ICollection<Product> Products { get; set; }
        public virtual ICollection<Seocontent> Seocontents { get; set; }
        public virtual ICollection<TopicMail> TopicMails { get; set; }
        public virtual ICollection<UserSubscription> UserSubscriptions { get; set; }
    }
}
