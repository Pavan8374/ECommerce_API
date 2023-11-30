using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NatShopB2C.Domain.Models
{
    public partial class FooterSectionLink
    {
        public int Id { get; set; }
        public int FooterSectionId { get; set; }
        public string FooterSectionLinkCaption { get; set; } = null!;
        public string? Url { get; set; }
        public short? Order { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsDelete { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }

        public virtual FooterSection FooterSection { get; set; } = null!;
    }
}
