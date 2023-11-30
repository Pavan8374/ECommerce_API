namespace NatShopB2C_API.DTO
{
    public class UserDetailDTO
    {
        public Guid? UserId { get; set; }
        public string? FirstName { get; set; }
        public string? MiddleName { get; set; }
        public string? LastName { get; set; }
        public DateTime? Birthdate { get; set; }
        public string? Gender { get; set; }
        public int? ProofTypeId { get; set; }
        public string? ProofNo { get; set; }
        public string? ProfilePicPath { get; set; }
        public short? UserTypeId { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsDelete { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
    }
    public class UserDetailsDTO
    {
        public Guid UserId { get; set; }
        public string? FirstName { get; set; }
        public string? MiddleName { get; set; }
        public string? LastName { get; set; }
        public DateTime? Birthdate { get; set; }
        public string? Gender { get; set; }
        public string? ProofTypeName { get; set; }
        public string? ProofNo { get; set; }        
        public string? UserTypeName { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsDelete { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
    }
}
