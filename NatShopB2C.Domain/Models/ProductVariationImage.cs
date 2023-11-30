using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NatShopB2C.Domain.Models
{
    public partial class ProductVariationImage
    {
        public Guid Id { get; set; }
        public Guid ProductVariationId { get; set; }
        public Guid ImageId { get; set; }
        public int? ImageOrderNo { get; set; }
        public bool? IsDefault { get; set; }

        public virtual Image Image { get; set; } = null!;
        public virtual ProductVariation ProductVariation { get; set; } = null!;
    }
}
