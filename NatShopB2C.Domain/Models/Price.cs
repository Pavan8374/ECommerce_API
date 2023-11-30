using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NatShopB2C.Domain.Models
{
    public partial class Price
    {
        public Price()
        {
            Carts = new HashSet<Cart>();
            ProductVariationPrices = new HashSet<ProductVariationPrice>();
            PurchaseDetails = new HashSet<PurchaseDetail>();
            SalesDetails = new HashSet<SalesDetail>();
        }

        public Guid Id { get; set; }
        public string? Caption { get; set; }
        public short UnitId { get; set; }
        public int Quantity { get; set; }
        public decimal Price1 { get; set; }

        public virtual Unit Unit { get; set; } = null!;
        public virtual ICollection<Cart> Carts { get; set; }
        public virtual ICollection<ProductVariationPrice> ProductVariationPrices { get; set; }
        public virtual ICollection<PurchaseDetail> PurchaseDetails { get; set; }
        public virtual ICollection<SalesDetail> SalesDetails { get; set; }
    }
}
