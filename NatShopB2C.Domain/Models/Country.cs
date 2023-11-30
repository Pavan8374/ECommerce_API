using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NatShopB2C.Domain.Models
{
    public partial class Country
    {
        public Country()
        {
            Addresses = new HashSet<Address>();
            Cities = new HashSet<City>();
            ShipmentAgentRegions = new HashSet<ShipmentAgentRegion>();
            ShipmentOffers = new HashSet<ShipmentOffer>();
            States = new HashSet<State>();
        }

        public int Id { get; set; }
        public string? Isocode { get; set; }
        public string? Isocode3 { get; set; }
        public string CountryName { get; set; } = null!;
        public string? DialCode { get; set; }
        public int? Population { get; set; }
        public decimal? Area { get; set; }
        public string? Description { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsDelete { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }

        public virtual ICollection<Address> Addresses { get; set; }
        public virtual ICollection<City> Cities { get; set; }
        public virtual ICollection<ShipmentAgentRegion> ShipmentAgentRegions { get; set; }
        public virtual ICollection<ShipmentOffer> ShipmentOffers { get; set; }
        public virtual ICollection<State> States { get; set; }
    }
}
