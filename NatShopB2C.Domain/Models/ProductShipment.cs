using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NatShopB2C.Domain.Models
{
    public partial class ProductShipment
    {
        public Guid Id { get; set; }
        public Guid ProductVariatioinPriceId { get; set; }
        public bool? IsFreeShipment { get; set; }
        public decimal? ShipmentCharges { get; set; }
        public short? UnitId { get; set; }
        public decimal? Weight { get; set; }
        public string? Dimension { get; set; }

        public virtual ProductVariationPrice ProductVariatioinPrice { get; set; } = null!;
        public virtual Unit? Unit { get; set; }
    }
}
