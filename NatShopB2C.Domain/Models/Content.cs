using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace NatShopB2C.Domain.Models
{
    public partial class Content
    {
        public Content()
        {
            CmspageContents = new HashSet<CmspageContent>();
        }

        public int Id { get; set; }
        public string? Title { get; set; }
        public string? SubTitle { get; set; }
        public string? Description { get; set; }
        public Guid? ImageId { get; set; }
        public string? ImageCaption { get; set; }
        public string? Align { get; set; }
        public string? DisplaySize { get; set; }
        public int? Height { get; set; }
        public int? Width { get; set; }
        public int? DisplayOrder { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsDelete { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }

        public virtual Image? Image { get; set; }
        public virtual ICollection<CmspageContent> CmspageContents { get; set; }
    }
}
