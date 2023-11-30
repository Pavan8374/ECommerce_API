using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NatShopB2C.Domain.Models
{
    public partial class Page
    {
        public Page()
        {
            AdminMenus = new HashSet<AdminMenu>();
            RolePages = new HashSet<RolePage>();
        }

        public int Id { get; set; }
        public string PageRelativeName { get; set; } = null!;
        public string? AliasName { get; set; }
        public bool? IsRequiredPermission { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsDelete { get; set; }

        public virtual ICollection<AdminMenu> AdminMenus { get; set; }
        public virtual ICollection<RolePage> RolePages { get; set; }
    }
}
