using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NatShopB2C.Domain.Models
{
    public partial class ShipmentAgent
    {
        public ShipmentAgent()
        {
            ShipmentAgentCourierServiceProviderCourierServiceProviders = new HashSet<ShipmentAgentCourierServiceProvider>();
            ShipmentAgentCourierServiceProviderShipmentAgents = new HashSet<ShipmentAgentCourierServiceProvider>();
            ShipmentAgentRegions = new HashSet<ShipmentAgentRegion>();
        }

        public int Id { get; set; }
        public int? AddressId { get; set; }
        public short? ShipAgentTypeId { get; set; }
        public string? CompanyName { get; set; }
        public string? Website { get; set; }
        public string? TrackingUrl { get; set; }
        public string? ContactPersonName { get; set; }
        public string? PersonContactNo { get; set; }
        public string? Email { get; set; }
        public short? Priority { get; set; }
        public string? Description { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsDelete { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }

        public virtual Address? Address { get; set; }
        public virtual ShipmentAgentType? ShipAgentType { get; set; }
        public virtual ICollection<ShipmentAgentCourierServiceProvider> ShipmentAgentCourierServiceProviderCourierServiceProviders { get; set; }
        public virtual ICollection<ShipmentAgentCourierServiceProvider> ShipmentAgentCourierServiceProviderShipmentAgents { get; set; }
        public virtual ICollection<ShipmentAgentRegion> ShipmentAgentRegions { get; set; }
    }
}
