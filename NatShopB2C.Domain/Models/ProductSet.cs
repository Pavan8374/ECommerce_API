using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NatShopB2C.Domain.Models
{
    public partial class ProductSet
    {
        public ProductSet()
        {
            ProductSetProducts = new HashSet<ProductSetProduct>();
            Products = new HashSet<Product>();
        }

        public long Id { get; set; }
        public string? ProductSetName { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsDelete { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }

        public virtual ICollection<ProductSetProduct> ProductSetProducts { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }
}
