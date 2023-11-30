using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NatShopB2C.Domain.Models
{
    public partial class MailQueue
    {
        public Guid Id { get; set; }
        public Guid MailId { get; set; }
        public string Email { get; set; } = null!;
        public bool? IsDelivered { get; set; }
        public DateTime? SendDate { get; set; }
        public string? Description { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsDelete { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }

        public virtual Mail Mail { get; set; } = null!;
    }
}
