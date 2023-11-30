using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NatShopB2C.Domain.Models
{
    public partial class Notification
    {
        public int Id { get; set; }
        public string? NotificationText { get; set; }
        public short? NotificationTypeId { get; set; }
        public string? RefId { get; set; }
        public string? ImagePath1 { get; set; }
        public string? ImagePath2 { get; set; }
        public bool? IsRead { get; set; }
        public string? RedirectUrl { get; set; }
        public string? Description { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsDelete { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }

        public virtual NotificationType? NotificationType { get; set; }
    }
}
