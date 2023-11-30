using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NatShopB2C.Domain.Models
{
    public partial class ShipmentAgentRegionRate
    {
        public Guid Id { get; set; }
        public Guid? ShipmentAgentRegionId { get; set; }
        public decimal? MinWeight { get; set; }
        public decimal? MaxWeight { get; set; }
        public decimal? ExtraPackingWeight { get; set; }
        public short? UnitId { get; set; }
        public decimal? Rate { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsDelete { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }

        public virtual ShipmentAgentRegion? ShipmentAgentRegion { get; set; }
    }
}
