using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace NatShopB2C.Domain.Models
{
    public partial class Discount
    {
        public Discount()
        {
            DiscountOptioins = new HashSet<DiscountOptioin>();
            ProductDiscounts = new HashSet<ProductDiscount>();
        }

        public int Id { get; set; }
        public string? DiscountName { get; set; }
        public string? Discription { get; set; }
        public Guid? ImageId { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsDelete { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }

        public virtual Image? Image { get; set; }
        public virtual ICollection<DiscountOptioin> DiscountOptioins { get; set; }
        public virtual ICollection<ProductDiscount> ProductDiscounts { get; set; }
    }
}
