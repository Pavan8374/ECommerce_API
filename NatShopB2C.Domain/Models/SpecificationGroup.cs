using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NatShopB2C.Domain.Models
{
    public partial class SpecificationGroup
    {
        public SpecificationGroup()
        {
            CategorySpecificationGroupsSpecifications = new HashSet<CategorySpecificationGroupsSpecification>();
            ProductSpecifications = new HashSet<ProductSpecification>();
            SpecificatonGroupSpecifications = new HashSet<SpecificatonGroupSpecification>();
        }

        public int Id { get; set; }
        public string? SpecificationGroupName { get; set; }
        public string? Description { get; set; }
        public bool? IsActive { get; set; }
        public bool IsDelete { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }

        public virtual ICollection<CategorySpecificationGroupsSpecification> CategorySpecificationGroupsSpecifications { get; set; }
        public virtual ICollection<ProductSpecification> ProductSpecifications { get; set; }
        public virtual ICollection<SpecificatonGroupSpecification> SpecificatonGroupSpecifications { get; set; }
    }
}
