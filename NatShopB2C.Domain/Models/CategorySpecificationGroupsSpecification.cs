using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NatShopB2C.Domain.Models
{
    public partial class CategorySpecificationGroupsSpecification
    {
        public long Id { get; set; }
        public int? CategoryId { get; set; }
        public int? SpecificationGroupId { get; set; }
        public int? SpecificationId { get; set; }
        public bool? IsFilter { get; set; }
        public int? FilterRank { get; set; }
        public string? Description { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsDelete { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }

        public virtual Category? Category { get; set; }
        public virtual Specification? Specification { get; set; }
        public virtual SpecificationGroup? SpecificationGroup { get; set; }
    }
}
