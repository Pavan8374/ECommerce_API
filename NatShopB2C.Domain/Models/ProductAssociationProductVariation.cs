using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NatShopB2C.Domain.Models
{
    public partial class ProductAssociationProductVariation
    {
        public Guid Id { get; set; }
        public Guid? ProductAssociationId { get; set; }
        public Guid? ProductVariationId { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsDelete { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }

        public virtual ProductAssociation? ProductAssociation { get; set; }
        public virtual ProductVariation? ProductVariation { get; set; }
    }
}
