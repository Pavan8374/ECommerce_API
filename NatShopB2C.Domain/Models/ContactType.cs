using NatShopB2C.Domain.Models.NatShopB2CAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NatShopB2C.Domain.Models
{
    public partial class ContactType
    {
        public ContactType()
        {
            UserContacts = new HashSet<UserContact>();
        }

        public short Id { get; set; }
        public string? ContactTypeName { get; set; }
        public string? Description { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsDelete { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }

        public virtual ICollection<UserContact> UserContacts { get; set; }
    }
}
