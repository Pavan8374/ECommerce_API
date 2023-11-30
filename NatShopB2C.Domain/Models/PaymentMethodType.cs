using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NatShopB2C.Domain.Models
{
    public partial class PaymentMethodType
    {
        public PaymentMethodType()
        {
            PaymentMethods = new HashSet<PaymentMethod>();
        }

        public short Id { get; set; }
        public string PaymentGatewayName { get; set; } = null!;
        public string? ImagePath { get; set; }
        public string? Description { get; set; }
        public int? DisplayOrder { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsDelete { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }

        public virtual ICollection<PaymentMethod> PaymentMethods { get; set; }
    }
}
