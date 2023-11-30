using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NatShopB2C.Domain.Models
{
    public partial class ProductReview
    {
        public ProductReview()
        {
            HelpfulProductReviews = new HashSet<HelpfulProductReview>();
        }

        public Guid Id { get; set; }
        public Guid? ProductId { get; set; }
        public Guid? ProductVariationId { get; set; }
        public Guid? UserId { get; set; }
        public string? UserName { get; set; }
        public string? Email { get; set; }
        public byte? Rating { get; set; }
        public string? ReviewTitle { get; set; }
        public string? ReviewDescription { get; set; }
        public bool? IsVarified { get; set; }
        public bool? IsEvaluate { get; set; }
        public int? IsHelpfulCount { get; set; }
        public int? IsNotHelpfulCount { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsDelete { get; set; }
        public DateTime? CreatedDate { get; set; }
        public Guid? VarifiedBy { get; set; }

        public virtual Product? Product { get; set; }
        public virtual ProductVariation? ProductVariation { get; set; }
        public virtual UserDetail? User { get; set; }
        public virtual UserDetail? VarifiedByNavigation { get; set; }
        public virtual ICollection<HelpfulProductReview> HelpfulProductReviews { get; set; }
    }
}
