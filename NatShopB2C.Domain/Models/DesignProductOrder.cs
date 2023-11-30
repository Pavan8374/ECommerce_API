using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NatShopB2C.Domain.Models
{
    public partial class DesignProductOrder
    {
        public Guid Id { get; set; }
        public long? DesignProductId { get; set; }
        public Guid? UserId { get; set; }
        public string? SizeCode { get; set; }
        public Guid? TextPropertyId1 { get; set; }
        public Guid? TextPropertyId2 { get; set; }
        public Guid? TextPropertyId3 { get; set; }
        public Guid? TextPropertyId4 { get; set; }
        public short? UnitId { get; set; }
        public decimal? Quantity { get; set; }
        public decimal? Price { get; set; }
        public bool? IsGroupOrder { get; set; }
        public bool? IsDelivered { get; set; }
        public DateTime? TransactionDate { get; set; }
        public string? Description { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsDelete { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }

        public virtual DesignProduct? DesignProduct { get; set; }
        public virtual TextProperty? TextPropertyId1Navigation { get; set; }
        public virtual TextProperty? TextPropertyId2Navigation { get; set; }
        public virtual TextProperty? TextPropertyId3Navigation { get; set; }
        public virtual TextProperty? TextPropertyId4Navigation { get; set; }
    }
}
