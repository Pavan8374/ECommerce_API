using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NatShopB2C.Domain.Models
{
    public partial class ProductVariation
    {
        public ProductVariation()
        {
            Carts = new HashSet<Cart>();
            ProductAssociationProductVariations = new HashSet<ProductAssociationProductVariation>();
            ProductDiscounts = new HashSet<ProductDiscount>();
            ProductReviews = new HashSet<ProductReview>();
            ProductStocks = new HashSet<ProductStock>();
            ProductVariationImages = new HashSet<ProductVariationImage>();
            ProductVariationPrices = new HashSet<ProductVariationPrice>();
            PurchaseDetails = new HashSet<PurchaseDetail>();
            SalesDetails = new HashSet<SalesDetail>();
        }

        public Guid Id { get; set; }
        public Guid ProductId { get; set; }
        public string? Caption { get; set; }
        public decimal? Rating { get; set; }
        public int? Popularity { get; set; }
        public Guid? ProductAssociationId { get; set; }
        public string? ProductVariationList { get; set; }
        public bool? IsVariation { get; set; }
        public bool? IsDefaultProductVariation { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsDelete { get; set; }
        public DateTime? CreateDate { get; set; }
        public DateTime? ModifiedDate { get; set; }

        public virtual Product Product { get; set; } = null!;
        public virtual ProductAssociation? ProductAssociation { get; set; }
        public virtual ProductStatitic? ProductStatitic { get; set; }
        public virtual ICollection<Cart> Carts { get; set; }
        public virtual ICollection<ProductAssociationProductVariation> ProductAssociationProductVariations { get; set; }
        public virtual ICollection<ProductDiscount> ProductDiscounts { get; set; }
        public virtual ICollection<ProductReview> ProductReviews { get; set; }
        public virtual ICollection<ProductStock> ProductStocks { get; set; }
        public virtual ICollection<ProductVariationImage> ProductVariationImages { get; set; }
        public virtual ICollection<ProductVariationPrice> ProductVariationPrices { get; set; }
        public virtual ICollection<PurchaseDetail> PurchaseDetails { get; set; }
        public virtual ICollection<SalesDetail> SalesDetails { get; set; }
    }
}
