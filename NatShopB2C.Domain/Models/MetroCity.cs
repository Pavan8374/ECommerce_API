using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NatShopB2C.Domain.Models
{
    public partial class MetroCity
    {
        public MetroCity()
        {
            Cities = new HashSet<City>();
            ShipmentOffers = new HashSet<ShipmentOffer>();
        }

        public int Id { get; set; }
        public string? MetroCity1 { get; set; }
        public int? CountryId { get; set; }
        public int? StateId { get; set; }
        public int? NoOfCity { get; set; }
        public string? Description { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsDelete { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }

        public virtual ICollection<City> Cities { get; set; }
        public virtual ICollection<ShipmentOffer> ShipmentOffers { get; set; }
    }
}
