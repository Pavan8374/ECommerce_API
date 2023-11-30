using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NatShopB2C.Domain.Models
{
    public partial class TopicMail
    {
        public Guid Id { get; set; }
        public Guid MailId { get; set; }
        public int? TopicId { get; set; }
        public Guid? ProductId { get; set; }
        public int? CategoryId { get; set; }
        public int? BrandId { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsDelete { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }

        public virtual Brand? Brand { get; set; }
        public virtual Category? Category { get; set; }
        public virtual Mail Mail { get; set; } = null!;
        public virtual Product? Product { get; set; }
        public virtual Topic? Topic { get; set; }
    }
}
