using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NatShopB2C.Domain.Models
{
    public partial class SystemFlag
    {
        public int Id { get; set; }
        public string SystemFlagName { get; set; } = null!;
        public int FlagGroupId { get; set; }
        public string? Caption { get; set; }
        public string? Description { get; set; }
        public string? ToolTip { get; set; }
        public int ValueTypeId { get; set; }
        public string? Value { get; set; }
        public string? ValueList { get; set; }
        public string? DefaultValue { get; set; }
        public Guid? ModifiedByUserId { get; set; }
        public string? Limit { get; set; }
        public bool? AutoRender { get; set; }
        public int? DisplayOrder { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsDelete { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }

        public virtual FlagGroup FlagGroup { get; set; } = null!;
        public virtual UserDetail? ModifiedByUser { get; set; }
        public virtual ValueType ValueType { get; set; } = null!;
    }
}
