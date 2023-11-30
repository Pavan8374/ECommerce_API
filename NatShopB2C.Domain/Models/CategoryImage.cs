using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace NatShopB2C.Domain.Models
{
    public partial class CategoryImage
    {
        public Guid Id { get; set; }
        public int CategoryId { get; set; }
        public Guid ImageId { get; set; }
        public int? ImageOrderNo { get; set; }
        public bool? IsDefaultImage { get; set; }
        public string? Description { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsDelete { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }

        public virtual Category Category { get; set; } = null!;
        public virtual Image Image { get; set; } = null!;
    }
}
