using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NatShopB2C.Domain.Models
{
    public partial class Address
    {
        public Address()
        {
            PersonAccountAddress1s = new HashSet<PersonAccount>();
            PersonAccountAddress2s = new HashSet<PersonAccount>();
            SaleBillingAddresses = new HashSet<Sale>();
            SaleShippingAddresses = new HashSet<Sale>();
            ShipmentAgents = new HashSet<ShipmentAgent>();
            UserAddresses = new HashSet<UserAddress>();
        }

        public int Id { get; set; }
        public int AddressTypeId { get; set; }
        public string? AddressLabelName { get; set; }
        public string? AddressPersonName { get; set; }
        public string AddressLine1 { get; set; }
        public string? AddressLine2 { get; set; }
        public int? CityId { get; set; }
        public int? StateId { get; set; }
        public int? CountryId { get; set; }
        public string? ZipCode { get; set; }
        public bool? IsDefault { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsDelete { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }

        public virtual AddressType AddressType { get; set; } = null!;
        public virtual City? City { get; set; }
        public virtual Country? Country { get; set; }
        public virtual State? State { get; set; }
        public virtual ICollection<PersonAccount> PersonAccountAddress1s { get; set; }
        public virtual ICollection<PersonAccount> PersonAccountAddress2s { get; set; }
        public virtual ICollection<Sale> SaleBillingAddresses { get; set; }
        public virtual ICollection<Sale> SaleShippingAddresses { get; set; }
        public virtual ICollection<ShipmentAgent> ShipmentAgents { get; set; }
        public virtual ICollection<UserAddress> UserAddresses { get; set; }
    }
}
