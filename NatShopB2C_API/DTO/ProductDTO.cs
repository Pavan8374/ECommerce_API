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
}
