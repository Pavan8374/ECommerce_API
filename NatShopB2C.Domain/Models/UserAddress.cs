using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NatShopB2C.Domain.Models
{
    public partial class UserAddress
    {
        public int Id { get; set; }
        public Guid? UserId { get; set; }
        public int? AddressId { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsDelete { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }

        public virtual Address? Address { get; set; }
        public virtual UserDetail? User { get; set; }
    }
}
