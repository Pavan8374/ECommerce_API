using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NatShopB2C.Domain.StoredProcedureModels
{
    public class select_ProductsDetailsByFilter
    {
        //public long? RowNo { get; set; }
        public Guid? ProductID { get; set; }
        public short? StockTypeID { get; set; }
        public int? CategoryID { get; set; }
        public int? BrandID { get; set; }
        //public Guid? ImageID { get; set; }
        //public Guid? ProductVariantPriceID { get; set; }
        public string? ProductName { get; set; }
        public string? ProductCode { get; set; }
        public decimal? Price { get; set; }
        public bool? IsActive { get; set; }
        public short? UnitID { get; set; }
        public int? Quantity { get; set; }
        //public string? ImagePath { get; set; }
        public decimal? Rating { get; set; }    
        //public string? Description { get; set; }
        public int? Popularity { get; set; }
        public bool? IsNew { get; set; }
        public int? StockQuantity { get; set; }
        public string? CategoryName { get; set; }
        public string? BrandName { get; set; }

        public string? ProductTypeName { get; set; }
    }
}
