using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NatShopB2C.Domain.Models
{
    public partial class CategoryUsageType
    {
        public long Id { get; set; }
        public int? CategoryId { get; set; }
        public int? UsageTypeId { get; set; }

        public virtual Category? Category { get; set; }
        public virtual UsageType? UsageType { get; set; }
    }
}
