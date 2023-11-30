using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NatShopB2C.Domain.Models
{
    public partial class Cmspage
    {
        public Cmspage()
        {
            CmspageContents = new HashSet<CmspageContent>();
        }

        public int Id { get; set; }
        public string PageName { get; set; } = null!;
        public string? Url { get; set; }
        public string? MetaTitles { get; set; }
        public string? MetaKeywords { get; set; }
        public string? MetaDescription { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsDelete { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }

        public virtual ICollection<CmspageContent> CmspageContents { get; set; }
    }
}
