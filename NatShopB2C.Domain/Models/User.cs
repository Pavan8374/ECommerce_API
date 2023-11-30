using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NatShopB2C.Domain.Models
{
    public partial class User
    {
        public User()
        {
            Roles = new HashSet<Role>();
        }

        public Guid ApplicationId { get; set; }
        public Guid UserId { get; set; }
        public string UserName { get; set; } = null!;
        public bool IsAnonymous { get; set; }
        public DateTime LastActivityDate { get; set; }

        public virtual Application Application { get; set; } = null!;
        public virtual Membership? Membership { get; set; }
        public virtual Profile? Profile { get; set; }
        public virtual UserDetail? UserDetail { get; set; }

        public virtual ICollection<Role> Roles { get; set; }
    }
}
