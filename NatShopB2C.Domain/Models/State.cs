using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NatShopB2C.Domain.Models
{
    public partial class State
    {
        public State()
        {
            Addresses = new HashSet<Address>();
            Cities = new HashSet<City>();
            ShipmentAgentRegions = new HashSet<ShipmentAgentRegion>();
            ShipmentOffers = new HashSet<ShipmentOffer>();
        }

        public int Id { get; set; }
        public string? StateCode { get; set; }
        public string StateName { get; set; } = null!;
        public int CountryId { get; set; }
        public string? Description { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsDelete { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }

        public virtual Country Country { get; set; } = null!;
        public virtual ICollection<Address> Addresses { get; set; }
        public virtual ICollection<City> Cities { get; set; }
        public virtual ICollection<ShipmentAgentRegion> ShipmentAgentRegions { get; set; }
        public virtual ICollection<ShipmentOffer> ShipmentOffers { get; set; }
    }
}
