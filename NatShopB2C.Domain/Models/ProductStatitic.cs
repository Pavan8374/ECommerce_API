using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NatShopB2C.Domain.Models
{
    public partial class ProductStatitic
    {
        public Guid Id { get; set; }
        public int? ViewerCount { get; set; }
        public int? LikeCount { get; set; }
        public int? PaidPramotion { get; set; }
        public string? Description { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsDelete { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }

        public virtual ProductVariation IdNavigation { get; set; } = null!;
    }
}
