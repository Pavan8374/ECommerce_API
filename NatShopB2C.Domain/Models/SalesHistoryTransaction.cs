using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NatShopB2C.Domain.Models
{
    public partial class SalesHistoryTransaction
    {
        public Guid Id { get; set; }
        public long? SalesId { get; set; }
        public short? SalesStausId { get; set; }
        public bool? IsCustomerNotify { get; set; }
        public DateTime? TransactionDate { get; set; }
        public string? Description { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsDelete { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }

        public virtual SalesStatus? SalesStaus { get; set; }
    }
}
