using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NatShopB2C.Domain.Models
{
    public partial class Art
    {
        public Art()
        {
            ArtProperties = new HashSet<ArtProperty>();
        }

        public int Id { get; set; }
        public string ArtName { get; set; } = null!;
        public string? ImagePath { get; set; }
        public int? ArtCategoryId { get; set; }
        public string? CreatedByCaption { get; set; }
        public Guid? CreatedBy { get; set; }
        public string? Description { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsDelete { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }

        public virtual ArtCategory? ArtCategory { get; set; }
        public virtual ICollection<ArtProperty> ArtProperties { get; set; }
    }
}
