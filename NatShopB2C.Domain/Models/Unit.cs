using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NatShopB2C.Domain.Models
{
    public partial class Unit
    {
        public Unit()
        {
            Carts = new HashSet<Cart>();
            Prices = new HashSet<Price>();
            ProductShipments = new HashSet<ProductShipment>();
            ProductSkus = new HashSet<Product>();
            ProductStocks = new HashSet<ProductStock>();
            ProductUnits = new HashSet<Product>();
            PurchaseDetails = new HashSet<PurchaseDetail>();
            ShipmentOfferConditions = new HashSet<ShipmentOfferCondition>();
        }

        public short Id { get; set; }
        public string? UnitCode { get; set; }
        public string? UnitName { get; set; }
        public string? Description { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsDelete { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }

        public virtual ICollection<Cart> Carts { get; set; }
        public virtual ICollection<Price> Prices { get; set; }
        public virtual ICollection<ProductShipment> ProductShipments { get; set; }
        public virtual ICollection<Product> ProductSkus { get; set; }
        public virtual ICollection<ProductStock> ProductStocks { get; set; }
        public virtual ICollection<Product> ProductUnits { get; set; }
        public virtual ICollection<PurchaseDetail> PurchaseDetails { get; set; }
        public virtual ICollection<ShipmentOfferCondition> ShipmentOfferConditions { get; set; }
    }
}
