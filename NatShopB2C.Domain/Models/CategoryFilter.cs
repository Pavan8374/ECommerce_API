using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NatShopB2C.Domain.Models
{
    public partial class CategoryFilter
    {
        public int Id { get; set; }
        public int? CategoryId { get; set; }
        public int? FilterId { get; set; }
        public short? Rank { get; set; }
        public bool? IsActive { get; set; }
        public string? Remark { get; set; }

        public virtual Category? Category { get; set; }
        public virtual Filter? Filter { get; set; }
    }
}
