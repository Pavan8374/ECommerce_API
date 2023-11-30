using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace NatShopB2C.Domain.Models
{
    public partial class CmspageContent
    {
        public int Id { get; set; }
        public int CmspageId { get; set; }
        public string? PageHeading { get; set; }
        public int? ContentId { get; set; }
        public string? Description { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsDelete { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }

        public virtual Cmspage Cmspage { get; set; } = null!;
        public virtual Content? Content { get; set; }
    }
}
