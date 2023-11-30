using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NatShopB2C.Domain.Models
{
    public partial class ProductSpecification
    {
        public Guid Id { get; set; }
        public Guid ProductId { get; set; }
        public int? SpecificationGroupId { get; set; }
        public int SpecificationId { get; set; }
        public string? Value { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsDelete { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }

        public virtual Product Product { get; set; } = null!;
        public virtual Specification Specification { get; set; } = null!;
        public virtual SpecificationGroup? SpecificationGroup { get; set; }
    }
}
