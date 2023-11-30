using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NatShopB2C.Domain.Models
{
    public partial class PurchaseOrder
    {
        public long Id { get; set; }
        public string? PurchaseOrderNo { get; set; }
        public string? TransactionCode { get; set; }
        public Guid? PersonAccountId { get; set; }
        public int? CurrencyId { get; set; }
        public decimal? CurrencyValue { get; set; }
        public bool? IsGeneralPurchase { get; set; }
        public int? TotalQuantity { get; set; }
        public decimal? TotalAmount { get; set; }
        public string? Description { get; set; }
        public short? PurchaseOrderStatusId { get; set; }
        public Guid? PurchaseOrderedBy { get; set; }
        public Guid? PurchaseOrderApproveBy { get; set; }
        public DateTime? TransactionDate { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsDelete { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
    }
}
