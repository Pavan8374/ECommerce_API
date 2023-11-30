using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NatShopB2C.Domain.Models
{
    public partial class ActivityType
    {
        public ActivityType()
        {
            UserLogs = new HashSet<UserLog>();
        }

        public short Id { get; set; }
        public string ActivityTypeName { get; set; } = null!;
        public string? Description { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsDelete { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }

        public virtual ICollection<UserLog> UserLogs { get; set; }
    }

}
