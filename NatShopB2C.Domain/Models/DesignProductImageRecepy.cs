using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NatShopB2C.Domain.Models
{
    public partial class DesignProductImageRecepy
    {
        public Guid Id { get; set; }
        public long? DesignProductImageId { get; set; }
        public Guid? TextPropertyId { get; set; }
        public Guid? ArtPropertyId { get; set; }
        public short? DisplayPriority { get; set; }
        public string? Description { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsDelete { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }

        public virtual ArtProperty? ArtProperty { get; set; }
        public virtual DesignProductImage? DesignProductImage { get; set; }
        public virtual TextProperty? TextProperty { get; set; }
    }
}
