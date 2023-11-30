namespace NatShopB2C_API.DTO
{
    public class BrandDTO
    {
        public int Id { get; set; }
        public string BrandName { get; set; } = null!;
        public string? Description { get; set; }
        public decimal? Rating { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsDelete { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
    }
}
