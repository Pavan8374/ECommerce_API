using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NatShopB2C.Domain.Models
{
    public partial class Document
    {
        public Document()
        {
            MailAttachments = new HashSet<MailAttachment>();
        }

        public Guid Id { get; set; }
        public string DocumentName { get; set; } = null!;
        public string FilePath { get; set; } = null!;
        public string? Description { get; set; }
        public Guid? CreatedBy { get; set; }
        public Guid? LastModifiedBy { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsDelete { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }

        public virtual ICollection<MailAttachment> MailAttachments { get; set; }
    }
}
