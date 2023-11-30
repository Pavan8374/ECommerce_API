using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NatShopB2C.Domain.Models
{
    public partial class Mail
    {
        public Mail()
        {
            MailAttachments = new HashSet<MailAttachment>();
            MailQueues = new HashSet<MailQueue>();
            MailResources = new HashSet<MailResource>();
            TopicMails = new HashSet<TopicMail>();
        }

        public Guid Id { get; set; }
        public string MailName { get; set; } = null!;
        public string? Subject { get; set; }
        public string? Description { get; set; }
        public int? Priority { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? ExpireDate { get; set; }
        public bool? IsHtml { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsDelete { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }

        public virtual ICollection<MailAttachment> MailAttachments { get; set; }
        public virtual ICollection<MailQueue> MailQueues { get; set; }
        public virtual ICollection<MailResource> MailResources { get; set; }
        public virtual ICollection<TopicMail> TopicMails { get; set; }
    }
}
