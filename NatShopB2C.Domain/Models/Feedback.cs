using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NatShopB2C.Domain.Models
{
    public partial class Feedback
    {
        public int Id { get; set; }
        public short? FeedbackCategoryId { get; set; }
        public string? UserName { get; set; }
        public string? Ipaddress { get; set; }
        public string? Email { get; set; }
        public string? ContactNo { get; set; }
        public byte? UserRating { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public byte? Priority { get; set; }
        public bool? IsUnread { get; set; }
        public int? ActionId { get; set; }
        public string? ActionDescription { get; set; }
        public DateTime? ActionDate { get; set; }
        public Guid? ActionBy { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsDelete { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }

        public virtual FeedbackAction? Action { get; set; }
        public virtual UserDetail? ActionByNavigation { get; set; }
        public virtual FeedbackInquiryCategory? FeedbackCategory { get; set; }
    }
}
