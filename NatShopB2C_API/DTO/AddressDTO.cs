namespace NatShopB2C_API.DTO
{
    public class AddressDTO
    {
        public int Id { get; set; }
        public int AddressTypeId { get; set; }
        public string? AddressLabelName { get; set; }
        public string? AddressPersonName { get; set; }
        public string AddressLine1 { get; set; }
        public string? AddressLine2 { get; set; }
        public int? CityId { get; set; }
        public int? StateId { get; set; }
        public int? CountryId { get; set; }
        public string? ZipCode { get; set; }
        public bool? IsDefault { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsDelete { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public Guid? UserId { get; set; }
    }
    public class AddressesDTO
    {
        public int Id { get; set; }
        //public int AddressTypeId { get; set; }
        public string? AddressLabelName { get; set; }
        public string? AddressPersonName { get; set; }
        public string AddressLine1 { get; set; }
        public string? AddressLine2 { get; set; }
        //public int? CityId { get; set; }
        public string? CityName { get; set; }
        //public int? StateId { get; set; }
        public string? StateName { get; set; }
        //public int? CountryId { get; set; }
        public string? CountryName { get; set; }
        public string? ZipCode { get; set; }
        public bool? IsDefault { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsDelete { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public Guid? UserId { get; set; }
    }
}
