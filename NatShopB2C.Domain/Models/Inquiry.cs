using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NatShopB2C.Domain.Models
{
    public partial class Inquiry
    {
        public Inquiry()
        {
            InquiryMessages = new HashSet<InquiryMessage>();
        }

        public Guid Id { get; set; }
        public short InquiryCategoryId { get; set; }
        public Guid? UserId { get; set; }
        public Guid? ResponderUserId { get; set; }
        public string? UserName { get; set; }
        public string? Email { get; set; }
        public string? ContactNo { get; set; }
        public string? Title { get; set; }
        public byte? Priority { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsDelete { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }

        public virtual FeedbackInquiryCategory InquiryCategory { get; set; } = null!;
        public virtual UserDetail? ResponderUser { get; set; }
        public virtual UserDetail? User { get; set; }
        public virtual ICollection<InquiryMessage> InquiryMessages { get; set; }
    }
}
