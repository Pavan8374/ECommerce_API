using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NatShopB2C.Domain.Models
{
    public partial class Smstopic
    {
        public Guid Id { get; set; }
        public Guid Smsid { get; set; }
        public int TopicId { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsDelete { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }

        public virtual Sm Sms { get; set; } = null!;
        public virtual Topic Topic { get; set; } = null!;
    }
}
