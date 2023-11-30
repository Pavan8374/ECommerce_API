using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NatShopB2C.Domain.Models
{
    public partial class ProductStock
    {
        public Guid Id { get; set; }
        public Guid? ProductVariationId { get; set; }
        public int? Quantity { get; set; }
        public short? UnitId { get; set; }
        public int? LocationId { get; set; }
        public short? TransactionTypeId { get; set; }
        public Guid? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }

        public virtual ProductVariation? ProductVariation { get; set; }
        public virtual TransactionType? TransactionType { get; set; }
        public virtual Unit? Unit { get; set; }
    }
}
