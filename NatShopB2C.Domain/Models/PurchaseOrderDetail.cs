using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NatShopB2C.Domain.Models
{
    public partial class PurchaseOrderDetail
    {
        public Guid? Id { get; set; }
        public long? PurchaseOrderId { get; set; }
        public byte? SrNo { get; set; }
        public Guid? ProductVariationId { get; set; }
        public Guid? PriceId { get; set; }
        public int? Quantity { get; set; }
        public short? UnitId { get; set; }
        public decimal? Rate { get; set; }
        public decimal? Amount { get; set; }
        public string? Description { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsDelete { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }

        public virtual ProductVariation? ProductVariation { get; set; }
        public virtual PurchaseOrder? PurchaseOrder { get; set; }
        public virtual Unit? Unit { get; set; }
    }
}
