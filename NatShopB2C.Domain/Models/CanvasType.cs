using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NatShopB2C.Domain.Models
{
    public partial class CanvasType
    {
        public CanvasType()
        {
            DesignProductImages = new HashSet<DesignProductImage>();
        }

        public byte Id { get; set; }
        public string CanvasTypeName { get; set; } = null!;
        public int? Height { get; set; }
        public int? Width { get; set; }
        public int? PositionX { get; set; }
        public string? PositionY { get; set; }
        public int? ExportX { get; set; }
        public int? ExportY { get; set; }
        public string? Description { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsDelete { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }

        public virtual ICollection<DesignProductImage> DesignProductImages { get; set; }
    }
}
