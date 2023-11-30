using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NatShopB2C.Domain.Models
{
    public partial class UserType
    {
        public UserType()
        {
            UserDetails = new HashSet<UserDetail>();
        }

        public short Id { get; set; }
        public string? UserTypeName { get; set; }
        public string? Description { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsDelete { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }

        public virtual ICollection<UserDetail> UserDetails { get; set; }
    }
}
