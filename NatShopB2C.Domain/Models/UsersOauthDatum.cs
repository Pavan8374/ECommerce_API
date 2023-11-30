using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NatShopB2C.Domain.Models
{
    public partial class UsersOauthDatum
    {
        public Guid UserId { get; set; }
        public bool IsLocalAccountActive { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }

        public virtual UserDetail User { get; set; } = null!;
    }
}
