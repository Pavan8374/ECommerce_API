﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NatShopB2C.Domain.Models
{
    public partial class ProductType
    {
        public ProductType()
        {
            Products = new HashSet<Product>();
        }

        public short Id { get; set; }
        public string? ProductTypeName { get; set; }
        public bool? IsShowInCatalog { get; set; }
        public bool? IsAllowSale { get; set; }
        public bool? IsAllowPurchase { get; set; }
        public string? Description { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsDelete { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}
