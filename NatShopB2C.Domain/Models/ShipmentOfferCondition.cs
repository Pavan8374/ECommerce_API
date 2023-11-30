using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NatShopB2C.Domain.Models
{
    public partial class ShipmentOfferCondition
    {
        public Guid Id { get; set; }
        public Guid ShipmentOfferId { get; set; }
        public string? Caption { get; set; }
        public decimal? MinOrderPrice { get; set; }
        public decimal? MaxOrderPrice { get; set; }
        public short? UnitId { get; set; }
        public decimal? MinOrderWeight { get; set; }
        public decimal? MaxOrderWeight { get; set; }
        public decimal? FixShipmentAmount { get; set; }
        public decimal? ShipmentDiscountPercent { get; set; }
        public decimal? FixShipmentDiscountAmount { get; set; }
        public string? Description { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsDelete { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }

        public virtual ShipmentOffer ShipmentOffer { get; set; } = null!;
        public virtual Unit? Unit { get; set; }
    }
}
