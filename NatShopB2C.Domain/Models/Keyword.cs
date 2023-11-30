using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NatShopB2C.Domain.Models
{
    public partial class Keyword
    {
        public long Id { get; set; }
        public string Word { get; set; } = null!;
        public int? Frequency { get; set; }
    }
}
