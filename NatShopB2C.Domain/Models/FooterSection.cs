using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NatShopB2C.Domain.Models
{
    public partial class FooterSection
    {
        public FooterSection()
        {
            FooterSectionLinks = new HashSet<FooterSectionLink>();
        }

        public int Id { get; set; }
        public string FooterSectionName { get; set; } = null!;
        public short? Order { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsDelete { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }

        public virtual ICollection<FooterSectionLink> FooterSectionLinks { get; set; }
    }
}
