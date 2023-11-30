using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NatShopB2C.Domain.Models
{
    public partial class SalesDetail
    {
        public Guid Id { get; set; }
        public byte? SrNo { get; set; }
        public long? SalesId { get; set; }
        public Guid? ProductVariationId { get; set; }
        public string? ProductName { get; set; }
        public string? ProductCode { get; set; }
        public string? ProductDetailJson { get; set; }
        public Guid? PriceId { get; set; }
        public Guid? ProductDiscountId1 { get; set; }
        public Guid? ProductDiscountId2 { get; set; }
        public Guid? ProductDiscountId3 { get; set; }
        public short? UnitId { get; set; }
        public decimal? Quantity { get; set; }
        public decimal? Price { get; set; }
        public decimal? Amount { get; set; }
        public decimal? DiscountAmount { get; set; }
        public long? ProductTaxId { get; set; }
        public long? TaxId { get; set; }
        public string? Description { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsDelete { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }

        public virtual Price? PriceNavigation { get; set; }
        public virtual ProductVariation? ProductVariation { get; set; }
        public virtual Sale? Sales { get; set; }
    }
}
