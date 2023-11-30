using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NatShopB2C.Domain.Models
{
    public partial class ArtProperty
    {
        public ArtProperty()
        {
            DesignProductImageRecepies = new HashSet<DesignProductImageRecepy>();
        }

        public Guid Id { get; set; }
        public int ArtId { get; set; }
        public string? TypeOfImage { get; set; }
        public short? Rotation { get; set; }
        public string? RotationPoint { get; set; }
        public string? Color { get; set; }
        public short? Width { get; set; }
        public short? Height { get; set; }
        public short? PositionX { get; set; }
        public short? PositionY { get; set; }
        public short? OriginalPositionX { get; set; }
        public short? OriginalPositionY { get; set; }
        public string? Description { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsDelete { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }

        public virtual Art Art { get; set; } = null!;
        public virtual ICollection<DesignProductImageRecepy> DesignProductImageRecepies { get; set; }
    }
}
