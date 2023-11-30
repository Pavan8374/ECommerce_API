using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NatShopB2C.Domain.Models
{
    public partial class Smsqueue
    {
        public Guid Id { get; set; }
        public Guid? UserId { get; set; }
        public Guid? Smsid { get; set; }
        public bool? IsDelivered { get; set; }
        public DateTime? SendDate { get; set; }
        public string? Description { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsDelete { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }

        public virtual Sm? Sms { get; set; }
        public virtual UserDetail? User { get; set; }
    }
}
