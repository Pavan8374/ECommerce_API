using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NatShopB2C.Domain.Models
{
    public partial class SalesStatus
    {
        public SalesStatus()
        {
            Sales = new HashSet<Sale>();
            SalesHistoryTransactions = new HashSet<SalesHistoryTransaction>();
        }

        public short Id { get; set; }
        public string? SaleStatusName { get; set; }
        public string? Description { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsDelete { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }

        public virtual ICollection<Sale> Sales { get; set; }
        public virtual ICollection<SalesHistoryTransaction> SalesHistoryTransactions { get; set; }
    }
}
