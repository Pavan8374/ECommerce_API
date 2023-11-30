using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NatShopB2C.Domain.Models
{
    public partial class Topic
    {
        public Topic()
        {
            InverseParentTopic = new HashSet<Topic>();
            Smstopics = new HashSet<Smstopic>();
            TopicMails = new HashSet<TopicMail>();
            UserSubscriptions = new HashSet<UserSubscription>();
        }

        public int Id { get; set; }
        public string TopicName { get; set; } = null!;
        public int? ParentTopicId { get; set; }
        public string? Description { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsDelete { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }

        public virtual Topic? ParentTopic { get; set; }
        public virtual ICollection<Topic> InverseParentTopic { get; set; }
        public virtual ICollection<Smstopic> Smstopics { get; set; }
        public virtual ICollection<TopicMail> TopicMails { get; set; }
        public virtual ICollection<UserSubscription> UserSubscriptions { get; set; }
    }
}
