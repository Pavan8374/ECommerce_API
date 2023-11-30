using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NatShopB2C.Domain.Models
{
    public partial class Sale
    {
        public Sale()
        {
            SalesDetails = new HashSet<SalesDetail>();
        }

        public long Id { get; set; }
        public string? SaleBillNo { get; set; }
        public string? TransactionTypeCode { get; set; }
        public long? SalesOrderId { get; set; }
        public short? SalesTypeId { get; set; }
        public Guid? PersonAccountId { get; set; }
        public int? CurrencyId { get; set; }
        public decimal? CurrencyValue { get; set; }
        public string? CurrencyFormat { get; set; }
        public decimal? TotalQuantity { get; set; }
        public decimal? TotalAmount { get; set; }
        public decimal? TotalDiscount { get; set; }
        public decimal? TotalTax { get; set; }
        public decimal? OtherAdditions { get; set; }
        public decimal? OtherDeductions { get; set; }
        public decimal? NetPayable { get; set; }
        public short? SalesStatusId { get; set; }
        public short? PaymentMethodId { get; set; }
        public DateTime? PaymentReceiveDate { get; set; }
        public decimal? TotalShipmentCharge { get; set; }
        public int? ShippingAddressId { get; set; }
        public int? BillingAddressId { get; set; }
        public string? ShippingAddressJson { get; set; }
        public string? BillingAddressJson { get; set; }
        public long? ShippingId { get; set; }
        public int? ShippingAgentId { get; set; }
        public string? ShippingAgentTokenId { get; set; }
        public string? ShippingTrackingUrl { get; set; }
        public bool? IsDispatched { get; set; }
        public DateTime? DeliveredDate { get; set; }
        public bool? IsDelivered { get; set; }
        public bool? IsPaymentMade { get; set; }
        public DateTime? DueDate { get; set; }
        public string? ContactNumber { get; set; }
        public string? ResPaymentTransactionNo { get; set; }
        public bool? ResIsTransactionSuccessFul { get; set; }
        public string? ResMessage { get; set; }
        public string? ResCurrecnyCode { get; set; }
        public decimal? ResNetReceivedAmount { get; set; }
        public string? ResVault { get; set; }
        public string? ResCardName { get; set; }
        public string? ResBankRefNo { get; set; }
        public string? ResOfferType { get; set; }
        public string? ResOfferCode { get; set; }
        public decimal? ResDiscountValue { get; set; }
        public string? ResCoRelationId { get; set; }
        public DateTime? ResTimeStamp { get; set; }
        public string? ResJson { get; set; }
        public DateTime? TransactionDate { get; set; }
        public string? Descriptions { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsDelete { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }

        public virtual Address? BillingAddress { get; set; }
        public virtual Currency? Currency { get; set; }
        public virtual PaymentMethod? PaymentMethod { get; set; }
        public virtual PersonAccount? PersonAccount { get; set; }
        public virtual SalesOrder? SalesOrder { get; set; }
        public virtual SalesStatus? SalesStatus { get; set; }
        public virtual SalesType? SalesType { get; set; }
        public virtual Address? ShippingAddress { get; set; }
        public virtual ICollection<SalesDetail> SalesDetails { get; set; }
    }
}
