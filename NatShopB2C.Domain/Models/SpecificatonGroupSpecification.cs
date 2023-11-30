using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NatShopB2C.Domain.Models
{
    public partial class SpecificatonGroupSpecification
    {
        public int Id { get; set; }
        public int SpecificationGroupId { get; set; }
        public int SpecificationId { get; set; }

        public virtual Specification Specification { get; set; } = null!;
        public virtual SpecificationGroup SpecificationGroup { get; set; } = null!;
    }
}
