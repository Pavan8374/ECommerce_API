using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NatShopB2C.Domain.Models
{
    public partial class ValueType
    {
        public ValueType()
        {
            SystemFlags = new HashSet<SystemFlag>();
            UserFlags = new HashSet<UserFlag>();
        }

        public int Id { get; set; }
        public string ValueTypeName { get; set; } = null!;
        public string? Description { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsDelete { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }

        public virtual ICollection<SystemFlag> SystemFlags { get; set; }
        public virtual ICollection<UserFlag> UserFlags { get; set; }
    }
}
