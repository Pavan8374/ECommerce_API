using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NatShopB2C.Domain.Models
{
    public partial class PaymentMethod
    {
        public PaymentMethod()
        {
            Sales = new HashSet<Sale>();
        }

        public short Id { get; set; }
        public string? PaymentMethodName { get; set; }
        public string? Code { get; set; }
        public string? ImagePath { get; set; }
        public short? PaymentMethodTypeId { get; set; }
        public int? PaymentPluginId { get; set; }
        public string? Description { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsDelete { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }

        public virtual PaymentMethodType? PaymentMethodType { get; set; }
        public virtual PaymentPlugin? PaymentPlugin { get; set; }
        public virtual ICollection<Sale> Sales { get; set; }
    }
}
