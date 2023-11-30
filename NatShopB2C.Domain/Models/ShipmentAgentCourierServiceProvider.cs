using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NatShopB2C.Domain.Models
{
    public partial class ShipmentAgentCourierServiceProvider
    {
        public int Id { get; set; }
        public int ShipmentAgentId { get; set; }
        public int CourierServiceProviderId { get; set; }
        public bool? IsDefault { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsDelete { get; set; }
        public DateTime? CreatedDat { get; set; }
        public DateTime? ModifiedDate { get; set; }

        public virtual ShipmentAgent CourierServiceProvider { get; set; } = null!;
        public virtual ShipmentAgent ShipmentAgent { get; set; } = null!;
    }
}
