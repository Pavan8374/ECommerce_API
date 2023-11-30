using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NatShopB2C.Domain.Models
{
    public partial class ProductVariationPrice
    {
        public ProductVariationPrice()
        {
            ProductShipments = new HashSet<ProductShipment>();
        }

        public Guid Id { get; set; }
        public Guid ProductVariationId { get; set; }
        public Guid PriceId { get; set; }
        public string? Barcode { get; set; }
        public bool? IsBasePrice { get; set; }
        public bool? IsDefaultPrice { get; set; }

        public virtual Price Price { get; set; } = null!;
        public virtual ProductVariation ProductVariation { get; set; } = null!;
        public virtual ICollection<ProductShipment> ProductShipments { get; set; }
    }
}
