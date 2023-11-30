using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NatShopB2C.Domain.Models
{
    public partial class DesignProductImage
    {
        public DesignProductImage()
        {
            DesignProductImageRecepies = new HashSet<DesignProductImageRecepy>();
        }

        public long Id { get; set; }
        public long DesignProductId { get; set; }
        public Guid OriginalImageId { get; set; }
        public byte? CanvasTypeId { get; set; }
        public decimal? WorkArea { get; set; }
        public string? Description { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsDelete { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }

        public virtual CanvasType? CanvasType { get; set; }
        public virtual DesignProduct DesignProduct { get; set; } = null!;
        public virtual ICollection<DesignProductImageRecepy> DesignProductImageRecepies { get; set; }
    }
}
