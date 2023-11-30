using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NatShopB2C.Domain.Models
{
    public partial class Tax
    {
        public Tax()
        {
            ProductTaxes = new HashSet<ProductTax>();
        }

        public int Id { get; set; }
        public string? TaxName { get; set; }
        public decimal? Value { get; set; }
        public string? Description { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsDelete { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }

        public virtual ICollection<ProductTax> ProductTaxes { get; set; }
    }
}
