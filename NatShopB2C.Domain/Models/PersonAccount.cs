using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NatShopB2C.Domain.Models
{
    public partial class PersonAccount
    {
        public PersonAccount()
        {
            Purchases = new HashSet<Purchase>();
            Sales = new HashSet<Sale>();
            SalesOrders = new HashSet<SalesOrder>();
        }

        public Guid Id { get; set; }
        public Guid? UserId { get; set; }
        public string Code { get; set; } = null!;
        public bool? EntityType { get; set; }
        public string? CompanyName { get; set; }
        public string? CompanyRegistrationNo { get; set; }
        public string PersonName { get; set; } = null!;
        public string? DisplayName { get; set; }
        public int? Address1Id { get; set; }
        public int? Address2Id { get; set; }
        public string? Website { get; set; }
        public string? Email { get; set; }
        public string? Telephone { get; set; }
        public string? Pan { get; set; }
        public string? Tinnumber { get; set; }
        public string? ServiceTaxNumber { get; set; }
        public string? Fax { get; set; }
        public bool? IsSupplier { get; set; }
        public bool? IsCustomer { get; set; }
        public int? BankAccountId { get; set; }
        public decimal? DebitLimit { get; set; }
        public decimal? CreditLimit { get; set; }
        public string? Description { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsDelete { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }

        public virtual Address? Address1 { get; set; }
        public virtual Address? Address2 { get; set; }
        public virtual UserDetail? User { get; set; }
        public virtual ICollection<Purchase> Purchases { get; set; }
        public virtual ICollection<Sale> Sales { get; set; }
        public virtual ICollection<SalesOrder> SalesOrders { get; set; }
    }
}
