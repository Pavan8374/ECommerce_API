using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NatShopB2C.Domain.Models
{
    public partial class ShipmentAgentRegion
    {
        public ShipmentAgentRegion()
        {
            ShipmentAgentRegionRates = new HashSet<ShipmentAgentRegionRate>();
        }

        public Guid Id { get; set; }
        public int? ShipmentAgentId { get; set; }
        public int? CountryId { get; set; }
        public int? StateId { get; set; }
        public int? CityId { get; set; }
        public decimal? ShippingCharges { get; set; }
        public int? MinDeliveryDay { get; set; }
        public int? MaxDeliveryDay { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsDelete { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }

        public virtual City? City { get; set; }
        public virtual Country? Country { get; set; }
        public virtual ShipmentAgent? ShipmentAgent { get; set; }
        public virtual State? State { get; set; }
        public virtual ICollection<ShipmentAgentRegionRate> ShipmentAgentRegionRates { get; set; }
    }
}
