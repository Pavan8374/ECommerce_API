using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NatShopB2C.Domain.Models
{
    public partial class Purchase
    {
        public Purchase()
        {
            PurchaseDetails = new HashSet<PurchaseDetail>();
        }

        public long Id { get; set; }
        public string? PurchaseBillNo { get; set; }
        public string? TransactionCode { get; set; }
        public int? PurchaseOrderNo { get; set; }
        public string? ExternalBillNo { get; set; }
        public Guid? PersonAccountId { get; set; }
        public int? CurrencyId { get; set; }
        public decimal? CurrencyValue { get; set; }
        public bool? IsGeneralPurchase { get; set; }
        public int? TotalQuantity { get; set; }
        public decimal? TotalAmount { get; set; }
        public decimal? TotalDiscount { get; set; }
        public decimal? TotalShipmentCharges { get; set; }
        public decimal? OtherAdditions { get; set; }
        public decimal? OtherDeductions { get; set; }
        public decimal? NetPayable { get; set; }
        public string? Description { get; set; }
        public short? PurchaseStatusId { get; set; }
        public DateTime? TransactionDate { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsDelete { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }

        public virtual Currency? Currency { get; set; }
        public virtual PersonAccount? PersonAccount { get; set; }
        public virtual ICollection<PurchaseDetail> PurchaseDetails { get; set; }
    }
}
