using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NatShopB2C.Domain.Models
{
    public partial class FeedbackInquiryCategory
    {
        public FeedbackInquiryCategory()
        {
            Feedbacks = new HashSet<Feedback>();
            Inquiries = new HashSet<Inquiry>();
        }

        public short Id { get; set; }
        public string Name { get; set; } = null!;
        public string? Description { get; set; }
        public bool? IsFeedback { get; set; }
        public bool? IsInquiry { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsDelete { get; set; }
        public DateTime? CreateDate { get; set; }
        public DateTime? ModifiedDate { get; set; }

        public virtual ICollection<Feedback> Feedbacks { get; set; }
        public virtual ICollection<Inquiry> Inquiries { get; set; }
    }
}
