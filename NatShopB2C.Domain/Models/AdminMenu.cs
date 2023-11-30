using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NatShopB2C.Domain.Models
{
    public partial class AdminMenu
    {
        public AdminMenu()
        {
            InverseParentMenu = new HashSet<AdminMenu>();
        }

        public int Id { get; set; }
        public string? Caption { get; set; }
        public int? PageId { get; set; }
        public int? ParentMenuId { get; set; }
        public string? ImagePath { get; set; }
        public short? Order { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsDelete { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }

        public virtual Page? Page { get; set; }
        public virtual AdminMenu? ParentMenu { get; set; }
        public virtual ICollection<AdminMenu> InverseParentMenu { get; set; }
    }
}
