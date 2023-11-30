using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NatShopB2C.Domain.Models
{
    public partial class Role
    {
        public Role()
        {
            RolePages = new HashSet<RolePage>();
            Users = new HashSet<User>();
        }

        public Guid ApplicationId { get; set; }
        public Guid RoleId { get; set; }
        public string RoleName { get; set; } = null!;
        public string? Description { get; set; }

        public virtual Application Application { get; set; } = null!;
        public virtual ICollection<RolePage> RolePages { get; set; }

        public virtual ICollection<User> Users { get; set; }
    }
}
