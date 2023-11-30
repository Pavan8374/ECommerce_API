using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NatShopB2C.Domain.Models
{
    namespace NatShopB2CAPI.Models
    {
        public partial class UserContact
        {
            public Guid Id { get; set; }
            public Guid UserId { get; set; }
            public short ContactTypeId { get; set; }
            public string? CountryCode { get; set; }
            public string ContactNo { get; set; } = null!;
            public string? Description { get; set; }
            public byte? Priority { get; set; }
            public bool? IsActive { get; set; }
            public bool? IsDelete { get; set; }
            public DateTime? CreatedDate { get; set; }
            public DateTime? ModifiedDate { get; set; }

            public virtual ContactType ContactType { get; set; } = null!;
            public virtual UserDetail User { get; set; } = null!;
        }
    }
}
