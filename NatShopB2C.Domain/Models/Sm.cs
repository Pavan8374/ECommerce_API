using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NatShopB2C.Domain.Models
{
    public partial class Sm
    {
        public Sm()
        {
            Smsqueues = new HashSet<Smsqueue>();
            Smstopics = new HashSet<Smstopic>();
        }

        public Guid Id { get; set; }
        public string Smsname { get; set; } = null!;
        public string? Description { get; set; }
        public int Priority { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? ExpireDate { get; set; }

        public virtual ICollection<Smsqueue> Smsqueues { get; set; }
        public virtual ICollection<Smstopic> Smstopics { get; set; }
    }
}
