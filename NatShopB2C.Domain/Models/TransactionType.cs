using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NatShopB2C.Domain.Models
{
    public partial class TransactionType
    {
        public TransactionType()
        {
            ProductStocks = new HashSet<ProductStock>();
        }

        public short Id { get; set; }
        public string TransactionTypeName { get; set; } = null!;
        public string? TransactionCode { get; set; }
        public string? Description { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsDelete { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }

        public virtual ICollection<ProductStock> ProductStocks { get; set; }
    }
}
