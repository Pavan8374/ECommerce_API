using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NatShopB2C.Domain.Models
{
    public partial class UserFlagValue
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public int? UserFlagId { get; set; }
        public string? UserFlagValue1 { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsDelete { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }

        public virtual UserDetail User { get; set; } = null!;
        public virtual UserFlag? UserFlag { get; set; }
    }
}
