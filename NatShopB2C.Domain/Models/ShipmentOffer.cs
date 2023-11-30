using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NatShopB2C.Domain.Models
{
    public partial class ShipmentOffer
    {
        public ShipmentOffer()
        {
            ShipmentOfferConditions = new HashSet<ShipmentOfferCondition>();
        }

        public Guid Id { get; set; }
        public string OfferName { get; set; } = null!;
        public int? CountryId { get; set; }
        public int? StateId { get; set; }
        public int? MetrocityId { get; set; }
        public int? CityId { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string? Description { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsDelete { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }

        public virtual City? City { get; set; }
        public virtual Country? Country { get; set; }
        public virtual MetroCity? Metrocity { get; set; }
        public virtual State? State { get; set; }
        public virtual ICollection<ShipmentOfferCondition> ShipmentOfferConditions { get; set; }
    }
}
