using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NatShopB2C.Domain.Models
{
    public partial class UserSubscription
    {
        public Guid Id { get; set; }
        public Guid? UserId { get; set; }
        public string? UserName { get; set; }
        public string? Email { get; set; }
        public string? Mobile { get; set; }
        public int? TopicId { get; set; }
        public Guid? ProductId { get; set; }
        public int? BrandId { get; set; }
        public int? CategoryId { get; set; }
        public int? Daily { get; set; }
        public int? Weekly { get; set; }
        public int? Monthly { get; set; }
        public int? Weekends { get; set; }
        public bool? IsRegister { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? ExpireDate { get; set; }
        public string? Description { get; set; }
        public bool? IsEmailSubscriber { get; set; }
        public bool? IsSmssubscriber { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsDelete { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }

        public virtual Brand? Brand { get; set; }
        public virtual Category? Category { get; set; }
        public virtual Product? Product { get; set; }
        public virtual Topic? Topic { get; set; }
        public virtual UserDetail? User { get; set; }
    }
}
