using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NatShopB2C.Domain.Models
{
    public partial class HelpfulProductReview
    {
        public long Id { get; set; }
        public Guid ProductReviewId { get; set; }
        public Guid UserId { get; set; }
        public bool IsHelpful { get; set; }

        public virtual ProductReview ProductReview { get; set; } = null!;
        public virtual UserDetail User { get; set; } = null!;
    }
}
