using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NatShopB2C.Domain.StoredProcedureModels
{
    public class select_Slider_NewProduct
    {
        public long? RowNo { get; set; }
        public Guid? ProductID { get; set; }
        public Guid? ProductVariationID { get; set; }
        public Guid? ProductVariationImageID { get; set; }
        public Guid? ImageID { get; set; }
        public string? ProductName { get; set; }
        public string? BrandName { get; set; }
        public string? CategoryName { get; set; }
        public string? Caption { get; set; }
        public string? ProductCode { get; set; }
        public decimal? Price { get; set; }
        public string? ImagePath { get; set; }
        public decimal? Rating { get; set; }
    }
}
