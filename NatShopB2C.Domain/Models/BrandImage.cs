using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace NatShopB2C.Domain.Models
{
    public partial class BrandImage
    {
        public Guid Id { get; set; }
        public int BrandId { get; set; }
        public Guid ImageId { get; set; }
        public bool? IsDefault { get; set; }

        public virtual Brand Brand { get; set; } = null!;
        public virtual Image Image { get; set; } = null!;
    }
}
