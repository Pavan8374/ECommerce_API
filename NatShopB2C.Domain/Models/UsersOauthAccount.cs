using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NatShopB2C.Domain.Models
{
    public partial class UsersOauthAccount
    {
        public Guid Id { get; set; }
        public Guid? UserId { get; set; }
        public string ProviderUserId { get; set; } = null!;
        public string ProviderUserName { get; set; } = null!;
        public string? UserProfilePicPath { get; set; }
        public string? Email { get; set; }
        public int OauthProviderId { get; set; }
        public DateTime? LastUsedUtc { get; set; }
        public string? Description { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsDelete { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }

        public virtual OauthProvider OauthProvider { get; set; } = null!;
        public virtual UserDetail? User { get; set; }
    }
}
