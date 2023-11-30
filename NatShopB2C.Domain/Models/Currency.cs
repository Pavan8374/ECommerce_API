using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NatShopB2C.Domain.Models
{
    public partial class Currency
    {
        public Currency()
        {
            Purchases = new HashSet<Purchase>();
            Sales = new HashSet<Sale>();
            SalesOrders = new HashSet<SalesOrder>();
        }

        public int Id { get; set; }
        public string Code { get; set; } = null!;
        public string? CurrencyName { get; set; }
        public string? Icon { get; set; }
        public decimal Value { get; set; }
        public DateTime? AsOnDate { get; set; }
        public bool? IsBaseCurrency { get; set; }
        public bool? IsDefaultCurrency { get; set; }
        public string? Culture { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsDelete { get; set; }
        public DateTime? CreateDate { get; set; }
        public DateTime? ModifiedDate { get; set; }

        public virtual ICollection<Purchase> Purchases { get; set; }
        public virtual ICollection<Sale> Sales { get; set; }
        public virtual ICollection<SalesOrder> SalesOrders { get; set; }
    }
}
