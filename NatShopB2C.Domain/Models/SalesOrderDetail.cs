using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NatShopB2C.Domain.Models
{
    public partial class SalesOrderDetail
    {
        public Guid Id { get; set; }
        public long? SalesOrderId { get; set; }
        public byte? SrNo { get; set; }
        public Guid? ProductVariationId { get; set; }
        public Guid? PriceId { get; set; }
        public Guid? ProductDiscountId { get; set; }
        public int? Quantity { get; set; }
        public short? UnitId { get; set; }
        public decimal? Rate { get; set; }
        public decimal? DiscountAmount { get; set; }
        public decimal? Amount { get; set; }
        public string? Remark { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsDelete { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
    }
}
