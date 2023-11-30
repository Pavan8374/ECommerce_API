using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NatShopB2C.Domain.Models
{
    public partial class ProductVariationValue
    {
        public Guid Id { get; set; }
        public Guid ProductId { get; set; }
        public int VariationId { get; set; }
        public string? Value { get; set; }

        public virtual Product Product { get; set; } = null!;
        public virtual Variation Variation { get; set; } = null!;
    }
}
