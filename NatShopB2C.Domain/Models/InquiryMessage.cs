using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NatShopB2C.Domain.Models
{
    public partial class InquiryMessage
    {
        public Guid Id { get; set; }
        public Guid? InquiryId { get; set; }
        public string? Message { get; set; }
        public string? UserAgent { get; set; }
        public Guid? ImageId { get; set; }
        public string? Ipaddress { get; set; }
        public bool IsReplay { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsDelete { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }

        public virtual Image? Image { get; set; }
        public virtual Inquiry? Inquiry { get; set; }
    }
}
