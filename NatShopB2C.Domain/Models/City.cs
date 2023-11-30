using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NatShopB2C.Domain.Models
{
    public partial class City
    {
        public City()
        {
            Addresses = new HashSet<Address>();
            ShipmentAgentRegions = new HashSet<ShipmentAgentRegion>();
            ShipmentOffers = new HashSet<ShipmentOffer>();
        }

        public int Id { get; set; }
        public int? CountryId { get; set; }
        public int? StateId { get; set; }
        public string CityName { get; set; } = null!;
        public string? PostalCode { get; set; }
        public int? MetrocityId { get; set; }
        public string? MetroCity { get; set; }
        public decimal? Latitude { get; set; }
        public decimal? Longitude { get; set; }
        public string? Description { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsDelete { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }

        public virtual Country? Country { get; set; }
        public virtual MetroCity? Metrocity { get; set; }
        public virtual State? State { get; set; }
        public virtual ICollection<Address> Addresses { get; set; }
        public virtual ICollection<ShipmentAgentRegion> ShipmentAgentRegions { get; set; }
        public virtual ICollection<ShipmentOffer> ShipmentOffers { get; set; }
    }
}
