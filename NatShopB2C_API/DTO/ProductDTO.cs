using NatShopB2C.EF.Common.Products;

namespace NatShopB2C_API.DTO
{
    public class ProductDTO
    {
        public string? ProductID { get; set; }
        public string? ProductVariationID { get; set; }
        public string? ProductVariationImageID { get; set; }
        public string? ImageID { get; set; }
        public string? ProductVariantPriceID { get; set; }
        public string? ProductName { get; set; }
        public int BrandId { get; set; }
        public string? BrandName { get; set; }
        public string? CategoryName { get; set; }
        public string? ProductCode { get; set; }
        public int? Price { get; set; }
        public string? ImagePath { get; set; }
        public int? Rating { get; set; }
        public string? Description { get; set; }
        //public Nullable<int> Popularity { get; set; }
        public string? StockTypeName { get; set; }
    }
    public class ProductVarientDTO
    {
        public Guid? Id { get; set; }
        public Guid ProductId { get; set; }
        public string? Caption { get; set; }
        public decimal? Rating { get; set; }
        public int? Popularity { get; set; }
        public Guid? ProductAssociationId { get; set; }
        public string? ProductVariationList { get; set; }
        public bool? IsVariation { get; set; }
        public bool? IsDefaultProductVariation { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsDelete { get; set; }
        public DateTime? CreateDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
    }
    public class ProductDetailDTO
    {
        public Guid ProductID { get; set; }
        public Guid ProductVariationID { get; set; }
        public string ProductVariationImageID { get; set; }
        public string ImageID { get; set; }
        public string ProductVariantPriceID { get; set; }
        public string PriceID { get; set; }
        public string ProductName { get; set; }
        public string BrandName { get; set; }
        public string BrandUrl { get; set; }
        public string CategoryName { get; set; }
        public string Caption { get; set; }
        public string ProductCode { get; set; }
        public string Price { get; set; }
        public string UnitCode { get; set; }
        public string ImagePath { get; set; }
        public Nullable<decimal> Rating { get; set; }
        public string StockStatus { get; set; }

        public string Description { get; set; }
        public string Quantity { get; set; }
        public bool IsShowAddtoCart { get; set; }
        public bool IsShowBuy { get; set; }
        public bool IsMorePrice { get; set; }

        public List<ProductImageDTO> ProductImages { get; set; }

        public List<ProductSpecificationDTO> ProductSpecification { get; set; }

        public List<ProductOtherPackDTO> OtherPack { get; set; }
    }
}
