using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NatShopB2C.Domain.Models
{
    public partial class ProductTax
    {
        public long Id { get; set; }
        public Guid? ProductId { get; set; }
        public int? TaxId { get; set; }

        public virtual Product? Product { get; set; }
        public virtual Tax? Tax { get; set; }
    }
}
