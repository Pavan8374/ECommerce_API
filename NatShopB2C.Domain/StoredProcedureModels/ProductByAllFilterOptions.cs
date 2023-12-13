using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NatShopB2C.Domain.StoredProcedureModels
{
    public class ProductByAllFilterOptions
    {
        public long? RowNo { get; set; }
        public Guid? ProductID { get; set; }
        public string? BrandName { get; set; }
        public Guid? ProductVariationID { get; set; }
        public decimal? ProductVariationRating { get; set; }
        public Guid? ProductVariationImageID { get; set; }
        public string? Caption { get; set; }
        public Guid? ImageId { get; set; }
        public string? ImagePath { get; set; }
        public string? alt { get; set; }
        public string? UnitCode { get; set; }
        public Guid? PriceID { get; set; }
        public string? CategoryName { get; set; }
        public Guid? ID { get; set; }
        public string? ProductCode { get; set; }
        public string? ProductName { get; set; }
        public short? ProductTypeID { get; set; }
        public short? StockTypeID { get; set; }
        public int? ManufactureID { get; set; }
        public long? ProductSetID { get; set; }
        public int? UsageTypeID { get; set; }
        public string? LinkURL { get; set; }
        public short? UnitID { get; set; }
        public int? Quantity { get; set; }
        public decimal? Price { get; set; }
        public int? MinOrderQuantity { get; set; }
        public int? MaxOrderQuantity { get; set; }
        public short? SKUID { get; set; }
        public decimal? Rating { get; set; }
        public int? BrandID { get; set; }
        public int? CategoryID { get; set; }
        public DateTime? LaunchDate { get; set; }
        public int? Popularity { get; set; }
        public bool? IsNew { get; set; }
        public bool? IsCOD { get; set; }
        public bool? IsEMI { get; set; }
        public bool? IsSubscribable { get; set; }
        public int? StockQuantity { get; set; }
        public string? Description { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsDelete { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
    }
}
