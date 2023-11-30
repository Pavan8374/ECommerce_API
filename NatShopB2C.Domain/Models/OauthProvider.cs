using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NatShopB2C.Domain.Models
{
    public partial class OauthProvider
    {
        public OauthProvider()
        {
            UsersOauthAccounts = new HashSet<UsersOauthAccount>();
        }

        public int Id { get; set; }
        public string ProviderName { get; set; } = null!;
        public string? ProviderIcon { get; set; }
        public string? ApplicationId { get; set; }
        public string? SecretKey { get; set; }
        public string? LoginUrl { get; set; }
        public string? TokenUrl { get; set; }
        public string? UserInfoUrl { get; set; }
        public string? CallbackUrl { get; set; }
        public string? Permission { get; set; }
        public string? Description { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsDelete { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }

        public virtual ICollection<UsersOauthAccount> UsersOauthAccounts { get; set; }
    }
}
