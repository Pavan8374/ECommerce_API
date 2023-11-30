using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NatShopB2C.Domain.Models
{
    public partial class UserPropertyValue
    {
        public Guid Id { get; set; }
        public int UserPropertyId { get; set; }
        public Guid UserId { get; set; }
        public string? Value { get; set; }

        public virtual UserDetail User { get; set; } = null!;
        public virtual UserProperty UserProperty { get; set; } = null!;
    }
}
