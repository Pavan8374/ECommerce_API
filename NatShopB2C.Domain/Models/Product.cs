using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NatShopB2C.Domain.Models
{
    public partial class Product
    {
        public Product()
        {
            ProductDiscounts = new HashSet<ProductDiscount>();
            ProductReviews = new HashSet<ProductReview>();
            ProductSetProducts = new HashSet<ProductSetProduct>();
            ProductSpecifications = new HashSet<ProductSpecification>();
            ProductTaxes = new HashSet<ProductTax>();
            ProductVariationValues = new HashSet<ProductVariationValue>();
            ProductVariations = new HashSet<ProductVariation>();
            Seocontents = new HashSet<Seocontent>();
            TopicMails = new HashSet<TopicMail>();
            UserSubscriptions = new HashSet<UserSubscription>();
        }

        public Guid Id { get; set; }
        public string? ProductCode { get; set; }
        public string ProductName { get; set; } = null!;
        public short? ProductTypeId { get; set; }
        public short? StockTypeId { get; set; }
        public int? ManufactureId { get; set; }
        public long? ProductSetId { get; set; }
        public int? UsageTypeId { get; set; }
        public string? LinkUrl { get; set; }
        public short? UnitId { get; set; }
        public int? Quantity { get; set; }
        public decimal? Price { get; set; }
        public int? MinOrderQuantity { get; set; }
        public int? MaxOrderQuantity { get; set; }
        public short? Skuid { get; set; }
        public decimal? Rating { get; set; }
        [ForeignKey("Brand")]
        public int BrandId { get; set; }
        public int? CategoryId { get; set; }
        public DateTime? LaunchDate { get; set; }
        public int? Popularity { get; set; }
        public bool? IsNew { get; set; }
        public bool? IsCod { get; set; }
        public bool? IsEmi { get; set; }
        public bool? IsTaxable { get; set; }
        public bool? IsSubscribable { get; set; }
        public int? StockQuantity { get; set; }
        public string? Description { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsDelete { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }

        public virtual Brand? Brand { get; set; }
        public virtual Category? Category { get; set; }
        public virtual ProductSet? ProductSet { get; set; }
        public virtual ProductType? ProductType { get; set; }
        public virtual Unit? Sku { get; set; }
        public virtual StockType? StockType { get; set; }
        public virtual Unit? Unit { get; set; }
        public virtual UsageType? UsageType { get; set; }
        public virtual ICollection<ProductDiscount> ProductDiscounts { get; set; }
        public virtual ICollection<ProductReview> ProductReviews { get; set; }
        public virtual ICollection<ProductSetProduct> ProductSetProducts { get; set; }
        public virtual ICollection<ProductSpecification> ProductSpecifications { get; set; }
        public virtual ICollection<ProductTax> ProductTaxes { get; set; }
        public virtual ICollection<ProductVariationValue> ProductVariationValues { get; set; }
        public virtual ICollection<ProductVariation> ProductVariations { get; set; }
        public virtual ICollection<Seocontent> Seocontents { get; set; }
        public virtual ICollection<TopicMail> TopicMails { get; set; }
        public virtual ICollection<UserSubscription> UserSubscriptions { get; set; }
    }
}
