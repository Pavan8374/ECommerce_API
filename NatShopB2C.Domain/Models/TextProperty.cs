using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NatShopB2C.Domain.Models
{
    public partial class TextProperty
    {
        public TextProperty()
        {
            DesignProductImageRecepies = new HashSet<DesignProductImageRecepy>();
            DesignProductOrderTextPropertyId1Navigations = new HashSet<DesignProductOrder>();
            DesignProductOrderTextPropertyId2Navigations = new HashSet<DesignProductOrder>();
            DesignProductOrderTextPropertyId3Navigations = new HashSet<DesignProductOrder>();
            DesignProductOrderTextPropertyId4Navigations = new HashSet<DesignProductOrder>();
        }

        public Guid Id { get; set; }
        public string? Text { get; set; }
        public string? TypeOfText { get; set; }
        public string? FontName { get; set; }
        public short? FontSize { get; set; }
        public string? FontAlign { get; set; }
        public short? Rotation { get; set; }
        public string? Color { get; set; }
        public short? Height { get; set; }
        public short? Weight { get; set; }
        public short? PositionX { get; set; }
        public short? PositionY { get; set; }
        public short? OriginalPositionX { get; set; }
        public short? OriginalPositionY { get; set; }
        public string? WordArtName { get; set; }
        public string? Description { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsDelete { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }

        public virtual ICollection<DesignProductImageRecepy> DesignProductImageRecepies { get; set; }
        public virtual ICollection<DesignProductOrder> DesignProductOrderTextPropertyId1Navigations { get; set; }
        public virtual ICollection<DesignProductOrder> DesignProductOrderTextPropertyId2Navigations { get; set; }
        public virtual ICollection<DesignProductOrder> DesignProductOrderTextPropertyId3Navigations { get; set; }
        public virtual ICollection<DesignProductOrder> DesignProductOrderTextPropertyId4Navigations { get; set; }
    }
}
