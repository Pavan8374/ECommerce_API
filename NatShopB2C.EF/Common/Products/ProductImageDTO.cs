using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NatShopB2C.EF.Common.Products
{
    public class ProductImageDTO
    {
        public Guid ImageID { get; set; }
        public Guid ProductID { get; set; }
        public Guid ProductVariantID { get; set; }
        public int ImageOrderNo { get; set; }
        public string LargeImagePath { get; set; }
        public bool IsImageZoom { get; set; }
    }
    public class ProductSpecificationDTO
    {
        public Guid ProductID { get; set; }
        public string SpecificationName { get; set; }
        public string Value { get; set; }
        public int SpecificationID { get; set; }
        public int GroupID { get; set; }
        public string GroupName { get; set; }
    }
    public class ProductOtherPackDTO
    {
        public string ProductVariantPriceID { get; set; }
        public string ProductID { get; set; }
        public string ProductVariantID { get; set; }
        public string PriceID { get; set; }
        public short UnitID { get; set; }
        public string UnitCode { get; set; }
        public string UnitName { get; set; }
        public int Quantity { get; set; }
        public string Price { get; set; }
        public bool IsBasePrice { get; set; }
        public bool IsDefaultPrice { get; set; }
        public string LinkUrl { get; set; }
        public string ProductPriceID { get; set; }
        public bool IsOutofStock { get; set; }
        public bool IsShowAddToCart { get; set; }
        public bool IsShowBuy { get; set; }
    }
    //public class ProductDetailDTO
    //{
    //    public Guid ProductID { get; set; }
    //    public Guid ProductVariationID { get; set; }
    //    public string ProductVariationImageID { get; set; }
    //    public string ImageID { get; set; }
    //    public string ProductVariantPriceID { get; set; }
    //    public string PriceID { get; set; }
    //    public string ProductName { get; set; }
    //    public string BrandName { get; set; }
    //    public string BrandUrl { get; set; }
    //    public string CategoryName { get; set; }
    //    public string Caption { get; set; }
    //    public string ProductCode { get; set; }
    //    public string Price { get; set; }
    //    public string UnitCode { get; set; }
    //    public string ImagePath { get; set; }
    //    public Nullable<decimal> Rating { get; set; }
    //    public string StockStatus { get; set; }

    //    public string Description { get; set; }
    //    public string Quantity { get; set; }
    //    public bool IsShowAddtoCart { get; set; }
    //    public bool IsShowBuy { get; set; }
    //    public bool IsMorePrice { get; set; }

    //    public List<ProductImageDTO> ProductImages { get; set; }

    //    public List<ProductSpecificationDTO> ProductSpecification { get; set; }

    //    public List<ProductOtherPackDTO> OtherPack { get; set; }
    //}
}
