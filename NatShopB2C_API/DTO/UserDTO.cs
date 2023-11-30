namespace NatShopB2C_API.DTO
{
    public class UserDTO
    {
        public string? ApplicationId { get; set; }
        public string? UserId { get; set; }
        public string? UserName { get; set; } = null!;
        public bool IsAnonymous { get; set; }
        public DateTime LastActivityDate { get; set; }

    }
}
