using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NatShopB2C.Domain.Models
{
    public partial class DesignProduct
    {
        public DesignProduct()
        {
            DesignProductImages = new HashSet<DesignProductImage>();
            DesignProductOrders = new HashSet<DesignProductOrder>();
        }

        public long Id { get; set; }
        public string? DesignProductName { get; set; }
        public Guid? ProductVariationId { get; set; }
        public Guid? CreatedBy { get; set; }
        public bool? IsPublished { get; set; }
        public bool? IsCommitionApplicable { get; set; }
        public decimal? CommissionPercent { get; set; }
        public decimal? CommitionFlat { get; set; }
        public string? PublishImagePath { get; set; }
        public Guid? PublishProductVariationId { get; set; }
        public decimal? TotalWorkArea { get; set; }
        public decimal? DesignRate { get; set; }
        public string? Size { get; set; }
        public decimal? Price { get; set; }
        public decimal? Amount { get; set; }
        public string? Description { get; set; }
        public bool? IsApproved { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsDelete { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }

        public virtual ICollection<DesignProductImage> DesignProductImages { get; set; }
        public virtual ICollection<DesignProductOrder> DesignProductOrders { get; set; }
    }
}
