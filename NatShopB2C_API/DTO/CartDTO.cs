namespace NatShopB2C_API.DTO
{
    public class CartDTO
    {
        public long Id { get; set; }
        public Guid? UserId { get; set; }
        public Guid? ProductVariationId { get; set; }
        public double? Quantity { get; set; }
        public short? UnitId { get; set; }
        public Guid? PriceId { get; set; }
        public string? Remark { get; set; }
        public Guid? ProductDiscountId { get; set; }
        public bool? IsWishList { get; set; }
        public bool? IsOrdered { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsDelete { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
    }
}
