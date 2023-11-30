using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NatShopB2C.Domain.Models
{
    public partial class PaymentPlugin
    {
        public PaymentPlugin()
        {
            PaymentMethods = new HashSet<PaymentMethod>();
        }

        public int Id { get; set; }
        public string PaymentPluginName { get; set; } = null!;
        public string? PluginWebLink { get; set; }
        public string? ConfigurationText { get; set; }
        public string? ImagePath { get; set; }
        public string? Description { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsDelete { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }

        public virtual ICollection<PaymentMethod> PaymentMethods { get; set; }
    }
}
