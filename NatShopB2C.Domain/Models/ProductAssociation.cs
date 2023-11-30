using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NatShopB2C.Domain.Models
{
    public partial class ProductAssociation
    {
        public ProductAssociation()
        {
            ProductAssociationProductVariations = new HashSet<ProductAssociationProductVariation>();
            ProductVariations = new HashSet<ProductVariation>();
        }

        public Guid Id { get; set; }
        public string ProductAssociatonName { get; set; } = null!;
        public string? Description { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsDelete { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }

        public virtual ICollection<ProductAssociationProductVariation> ProductAssociationProductVariations { get; set; }
        public virtual ICollection<ProductVariation> ProductVariations { get; set; }
    }
}
