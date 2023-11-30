using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NatShopB2C.Domain.Models
{
    public partial class SalesOrder
    {
        public SalesOrder()
        {
            Sales = new HashSet<Sale>();
        }

        public long Id { get; set; }
        public long? SaleBillNo { get; set; }
        public Guid? PersonAccountId { get; set; }
        public string? Series { get; set; }
        public Guid? UserId { get; set; }
        public int? CurrencyId { get; set; }
        public decimal? CurrencyValue { get; set; }
        public int? TotalQuantity { get; set; }
        public decimal? TotalAmount { get; set; }
        public decimal? TotalDiscount { get; set; }
        public decimal? TotalShipmentCharge { get; set; }
        public decimal? OtherAdditions { get; set; }
        public decimal? OtherDeductions { get; set; }
        public decimal? NetPayable { get; set; }
        public byte? OrderStatusId { get; set; }
        public short? PaymentMethodId { get; set; }
        public int? BillingAddressId { get; set; }
        public int? ShippingAddressId { get; set; }
        public long? ShippingId { get; set; }
        public int? ShippingAgentId { get; set; }
        public string? ShippingAgentTokenId { get; set; }
        public bool? IsDispatched { get; set; }
        public DateTime? PaymentReceiveDate { get; set; }
        public DateTime? ShippmentDate { get; set; }
        public DateTime? DeliveredDate { get; set; }
        public bool? IsDelliver { get; set; }
        public bool? IsPaymentMade { get; set; }
        public string? Descriptions { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsDelete { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }

        public virtual Currency? Currency { get; set; }
        public virtual PersonAccount? PersonAccount { get; set; }
        public virtual ICollection<Sale> Sales { get; set; }
    }
}
