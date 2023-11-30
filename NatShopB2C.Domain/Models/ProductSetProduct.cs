using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NatShopB2C.Domain.Models
{
    public partial class ProductSetProduct
    {
        public Guid Id { get; set; }
        public long? ProductSetId { get; set; }
        public Guid? ProductId { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsDelete { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }

        public virtual Product? Product { get; set; }
        public virtual ProductSet? ProductSet { get; set; }
    }
}
