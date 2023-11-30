using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NatShopB2C.Domain.Models
{
    public partial class UserLog
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public short ActivityTypeId { get; set; }
        public DateTime ActivityTime { get; set; }
        public string? Ipaddress { get; set; }
        public string? MachineId { get; set; }
        public string? UserAgent { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsDelete { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }

        public virtual ActivityType ActivityType { get; set; } = null!;
        public virtual UserDetail User { get; set; } = null!;
    }
}
