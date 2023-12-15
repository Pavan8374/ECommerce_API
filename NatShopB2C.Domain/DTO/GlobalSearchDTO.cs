using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NatShopB2C.Domain.DTO
{
    public class GlobalSearchDTO
    {
        public long? RowNo { get; set; }
        public int? Ranks { get; set; }
        public string? SortOrder { get; set; }
        public string? Result { get; set; }
        public string? ResultType { get; set; }
        public string? ID { get; set; }
    }
}
