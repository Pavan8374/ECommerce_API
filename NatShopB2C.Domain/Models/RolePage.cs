using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NatShopB2C.Domain.Models
{
    public partial class RolePage
    {
        public int Id { get; set; }
        public Guid RoleId { get; set; }
        public int PageId { get; set; }
        public string? Permission { get; set; }

        public virtual Page Page { get; set; } = null!;
        public virtual Role Role { get; set; } = null!;
    }
}
