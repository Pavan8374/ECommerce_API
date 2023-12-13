using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NatShopB2C.Domain.AccountModels
{
    public class ProductByAllFilterOptionsDTO
    {
        //public Nullable<long> RowNo { get; set; }
        //public System.Guid ProductID { get; set; }
        public string BrandName { get; set; }
        //public System.Guid ProductVariationID { get; set; }
        public Nullable<decimal> ProductVariationRating { get; set; }
        //public Nullable<System.Guid> ProductVariationImageID { get; set; }
        public string Caption { get; set; }
        //public Nullable<System.Guid> ImageID { get; set; }
        public string ImagePath { get; set; }
        public string alt { get; set; }
        public string UnitCode { get; set; }
        //public Nullable<System.Guid> PriceID { get; set; }
        public string CategoryName { get; set; }
        //public System.Guid ID { get; set; }
        public string ProductCode { get; set; }
        public string ProductName { get; set; }
        //public Nullable<short> ProductTypeID { get; set; }
        //public Nullable<short> StockTypeID { get; set; }
        //public Nullable<int> ManufactureID { get; set; }
        //public Nullable<long> ProductSetID { get; set; }
        //public Nullable<int> UsageTypeID { get; set; }
        public string LinkURL { get; set; }
        //public Nullable<short> UnitID { get; set; }
        public Nullable<int> Quantity { get; set; }
        public Nullable<decimal> Price { get; set; }
        public Nullable<int> MinOrderQuantity { get; set; }
        public Nullable<int> MaxOrderQuantity { get; set; }
        public Nullable<short> SKUID { get; set; }
        public Nullable<decimal> Rating { get; set; }
        //public Nullable<int> BrandID { get; set; }
        //public Nullable<int> CategoryID { get; set; }
        public Nullable<System.DateTime> LaunchDate { get; set; }
        public Nullable<int> Popularity { get; set; }
        public Nullable<bool> IsNew { get; set; }
        public Nullable<bool> IsCOD { get; set; }
        public Nullable<bool> IsEMI { get; set; }
        public Nullable<bool> IsTaxable { get; set; }
        public Nullable<bool> IsSubscribable { get; set; }
        public Nullable<int> StockQuantity { get; set; }
        public string Description { get; set; }
        //public Nullable<bool> IsActive { get; set; }
        //public Nullable<bool> IsDelete { get; set; }
        //public Nullable<System.DateTime> CreatedDate { get; set; }
        //public Nullable<System.DateTime> ModifiedDate { get; set; }
    }


    public class ProductImagePathDTO
    {
        public string ProductName { get; set; }
        public string ImagePath { get; set; }
        public Guid? ProductID { get; set; }
        public Guid? ProductVariationID { get; set; }
        public Guid? ProductVariationImageID { get; set; }
        public Guid? ImageID { get; set; }
        public Guid? ProductVariantPriceID { get; set; }
        public int BrandId { get; set; }
        public string? BrandName { get; set; }
        public string? CategoryName { get; set; }
        public string? ProductCode { get; set; }
        public int? Price { get; set; }
        public int? Rating { get; set; }
        public string? Description { get; set; }
        //public Nullable<int> Popularity { get; set; }
        public string? StockTypeName { get; set; }
    }
}
