using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NatShopB2C.Domain.Models
{
    public partial class ArtCategory
    {
        public ArtCategory()
        {
            Arts = new HashSet<Art>();
            InverseParentArtCategory = new HashSet<ArtCategory>();
        }

        public int Id { get; set; }
        public string ArtCategoryName { get; set; } = null!;
        public int? ParentArtCategoryId { get; set; }
        public string? Description { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsDelete { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }

        public virtual ArtCategory? ParentArtCategory { get; set; }
        public virtual ICollection<Art> Arts { get; set; }
        public virtual ICollection<ArtCategory> InverseParentArtCategory { get; set; }
    }
}
