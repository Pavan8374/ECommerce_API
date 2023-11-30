using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using NatShopB2C.Domain.Models.NatShopB2CAPI.Models;
using NatShopB2C.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ValueType = NatShopB2C.Domain.Models.ValueType;

namespace NatShopB2C.EF.Data
{
    public partial class ApplicationDbContext : IdentityDbContext<IdentityUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public virtual DbSet<ActivityType> ActivityTypes { get; set; } = null!;
        public virtual DbSet<Address> Addresses { get; set; } = null!;
        public virtual DbSet<AddressType> AddressTypes { get; set; } = null!;
        public virtual DbSet<AdminMenu> AdminMenus { get; set; } = null!;
        public virtual DbSet<Advertiesment> Advertiesments { get; set; } = null!;
        public virtual DbSet<Application> Applications { get; set; } = null!;
        public virtual DbSet<Art> Arts { get; set; } = null!;
        public virtual DbSet<ArtCategory> ArtCategories { get; set; } = null!;
        public virtual DbSet<ArtProperty> ArtProperties { get; set; } = null!;
        public virtual DbSet<Brand> Brands { get; set; } = null!;
        public virtual DbSet<BrandImage> BrandImages { get; set; } = null!;
        public virtual DbSet<CanvasType> CanvasTypes { get; set; } = null!;
        public virtual DbSet<Cart> Carts { get; set; } = null!;
        public virtual DbSet<Category> Categories { get; set; } = null!;
        public virtual DbSet<CategoryFilter> CategoryFilters { get; set; } = null!;
        public virtual DbSet<CategoryImage> CategoryImages { get; set; } = null!;
        public virtual DbSet<CategorySpecificationGroupsSpecification> CategorySpecificationGroupsSpecifications { get; set; } = null!;
        public virtual DbSet<CategoryUsageType> CategoryUsageTypes { get; set; } = null!;
        public virtual DbSet<City> Cities { get; set; } = null!;
        public virtual DbSet<Cmspage> Cmspages { get; set; } = null!;
        public virtual DbSet<CmspageContent> CmspageContents { get; set; } = null!;
        public virtual DbSet<ContactType> ContactTypes { get; set; } = null!;
        public virtual DbSet<Content> Contents { get; set; } = null!;
        public virtual DbSet<Country> Countries { get; set; } = null!;
        public virtual DbSet<Currency> Currencies { get; set; } = null!;
        public virtual DbSet<Customer> Customers { get; set; } = null!;
        public virtual DbSet<DayWiseSale> DayWiseSales { get; set; } = null!;
        public virtual DbSet<DesignProduct> DesignProducts { get; set; } = null!;
        public virtual DbSet<DesignProductImage> DesignProductImages { get; set; } = null!;
        public virtual DbSet<DesignProductImageRecepy> DesignProductImageRecepies { get; set; } = null!;
        public virtual DbSet<DesignProductOrder> DesignProductOrders { get; set; } = null!;
        public virtual DbSet<Discount> Discounts { get; set; } = null!;
        public virtual DbSet<DiscountOptioin> DiscountOptioins { get; set; } = null!;
        public virtual DbSet<DiscountType> DiscountTypes { get; set; } = null!;
        public virtual DbSet<DiscountValueType> DiscountValueTypes { get; set; } = null!;
        public virtual DbSet<Document> Documents { get; set; } = null!;
        public virtual DbSet<Feedback> Feedbacks { get; set; } = null!;
        public virtual DbSet<FeedbackAction> FeedbackActions { get; set; } = null!;
        public virtual DbSet<FeedbackInquiryCategory> FeedbackInquiryCategories { get; set; } = null!;
        public virtual DbSet<Filter> Filters { get; set; } = null!;
        public virtual DbSet<FlagGroup> FlagGroups { get; set; } = null!;
        public virtual DbSet<FooterSection> FooterSections { get; set; } = null!;
        public virtual DbSet<FooterSectionLink> FooterSectionLinks { get; set; } = null!;
        public virtual DbSet<HelpfulProductReview> HelpfulProductReviews { get; set; } = null!;
        public virtual DbSet<Image> Images { get; set; } = null!;
        public virtual DbSet<Inquiry> Inquiries { get; set; } = null!;
        public virtual DbSet<InquiryMessage> InquiryMessages { get; set; } = null!;
        public virtual DbSet<Keyword> Keywords { get; set; } = null!;
        public virtual DbSet<Mail> Mails { get; set; } = null!;
        public virtual DbSet<MailAttachment> MailAttachments { get; set; } = null!;
        public virtual DbSet<MailQueue> MailQueues { get; set; } = null!;
        public virtual DbSet<MailResource> MailResources { get; set; } = null!;
        public virtual DbSet<Membership> Memberships { get; set; } = null!;
        public virtual DbSet<Menu> Menus { get; set; } = null!;
        public virtual DbSet<MetroCity> MetroCities { get; set; } = null!;
        public virtual DbSet<Notification> Notifications { get; set; } = null!;
        public virtual DbSet<NotificationType> NotificationTypes { get; set; } = null!;
        public virtual DbSet<OauthProvider> OauthProviders { get; set; } = null!;
        public virtual DbSet<OrderStatus> OrderStatuses { get; set; } = null!;
        public virtual DbSet<Page> Pages { get; set; } = null!;
        public virtual DbSet<PaymentMethod> PaymentMethods { get; set; } = null!;
        public virtual DbSet<PaymentMethodType> PaymentMethodTypes { get; set; } = null!;
        public virtual DbSet<PaymentPlugin> PaymentPlugins { get; set; } = null!;
        public virtual DbSet<PersonAccount> PersonAccounts { get; set; } = null!;
        public virtual DbSet<Price> Prices { get; set; } = null!;
        public virtual DbSet<Product> Products { get; set; } = null!;
        public virtual DbSet<ProductAssociation> ProductAssociations { get; set; } = null!;
        public virtual DbSet<ProductAssociationProductVariation> ProductAssociationProductVariations { get; set; } = null!;
        public virtual DbSet<ProductDiscount> ProductDiscounts { get; set; } = null!;
        public virtual DbSet<ProductPopulationFactor> ProductPopulationFactors { get; set; } = null!;
        public virtual DbSet<ProductReview> ProductReviews { get; set; } = null!;
        public virtual DbSet<ProductSet> ProductSets { get; set; } = null!;
        public virtual DbSet<ProductSetProduct> ProductSetProducts { get; set; } = null!;
        public virtual DbSet<ProductShipment> ProductShipments { get; set; } = null!;
        public virtual DbSet<ProductSpecification> ProductSpecifications { get; set; } = null!;
        public virtual DbSet<ProductStatitic> ProductStatitics { get; set; } = null!;
        public virtual DbSet<ProductStock> ProductStocks { get; set; } = null!;
        public virtual DbSet<ProductTax> ProductTaxs { get; set; } = null!;
        public virtual DbSet<ProductType> ProductTypes { get; set; } = null!;
        public virtual DbSet<ProductVariation> ProductVariations { get; set; } = null!;
        public virtual DbSet<ProductVariationImage> ProductVariationImages { get; set; } = null!;
        public virtual DbSet<ProductVariationPrice> ProductVariationPrices { get; set; } = null!;
        public virtual DbSet<ProductVariationValue> ProductVariationValues { get; set; } = null!;
        public virtual DbSet<Profile> Profiles { get; set; } = null!;
        public virtual DbSet<ProofType> ProofTypes { get; set; } = null!;
        public virtual DbSet<Purchase> Purchases { get; set; } = null!;
        public virtual DbSet<PurchaseDetail> PurchaseDetails { get; set; } = null!;
        public virtual DbSet<PurchaseOrder> PurchaseOrders { get; set; } = null!;
        public virtual DbSet<PurchaseOrderDetail> PurchaseOrderDetails { get; set; } = null!;
        public virtual DbSet<Role> Roles { get; set; } = null!;
        public virtual DbSet<RolePage> RolePages { get; set; } = null!;
        public virtual DbSet<Sale> Sales { get; set; } = null!;
        public virtual DbSet<SalesDetail> SalesDetails { get; set; } = null!;
        public virtual DbSet<SalesHistoryTransaction> SalesHistoryTransactions { get; set; } = null!;
        public virtual DbSet<SalesOrder> SalesOrders { get; set; } = null!;
        public virtual DbSet<SalesOrderDetail> SalesOrderDetails { get; set; } = null!;
        public virtual DbSet<SalesStatus> SalesStatuses { get; set; } = null!;
        public virtual DbSet<SalesType> SalesTypes { get; set; } = null!;
        public virtual DbSet<Seocontent> Seocontents { get; set; } = null!;
        public virtual DbSet<ShipmentAgent> ShipmentAgents { get; set; } = null!;
        public virtual DbSet<ShipmentAgentCourierServiceProvider> ShipmentAgentCourierServiceProviders { get; set; } = null!;
        public virtual DbSet<ShipmentAgentRegion> ShipmentAgentRegions { get; set; } = null!;
        public virtual DbSet<ShipmentAgentRegionRate> ShipmentAgentRegionRates { get; set; } = null!;
        public virtual DbSet<ShipmentAgentType> ShipmentAgentTypes { get; set; } = null!;
        public virtual DbSet<ShipmentOffer> ShipmentOffers { get; set; } = null!;
        public virtual DbSet<ShipmentOfferCondition> ShipmentOfferConditions { get; set; } = null!;
        public virtual DbSet<Sm> Sms { get; set; } = null!;
        public virtual DbSet<Smsqueue> Smsqueues { get; set; } = null!;
        public virtual DbSet<Smstopic> Smstopics { get; set; } = null!;
        public virtual DbSet<Specification> Specifications { get; set; } = null!;
        public virtual DbSet<SpecificationGroup> SpecificationGroups { get; set; } = null!;
        public virtual DbSet<SpecificatonGroupSpecification> SpecificatonGroupSpecifications { get; set; } = null!;
        public virtual DbSet<State> States { get; set; } = null!;
        public virtual DbSet<StockType> StockTypes { get; set; } = null!;
        public virtual DbSet<SystemFlag> SystemFlags { get; set; } = null!;
        public virtual DbSet<Tax> Taxs { get; set; } = null!;
        public virtual DbSet<TextProperty> TextProperties { get; set; } = null!;
        public virtual DbSet<Token> Tokens { get; set; } = null!;
        public virtual DbSet<Topic> Topics { get; set; } = null!;
        public virtual DbSet<TopicMail> TopicMails { get; set; } = null!;
        public virtual DbSet<TransactionType> TransactionTypes { get; set; } = null!;
        public virtual DbSet<Unit> Units { get; set; } = null!;
        public virtual DbSet<UsageType> UsageTypes { get; set; } = null!;
        public virtual DbSet<User> Users { get; set; } = null!;
        public virtual DbSet<UserAddress> UserAddresses { get; set; } = null!;
        public virtual DbSet<UserContact> UserContacts { get; set; } = null!;
        public virtual DbSet<UserDetail> UserDetails { get; set; } = null!;
        public virtual DbSet<UserFlag> UserFlags { get; set; } = null!;
        public virtual DbSet<UserFlagValue> UserFlagValues { get; set; } = null!;
        public virtual DbSet<UserLog> UserLogs { get; set; } = null!;
        public virtual DbSet<UserProperty> UserProperties { get; set; } = null!;
        public virtual DbSet<UserPropertyValue> UserPropertyValues { get; set; } = null!;
        public virtual DbSet<UserSubscription> UserSubscriptions { get; set; } = null!;
        public virtual DbSet<UserType> UserTypes { get; set; } = null!;
        public virtual DbSet<UsersOauthAccount> UsersOauthAccounts { get; set; } = null!;
        public virtual DbSet<UsersOauthDatum> UsersOauthData { get; set; } = null!;
        public virtual DbSet<ValueType> ValueTypes { get; set; } = null!;
        public virtual DbSet<Variation> Variations { get; set; } = null!;
        public virtual DbSet<Warehouse> Warehouses { get; set; } = null!;


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ActivityType>(entity =>
            {
                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.ActivityTypeName).HasMaxLength(200);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(2000);

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.IsDelete).HasDefaultValueSql("((0))");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<Address>(entity =>
            {
                entity.HasIndex(e => e.CityId, "IX_Addresses");

                entity.HasIndex(e => e.StateId, "IX_Addresses_1");

                entity.HasIndex(e => e.CountryId, "IX_Addresses_2");

                entity.HasIndex(e => new { e.StateId, e.CityId, e.CountryId }, "IX_Addresses_3");

                entity.HasIndex(e => e.AddressTypeId, "IX_Addresses_4");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AddressLabelName).HasMaxLength(400);

                entity.Property(e => e.AddressLine1).HasMaxLength(400);

                entity.Property(e => e.AddressLine2).HasMaxLength(400);

                entity.Property(e => e.AddressPersonName).HasMaxLength(200);

                entity.Property(e => e.AddressTypeId).HasColumnName("AddressTypeID");

                entity.Property(e => e.CityId).HasColumnName("CityID");

                entity.Property(e => e.CountryId).HasColumnName("CountryID");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.IsDelete).HasDefaultValueSql("((0))");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.StateId).HasColumnName("StateID");

                entity.Property(e => e.ZipCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.HasOne(d => d.AddressType)
                    .WithMany(p => p.Addresses)
                    .HasForeignKey(d => d.AddressTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Addresses_AddressTypes");

                entity.HasOne(d => d.City)
                    .WithMany(p => p.Addresses)
                    .HasForeignKey(d => d.CityId)
                    .HasConstraintName("FK_Addresses_Cities");

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.Addresses)
                    .HasForeignKey(d => d.CountryId)
                    .HasConstraintName("FK_Addresses_Countries");

                entity.HasOne(d => d.State)
                    .WithMany(p => p.Addresses)
                    .HasForeignKey(d => d.StateId)
                    .HasConstraintName("FK_Addresses_States");
            });

            modelBuilder.Entity<AddressType>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AddressTypeName).HasMaxLength(200);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(2000);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<AdminMenu>(entity =>
            {
                entity.HasIndex(e => e.PageId, "IX_AdminMenus");

                entity.HasIndex(e => e.ParentMenuId, "IX_AdminMenus_1");

                entity.HasIndex(e => e.Id, "IX_AdminMenus_2");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Caption).HasMaxLength(200);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ImagePath).HasMaxLength(500);

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.IsDelete).HasDefaultValueSql("((0))");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.PageId).HasColumnName("PageID");

                entity.Property(e => e.ParentMenuId).HasColumnName("ParentMenuID");

                entity.HasOne(d => d.Page)
                    .WithMany(p => p.AdminMenus)
                    .HasForeignKey(d => d.PageId)
                    .HasConstraintName("FK_AdminMenus_Pages");

                entity.HasOne(d => d.ParentMenu)
                    .WithMany(p => p.InverseParentMenu)
                    .HasForeignKey(d => d.ParentMenuId)
                    .HasConstraintName("FK_AdminMenues_AdminMenues");
            });

            modelBuilder.Entity<Advertiesment>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Description).IsUnicode(false);

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.IsDelete).HasDefaultValueSql("((0))");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.Property(e => e.Title).IsUnicode(false);

                entity.Property(e => e.Url).HasColumnName("URL");
            });

            modelBuilder.Entity<Application>(entity =>
            {
                entity.Property(e => e.ApplicationId).ValueGeneratedNever();

                entity.Property(e => e.ApplicationName).HasMaxLength(235);

                entity.Property(e => e.Description).HasMaxLength(256);
            });

            modelBuilder.Entity<Art>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ArtCategoryId).HasColumnName("ArtCategoryID");

                entity.Property(e => e.ArtName).HasMaxLength(200);

                entity.Property(e => e.CreatedByCaption).HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ImagePath).HasMaxLength(400);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.HasOne(d => d.ArtCategory)
                    .WithMany(p => p.Arts)
                    .HasForeignKey(d => d.ArtCategoryId)
                    .HasConstraintName("FK_Arts_ArtCategories");
            });

            modelBuilder.Entity<ArtCategory>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ArtCategoryName).HasMaxLength(200);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(2000);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.ParentArtCategoryId).HasColumnName("ParentArtCategoryID");

                entity.HasOne(d => d.ParentArtCategory)
                    .WithMany(p => p.InverseParentArtCategory)
                    .HasForeignKey(d => d.ParentArtCategoryId)
                    .HasConstraintName("FK_ArtCategories_ArtCategories");
            });

            modelBuilder.Entity<ArtProperty>(entity =>
            {
                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.ArtId).HasColumnName("ArtID");

                entity.Property(e => e.Color).HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(2000);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.RotationPoint).HasMaxLength(50);

                entity.Property(e => e.TypeOfImage).HasMaxLength(50);

                entity.HasOne(d => d.Art)
                    .WithMany(p => p.ArtProperties)
                    .HasForeignKey(d => d.ArtId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ArtProperties_Arts");
            });

            modelBuilder.Entity<Brand>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.BrandName).HasMaxLength(200);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Description).HasMaxLength(2000);

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Rating).HasColumnType("decimal(3, 2)");
            });

            modelBuilder.Entity<BrandImage>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.BrandId).HasColumnName("BrandID");

                entity.Property(e => e.ImageId).HasColumnName("ImageID");

                entity.HasOne(d => d.Brand)
                    .WithMany(p => p.BrandImages)
                    .HasForeignKey(d => d.BrandId)
                    .HasConstraintName("FK_BrandImages_Brands1");

                entity.HasOne(d => d.Image)
                    .WithMany(p => p.BrandImages)
                    .HasForeignKey(d => d.ImageId)
                    .HasConstraintName("FK_BrandImages_Images1");
            });

            modelBuilder.Entity<CanvasType>(entity =>
            {
                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.CanvasTypeName).HasMaxLength(200);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.PositionY)
                    .HasMaxLength(10)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Cart>(entity =>
            {
                entity.HasIndex(e => e.PriceId, "IX_Carts");

                entity.HasIndex(e => e.ProductDiscountId, "IX_Carts_1");

                entity.HasIndex(e => e.ProductVariationId, "IX_Carts_2");

                entity.HasIndex(e => e.UserId, "IX_Carts_3");

                entity.HasIndex(e => e.Id, "IX_Carts_4");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.IsDelete).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsWishList).HasDefaultValueSql("((0))");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.PriceId).HasColumnName("PriceID");

                entity.Property(e => e.ProductDiscountId).HasColumnName("ProductDiscountID");

                entity.Property(e => e.ProductVariationId).HasColumnName("ProductVariationID");

                entity.Property(e => e.Remark).HasMaxLength(2000);

                entity.Property(e => e.UnitId).HasColumnName("UnitID");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.Price)
                    .WithMany(p => p.Carts)
                    .HasForeignKey(d => d.PriceId)
                    .HasConstraintName("FK_Carts_Prices");

                entity.HasOne(d => d.ProductDiscount)
                    .WithMany(p => p.Carts)
                    .HasForeignKey(d => d.ProductDiscountId)
                    .HasConstraintName("FK_Carts_ProductDiscounts");

                entity.HasOne(d => d.ProductVariation)
                    .WithMany(p => p.Carts)
                    .HasForeignKey(d => d.ProductVariationId)
                    .HasConstraintName("FK_Carts_ProductVariations");

                entity.HasOne(d => d.Unit)
                    .WithMany(p => p.Carts)
                    .HasForeignKey(d => d.UnitId)
                    .HasConstraintName("FK_Carts_Carts");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Carts)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_Carts_UserDetails");
            });

            modelBuilder.Entity<Category>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CategoryName).HasMaxLength(500);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Description).HasMaxLength(2000);

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.IsDelete).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsSubscribable).HasDefaultValueSql("((0))");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ParentCategoryId).HasColumnName("ParentCategoryID");

                entity.HasOne(d => d.ParentCategory)
                    .WithMany(p => p.InverseParentCategory)
                    .HasForeignKey(d => d.ParentCategoryId)
                    .HasConstraintName("FK_Categories_Categories");
            });

            modelBuilder.Entity<CategoryFilter>(entity =>
            {
                entity.HasIndex(e => e.CategoryId, "IX_CategoryFilters");

                entity.HasIndex(e => e.FilterId, "IX_CategoryFilters_1");

                entity.HasIndex(e => new { e.FilterId, e.CategoryId }, "IX_CategoryFilters_2");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CategoryId).HasColumnName("CategoryID");

                entity.Property(e => e.FilterId).HasColumnName("FilterID");

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.CategoryFilters)
                    .HasForeignKey(d => d.CategoryId)
                    .HasConstraintName("FK_CategoryFilters_Categories");

                entity.HasOne(d => d.Filter)
                    .WithMany(p => p.CategoryFilters)
                    .HasForeignKey(d => d.FilterId)
                    .HasConstraintName("FK_CategoryFilters_Filters");
            });

            modelBuilder.Entity<CategoryImage>(entity =>
            {
                entity.HasIndex(e => e.ImageId, "IX_CategoryImages");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.CategoryId).HasColumnName("CategoryID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(2000);

                entity.Property(e => e.ImageId).HasColumnName("ImageID");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.CategoryImages)
                    .HasForeignKey(d => d.CategoryId)
                    .HasConstraintName("FK_CategoryImages_Categories");

                entity.HasOne(d => d.Image)
                    .WithMany(p => p.CategoryImages)
                    .HasForeignKey(d => d.ImageId)
                    .HasConstraintName("FK_CategoryImages_Images");
            });

            modelBuilder.Entity<CategorySpecificationGroupsSpecification>(entity =>
            {
                entity.HasIndex(e => e.SpecificationGroupId, "IX_CategorySpecificationGroupsSpecifications");

                entity.HasIndex(e => e.SpecificationId, "IX_CategorySpecificationGroupsSpecifications_1");

                entity.HasIndex(e => e.CategoryId, "IX_CategorySpecificationGroupsSpecifications_2");

                entity.HasIndex(e => new { e.SpecificationId, e.CategoryId, e.SpecificationGroupId }, "IX_CategorySpecificationGroupsSpecifications_3");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CategoryId).HasColumnName("CategoryID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(2000);

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.IsDelete).HasDefaultValueSql("((0))");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.SpecificationGroupId).HasColumnName("SpecificationGroupID");

                entity.Property(e => e.SpecificationId).HasColumnName("SpecificationID");

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.CategorySpecificationGroupsSpecifications)
                    .HasForeignKey(d => d.CategoryId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_CategorySpecificaions_CategorySpecificaions");

                entity.HasOne(d => d.SpecificationGroup)
                    .WithMany(p => p.CategorySpecificationGroupsSpecifications)
                    .HasForeignKey(d => d.SpecificationGroupId)
                    .HasConstraintName("FK_CategorySpecificaions_SpecificationGroups");

                entity.HasOne(d => d.Specification)
                    .WithMany(p => p.CategorySpecificationGroupsSpecifications)
                    .HasForeignKey(d => d.SpecificationId)
                    .HasConstraintName("FK_CategorySpecificaionGroups_Specifications");
            });

            modelBuilder.Entity<CategoryUsageType>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CategoryId).HasColumnName("CategoryID");

                entity.Property(e => e.UsageTypeId).HasColumnName("UsageTypeID");

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.CategoryUsageTypes)
                    .HasForeignKey(d => d.CategoryId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_CategoryUsageTypes_Categories");

                entity.HasOne(d => d.UsageType)
                    .WithMany(p => p.CategoryUsageTypes)
                    .HasForeignKey(d => d.UsageTypeId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_CategoryUsageTypes_UsageTypes");
            });

            modelBuilder.Entity<City>(entity =>
            {
                entity.HasIndex(e => e.CountryId, "IX_Cities");

                entity.HasIndex(e => e.MetrocityId, "IX_Cities_1");

                entity.HasIndex(e => e.StateId, "IX_Cities_2");

                entity.HasIndex(e => new { e.MetrocityId, e.CountryId, e.StateId }, "IX_Cities_3");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CityName).HasMaxLength(500);

                entity.Property(e => e.CountryId).HasColumnName("CountryID");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Description).HasMaxLength(2000);

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.IsDelete).HasDefaultValueSql("((0))");

                entity.Property(e => e.Latitude).HasColumnType("decimal(9, 6)");

                entity.Property(e => e.Longitude).HasColumnType("decimal(9, 6)");

                entity.Property(e => e.MetroCity).HasMaxLength(500);

                entity.Property(e => e.MetrocityId).HasColumnName("MetrocityID");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.PostalCode).HasMaxLength(20);

                entity.Property(e => e.StateId).HasColumnName("StateID");

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.Cities)
                    .HasForeignKey(d => d.CountryId)
                    .HasConstraintName("FK_Cities_Countries");

                entity.HasOne(d => d.Metrocity)
                    .WithMany(p => p.Cities)
                    .HasForeignKey(d => d.MetrocityId)
                    .HasConstraintName("FK_Cities_MetroCities");

                entity.HasOne(d => d.State)
                    .WithMany(p => p.Cities)
                    .HasForeignKey(d => d.StateId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Cities_States");
            });

            modelBuilder.Entity<Cmspage>(entity =>
            {
                entity.ToTable("CMSPages");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.MetaDescription).HasMaxLength(500);

                entity.Property(e => e.MetaKeywords).HasMaxLength(500);

                entity.Property(e => e.MetaTitles).HasMaxLength(200);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.PageName).HasMaxLength(200);

                entity.Property(e => e.Url)
                    .HasMaxLength(500)
                    .HasColumnName("URL");
            });

            modelBuilder.Entity<CmspageContent>(entity =>
            {
                entity.ToTable("CMSPageContents");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CmspageId).HasColumnName("CMSPageID");

                entity.Property(e => e.ContentId).HasColumnName("ContentID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.IsDelete).HasDefaultValueSql("((0))");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.HasOne(d => d.Cmspage)
                    .WithMany(p => p.CmspageContents)
                    .HasForeignKey(d => d.CmspageId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CMSPageContents_CMSPages");

                entity.HasOne(d => d.Content)
                    .WithMany(p => p.CmspageContents)
                    .HasForeignKey(d => d.ContentId)
                    .HasConstraintName("FK_PageContents_Contents");
            });

            modelBuilder.Entity<ContactType>(entity =>
            {
                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.ContactTypeName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(2000);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<Content>(entity =>
            {
                entity.HasIndex(e => e.ImageId, "IX_Contents");

                entity.HasIndex(e => e.Id, "IX_Contents_1");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Align).HasMaxLength(200);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DisplaySize).HasMaxLength(200);

                entity.Property(e => e.ImageCaption).HasMaxLength(200);

                entity.Property(e => e.ImageId).HasColumnName("ImageID");

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.IsDelete).HasDefaultValueSql("((0))");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.HasOne(d => d.Image)
                    .WithMany(p => p.Contents)
                    .HasForeignKey(d => d.ImageId)
                    .HasConstraintName("FK_Contents_Images");
            });

            modelBuilder.Entity<Country>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Area).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.CountryName).HasMaxLength(200);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Description).HasMaxLength(2000);

                entity.Property(e => e.DialCode).HasMaxLength(5);

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.IsDelete).HasDefaultValueSql("((0))");

                entity.Property(e => e.Isocode)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("ISOCode")
                    .IsFixedLength();

                entity.Property(e => e.Isocode3)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("ISOCode3")
                    .IsFixedLength();

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<Currency>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AsOnDate).HasColumnType("datetime");

                entity.Property(e => e.Code)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.Culture).HasMaxLength(200);

                entity.Property(e => e.CurrencyName).HasMaxLength(200);

                entity.Property(e => e.Icon).HasMaxLength(200);

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.IsDelete).HasDefaultValueSql("((0))");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Value).HasColumnType("decimal(15, 5)");
            });

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Browser).IsUnicode(false);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Email).IsUnicode(false);

                entity.Property(e => e.IpAddress).IsUnicode(false);

                entity.Property(e => e.MobileNumber).IsUnicode(false);

                entity.Property(e => e.Name).IsUnicode(false);
            });

            modelBuilder.Entity<DayWiseSale>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Amount).HasColumnType("decimal(15, 3)");

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .HasColumnName("name");

                entity.Property(e => e.Orders).HasColumnType("decimal(15, 3)");

                entity.Property(e => e.StartDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<DesignProduct>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Amount).HasColumnType("decimal(15, 3)");

                entity.Property(e => e.CommissionPercent).HasColumnType("decimal(6, 3)");

                entity.Property(e => e.CommitionFlat).HasColumnType("decimal(15, 3)");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DesignProductName).HasMaxLength(200);

                entity.Property(e => e.DesignRate).HasColumnType("decimal(15, 3)");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Price).HasColumnType("decimal(15, 3)");

                entity.Property(e => e.ProductVariationId).HasColumnName("ProductVariationID");

                entity.Property(e => e.PublishImagePath).HasMaxLength(400);

                entity.Property(e => e.PublishProductVariationId).HasColumnName("PublishProductVariationID");

                entity.Property(e => e.Size).HasMaxLength(200);

                entity.Property(e => e.TotalWorkArea).HasColumnType("decimal(15, 3)");
            });

            modelBuilder.Entity<DesignProductImage>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CanvasTypeId).HasColumnName("CanvasTypeID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DesignProductId).HasColumnName("DesignProductID");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.OriginalImageId).HasColumnName("OriginalImageID");

                entity.Property(e => e.WorkArea).HasColumnType("decimal(15, 3)");

                entity.HasOne(d => d.CanvasType)
                    .WithMany(p => p.DesignProductImages)
                    .HasForeignKey(d => d.CanvasTypeId)
                    .HasConstraintName("FK_DesignProductImages_CanvasTypes");

                entity.HasOne(d => d.DesignProduct)
                    .WithMany(p => p.DesignProductImages)
                    .HasForeignKey(d => d.DesignProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DesignProductImages_DesignProducts");
            });

            modelBuilder.Entity<DesignProductImageRecepy>(entity =>
            {
                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.ArtPropertyId).HasColumnName("ArtPropertyID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(500);

                entity.Property(e => e.DesignProductImageId).HasColumnName("DesignProductImageID");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.TextPropertyId).HasColumnName("TextPropertyID");

                entity.HasOne(d => d.ArtProperty)
                    .WithMany(p => p.DesignProductImageRecepies)
                    .HasForeignKey(d => d.ArtPropertyId)
                    .HasConstraintName("FK_DesignProductImageRecepies_ArtProperties");

                entity.HasOne(d => d.DesignProductImage)
                    .WithMany(p => p.DesignProductImageRecepies)
                    .HasForeignKey(d => d.DesignProductImageId)
                    .HasConstraintName("FK_DesignProductImageRecepies_DesignProductImages");

                entity.HasOne(d => d.TextProperty)
                    .WithMany(p => p.DesignProductImageRecepies)
                    .HasForeignKey(d => d.TextPropertyId)
                    .HasConstraintName("FK_DesignProductImageRecepies_DesignProductImageRecepies");
            });

            modelBuilder.Entity<DesignProductOrder>(entity =>
            {
                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DesignProductId).HasColumnName("DesignProductID");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Price).HasColumnType("decimal(15, 3)");

                entity.Property(e => e.Quantity).HasColumnType("decimal(15, 3)");

                entity.Property(e => e.SizeCode).HasMaxLength(50);

                entity.Property(e => e.TextPropertyId1).HasColumnName("TextPropertyID1");

                entity.Property(e => e.TextPropertyId2).HasColumnName("TextPropertyID2");

                entity.Property(e => e.TextPropertyId3).HasColumnName("TextPropertyID3");

                entity.Property(e => e.TextPropertyId4).HasColumnName("TextPropertyID4");

                entity.Property(e => e.TransactionDate).HasColumnType("datetime");

                entity.Property(e => e.UnitId).HasColumnName("UnitID");

                entity.HasOne(d => d.DesignProduct)
                    .WithMany(p => p.DesignProductOrders)
                    .HasForeignKey(d => d.DesignProductId)
                    .HasConstraintName("FK_DesignProductOrders_DesignProductOrders");

                entity.HasOne(d => d.TextPropertyId1Navigation)
                    .WithMany(p => p.DesignProductOrderTextPropertyId1Navigations)
                    .HasForeignKey(d => d.TextPropertyId1)
                    .HasConstraintName("FK_DesignProductOrders_TextProperties");

                entity.HasOne(d => d.TextPropertyId2Navigation)
                    .WithMany(p => p.DesignProductOrderTextPropertyId2Navigations)
                    .HasForeignKey(d => d.TextPropertyId2)
                    .HasConstraintName("FK_DesignProductOrders_TextProperties1");

                entity.HasOne(d => d.TextPropertyId3Navigation)
                    .WithMany(p => p.DesignProductOrderTextPropertyId3Navigations)
                    .HasForeignKey(d => d.TextPropertyId3)
                    .HasConstraintName("FK_DesignProductOrders_TextProperties2");

                entity.HasOne(d => d.TextPropertyId4Navigation)
                    .WithMany(p => p.DesignProductOrderTextPropertyId4Navigations)
                    .HasForeignKey(d => d.TextPropertyId4)
                    .HasConstraintName("FK_DesignProductOrders_TextProperties3");
            });

            modelBuilder.Entity<Discount>(entity =>
            {
                entity.HasIndex(e => e.ImageId, "IX_Discounts");

                entity.HasIndex(e => new { e.StartDate, e.EndDate }, "IX_Discounts_1");

                entity.HasIndex(e => e.StartDate, "IX_Discounts_2");

                entity.HasIndex(e => e.EndDate, "IX_Discounts_3");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DiscountName).HasMaxLength(500);

                entity.Property(e => e.Discription).HasMaxLength(2000);

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.ImageId).HasColumnName("ImageID");

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.IsDelete).HasDefaultValueSql("((0))");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.HasOne(d => d.Image)
                    .WithMany(p => p.Discounts)
                    .HasForeignKey(d => d.ImageId)
                    .HasConstraintName("FK_Discounts_Images");
            });

            modelBuilder.Entity<DiscountOptioin>(entity =>
            {
                entity.HasIndex(e => e.DiscountId, "IX_DiscountOptioins");

                entity.HasIndex(e => e.DiscountValueTypeId, "IX_DiscountOptioins_1");

                entity.HasIndex(e => e.Id, "IX_DiscountOptioins_2");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.BreakPointCode)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Caption).HasMaxLength(200);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DiscountId).HasColumnName("DiscountID");

                entity.Property(e => e.DiscountValue).HasColumnType("decimal(15, 3)");

                entity.Property(e => e.DiscountValueTypeId).HasColumnName("DiscountValueTypeID");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Note).HasMaxLength(2000);

                entity.HasOne(d => d.Discount)
                    .WithMany(p => p.DiscountOptioins)
                    .HasForeignKey(d => d.DiscountId)
                    .HasConstraintName("FK_DiscountOptioins_Discounts");

                entity.HasOne(d => d.DiscountValueType)
                    .WithMany(p => p.DiscountOptioins)
                    .HasForeignKey(d => d.DiscountValueTypeId)
                    .HasConstraintName("FK_DiscountOptioins_DiscountValueTypes");
            });

            modelBuilder.Entity<DiscountType>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(2000);

                entity.Property(e => e.DiscountTypeName).HasMaxLength(200);

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.IsDelete).HasDefaultValueSql("((0))");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<DiscountValueType>(entity =>
            {
                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Description).HasMaxLength(2000);

                entity.Property(e => e.DiscountValueTypeName).HasMaxLength(200);

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.IsDelete).HasDefaultValueSql("((0))");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<Document>(entity =>
            {
                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DocumentName).HasMaxLength(500);

                entity.Property(e => e.FilePath).HasMaxLength(500);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<Feedback>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ActionDate).HasColumnType("datetime");

                entity.Property(e => e.ActionId).HasColumnName("ActionID");

                entity.Property(e => e.ContactNo).HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Email).HasMaxLength(200);

                entity.Property(e => e.FeedbackCategoryId).HasColumnName("FeedbackCategoryID");

                entity.Property(e => e.Ipaddress)
                    .HasMaxLength(50)
                    .HasColumnName("IPAddress");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.UserName).HasMaxLength(200);

                entity.HasOne(d => d.ActionByNavigation)
                    .WithMany(p => p.Feedbacks)
                    .HasForeignKey(d => d.ActionBy)
                    .HasConstraintName("FK_Feedbacks_UserDetails");

                entity.HasOne(d => d.Action)
                    .WithMany(p => p.Feedbacks)
                    .HasForeignKey(d => d.ActionId)
                    .HasConstraintName("FK_Feedbacks_FeedbackActions");

                entity.HasOne(d => d.FeedbackCategory)
                    .WithMany(p => p.Feedbacks)
                    .HasForeignKey(d => d.FeedbackCategoryId)
                    .HasConstraintName("FK_Feedbacks_FeedbackInquiryCategories");
            });

            modelBuilder.Entity<FeedbackAction>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ActionName).HasMaxLength(200);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.IsDelete).HasDefaultValueSql("((0))");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<FeedbackInquiryCategory>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.IsDelete).HasDefaultValueSql("((0))");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<Filter>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Caption).HasMaxLength(200);

                entity.Property(e => e.ControlType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.FilterName).HasMaxLength(200);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<FlagGroup>(entity =>
            {
                entity.HasIndex(e => e.ParentFlagGroupId, "IX_FlagGroups");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(2000);

                entity.Property(e => e.FlagGroupName).HasMaxLength(500);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.ParentFlagGroupId).HasColumnName("ParentFlagGroupID");

                entity.HasOne(d => d.ParentFlagGroup)
                    .WithMany(p => p.InverseParentFlagGroup)
                    .HasForeignKey(d => d.ParentFlagGroupId)
                    .HasConstraintName("FK_FlagGroups_FlagGroups");
            });

            modelBuilder.Entity<FooterSection>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.FooterSectionName).HasMaxLength(200);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<FooterSectionLink>(entity =>
            {
                entity.HasIndex(e => e.FooterSectionId, "IX_FooterSectionLinks");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.FooterSectionId).HasColumnName("FooterSectionID");

                entity.Property(e => e.FooterSectionLinkCaption).HasMaxLength(200);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Url)
                    .HasMaxLength(200)
                    .HasColumnName("URL");

                entity.HasOne(d => d.FooterSection)
                    .WithMany(p => p.FooterSectionLinks)
                    .HasForeignKey(d => d.FooterSectionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_FooterSectionLinks_FooterSections");
            });

            modelBuilder.Entity<HelpfulProductReview>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ProductReviewId).HasColumnName("ProductReviewID");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.ProductReview)
                    .WithMany(p => p.HelpfulProductReviews)
                    .HasForeignKey(d => d.ProductReviewId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_HelpfulProductReviews_ProductReviews");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.HelpfulProductReviews)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_HelpfulProductReviews_UserDetails");
            });

            modelBuilder.Entity<Image>(entity =>
            {
                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Alt).HasMaxLength(500);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Description).HasMaxLength(2000);

                entity.Property(e => e.ImagePath)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<Inquiry>(entity =>
            {
                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.ContactNo).HasMaxLength(50);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Email).HasMaxLength(200);

                entity.Property(e => e.InquiryCategoryId).HasColumnName("InquiryCategoryID");

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.IsDelete).HasDefaultValueSql("((0))");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UserName).HasMaxLength(200);

                entity.HasOne(d => d.InquiryCategory)
                    .WithMany(p => p.Inquiries)
                    .HasForeignKey(d => d.InquiryCategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Inquiries_FeedbackInquiryCategories");

                entity.HasOne(d => d.ResponderUser)
                    .WithMany(p => p.InquiryResponderUsers)
                    .HasForeignKey(d => d.ResponderUserId)
                    .HasConstraintName("FK_Inquiries_UserDetails1");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.InquiryUsers)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_Inquiries_UserDetails");
            });

            modelBuilder.Entity<InquiryMessage>(entity =>
            {
                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ImageId).HasColumnName("ImageID");

                entity.Property(e => e.InquiryId).HasColumnName("InquiryID");

                entity.Property(e => e.Ipaddress)
                    .HasMaxLength(50)
                    .HasColumnName("IPAddress");

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.IsDelete).HasDefaultValueSql("((0))");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.UserAgent).HasMaxLength(500);

                entity.HasOne(d => d.Image)
                    .WithMany(p => p.InquiryMessages)
                    .HasForeignKey(d => d.ImageId)
                    .HasConstraintName("FK_InquiryMessages_Inquiries");

                entity.HasOne(d => d.Inquiry)
                    .WithMany(p => p.InquiryMessages)
                    .HasForeignKey(d => d.InquiryId)
                    .HasConstraintName("FK_InquiryMessages_Inquiries1");
            });

            modelBuilder.Entity<Keyword>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Frequency).HasColumnName("frequency");

                entity.Property(e => e.Word).HasMaxLength(100);
            });

            modelBuilder.Entity<Mail>(entity =>
            {
                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ExpireDate).HasColumnType("datetime");

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.IsHtml).HasColumnName("IsHTML");

                entity.Property(e => e.MailName).HasMaxLength(500);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.Property(e => e.Subject).HasMaxLength(2000);
            });

            modelBuilder.Entity<MailAttachment>(entity =>
            {
                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DocumentId).HasColumnName("DocumentID");

                entity.Property(e => e.MailId).HasColumnName("MailID");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.HasOne(d => d.Document)
                    .WithMany(p => p.MailAttachments)
                    .HasForeignKey(d => d.DocumentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MailAttachments_Documents");

                entity.HasOne(d => d.Mail)
                    .WithMany(p => p.MailAttachments)
                    .HasForeignKey(d => d.MailId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MailAttachments_Mails");
            });

            modelBuilder.Entity<MailQueue>(entity =>
            {
                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Email).HasMaxLength(200);

                entity.Property(e => e.MailId).HasColumnName("MailID");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.SendDate).HasColumnType("datetime");

                entity.HasOne(d => d.Mail)
                    .WithMany(p => p.MailQueues)
                    .HasForeignKey(d => d.MailId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MailQueus_Mails");
            });

            modelBuilder.Entity<MailResource>(entity =>
            {
                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.ImageId).HasColumnName("ImageID");

                entity.Property(e => e.MailId).HasColumnName("MailID");

                entity.HasOne(d => d.Image)
                    .WithMany(p => p.MailResources)
                    .HasForeignKey(d => d.ImageId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MailResources_Images");

                entity.HasOne(d => d.Mail)
                    .WithMany(p => p.MailResources)
                    .HasForeignKey(d => d.MailId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MailResources_Mails");
            });

            modelBuilder.Entity<Membership>(entity =>
            {
                entity.HasKey(e => e.UserId)
                    .HasName("PK__Membersh__1788CC4C31FFB006");

                entity.Property(e => e.UserId).ValueGeneratedNever();

                entity.Property(e => e.Comment).HasMaxLength(256);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.Email).HasMaxLength(256);

                entity.Property(e => e.FailedPasswordAnswerAttemptWindowsStart).HasColumnType("datetime");

                entity.Property(e => e.FailedPasswordAttemptWindowStart).HasColumnType("datetime");

                entity.Property(e => e.LastLockoutDate).HasColumnType("datetime");

                entity.Property(e => e.LastLoginDate).HasColumnType("datetime");

                entity.Property(e => e.LastPasswordChangedDate).HasColumnType("datetime");

                entity.Property(e => e.Password).HasMaxLength(128);

                entity.Property(e => e.PasswordAnswer).HasMaxLength(128);

                entity.Property(e => e.PasswordQuestion).HasMaxLength(256);

                entity.Property(e => e.PasswordSalt).HasMaxLength(128);

                entity.HasOne(d => d.Application)
                    .WithMany(p => p.Memberships)
                    .HasForeignKey(d => d.ApplicationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("MembershipApplication");

                entity.HasOne(d => d.User)
                    .WithOne(p => p.Membership)
                    .HasForeignKey<Membership>(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("MembershipUser");
            });

            modelBuilder.Entity<Menu>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Caption).HasMaxLength(200);

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ImagePath).HasMaxLength(200);

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.IsDelete).HasDefaultValueSql("((0))");

                entity.Property(e => e.Key).HasMaxLength(50);

                entity.Property(e => e.MenuName).HasMaxLength(200);

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ParentMenuId).HasColumnName("ParentMenuID");

                entity.Property(e => e.Type)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Url)
                    .HasMaxLength(1000)
                    .HasColumnName("URL");
            });

            modelBuilder.Entity<MetroCity>(entity =>
            {
                entity.HasIndex(e => e.CountryId, "IX_MetroCities");

                entity.HasIndex(e => e.StateId, "IX_MetroCities_1");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CountryId).HasColumnName("CountryID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(2000);

                entity.Property(e => e.MetroCity1)
                    .HasMaxLength(500)
                    .HasColumnName("MetroCity");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.StateId).HasColumnName("StateID");
            });

            modelBuilder.Entity<Notification>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ImagePath1).HasMaxLength(200);

                entity.Property(e => e.ImagePath2).HasMaxLength(200);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.NotificationTypeId).HasColumnName("NotificationTypeID");

                entity.Property(e => e.RedirectUrl)
                    .HasMaxLength(200)
                    .HasColumnName("RedirectURL");

                entity.Property(e => e.RefId)
                    .HasMaxLength(100)
                    .HasColumnName("RefID");

                entity.HasOne(d => d.NotificationType)
                    .WithMany(p => p.Notifications)
                    .HasForeignKey(d => d.NotificationTypeId)
                    .HasConstraintName("FK_Notifications_NotificationTypes");
            });

            modelBuilder.Entity<NotificationType>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ImagePath).HasMaxLength(200);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.NotificationTypeName).HasMaxLength(200);

                entity.Property(e => e.RedirectUrl)
                    .HasMaxLength(200)
                    .HasColumnName("RedirectURL");
            });

            modelBuilder.Entity<OauthProvider>(entity =>
            {
                entity.ToTable("OAuthProviders");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ApplicationId)
                    .HasMaxLength(100)
                    .HasColumnName("ApplicationID");

                entity.Property(e => e.CallbackUrl)
                    .HasMaxLength(500)
                    .HasColumnName("CallbackURL");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.IsDelete).HasDefaultValueSql("((0))");

                entity.Property(e => e.LoginUrl)
                    .HasMaxLength(500)
                    .HasColumnName("LoginURL");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.ProviderIcon)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ProviderName).HasMaxLength(20);

                entity.Property(e => e.SecretKey).HasMaxLength(100);

                entity.Property(e => e.TokenUrl)
                    .HasMaxLength(500)
                    .HasColumnName("TokenURL");

                entity.Property(e => e.UserInfoUrl)
                    .HasMaxLength(500)
                    .HasColumnName("UserInfoURL");
            });

            modelBuilder.Entity<OrderStatus>(entity =>
            {
                entity.ToTable("OrderStatus");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(2000);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.OrderStatus1)
                    .HasMaxLength(100)
                    .HasColumnName("OrderStatus");
            });

            modelBuilder.Entity<Page>(entity =>
            {
                entity.HasIndex(e => e.Id, "IX_Pages");

                entity.HasIndex(e => e.PageRelativeName, "IX_Pages_1");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AliasName).HasMaxLength(400);

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.IsDelete).HasDefaultValueSql("((0))");

                entity.Property(e => e.PageRelativeName).HasMaxLength(400);
            });

            modelBuilder.Entity<PaymentMethod>(entity =>
            {
                entity.HasIndex(e => e.PaymentPluginId, "IX_PaymentMethods");

                entity.HasIndex(e => e.PaymentMethodTypeId, "IX_PaymentMethods_1");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Code).HasMaxLength(50);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Description).HasMaxLength(2000);

                entity.Property(e => e.ImagePath)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.PaymentMethodName)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.PaymentMethodTypeId).HasColumnName("PaymentMethodTypeID");

                entity.Property(e => e.PaymentPluginId).HasColumnName("PaymentPluginID");

                entity.HasOne(d => d.PaymentMethodType)
                    .WithMany(p => p.PaymentMethods)
                    .HasForeignKey(d => d.PaymentMethodTypeId)
                    .HasConstraintName("FK_PaymentMethods_PaymentGateways");

                entity.HasOne(d => d.PaymentPlugin)
                    .WithMany(p => p.PaymentMethods)
                    .HasForeignKey(d => d.PaymentPluginId)
                    .HasConstraintName("FK_PaymentMethods_PaymentPlugins");
            });

            modelBuilder.Entity<PaymentMethodType>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(2000);

                entity.Property(e => e.ImagePath).HasMaxLength(200);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.PaymentGatewayName).HasMaxLength(200);
            });

            modelBuilder.Entity<PaymentPlugin>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ImagePath)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.PaymentPluginName).HasMaxLength(200);

                entity.Property(e => e.PluginWebLink).HasMaxLength(500);
            });

            modelBuilder.Entity<PersonAccount>(entity =>
            {
                entity.HasIndex(e => e.UserId, "IX_PersonAccounts");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Address1Id).HasColumnName("Address1ID");

                entity.Property(e => e.Address2Id).HasColumnName("Address2ID");

                entity.Property(e => e.BankAccountId).HasColumnName("BankAccountID");

                entity.Property(e => e.Code).HasMaxLength(50);

                entity.Property(e => e.CompanyName).HasMaxLength(200);

                entity.Property(e => e.CompanyRegistrationNo).HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.CreditLimit).HasColumnType("decimal(15, 3)");

                entity.Property(e => e.DebitLimit).HasColumnType("decimal(15, 3)");

                entity.Property(e => e.DisplayName).HasMaxLength(200);

                entity.Property(e => e.Email).HasMaxLength(200);

                entity.Property(e => e.Fax)
                    .HasMaxLength(50)
                    .HasColumnName("FAX");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Pan)
                    .HasMaxLength(50)
                    .HasColumnName("PAN");

                entity.Property(e => e.PersonName).HasMaxLength(200);

                entity.Property(e => e.ServiceTaxNumber).HasMaxLength(50);

                entity.Property(e => e.Telephone).HasMaxLength(50);

                entity.Property(e => e.Tinnumber)
                    .HasMaxLength(50)
                    .HasColumnName("TINNumber");

                entity.Property(e => e.Website).HasMaxLength(200);

                entity.HasOne(d => d.Address1)
                    .WithMany(p => p.PersonAccountAddress1s)
                    .HasForeignKey(d => d.Address1Id)
                    .HasConstraintName("FK_PersonAccounts_Addresses");

                entity.HasOne(d => d.Address2)
                    .WithMany(p => p.PersonAccountAddress2s)
                    .HasForeignKey(d => d.Address2Id)
                    .HasConstraintName("FK_PersonAccounts_Addresses1");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.PersonAccounts)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_PersonAccounts_UserDetails");
            });

            modelBuilder.Entity<Price>(entity =>
            {
                entity.HasIndex(e => e.UnitId, "IX_Prices");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Caption).HasMaxLength(200);

                entity.Property(e => e.Price1)
                    .HasColumnType("decimal(15, 3)")
                    .HasColumnName("Price");

                entity.Property(e => e.UnitId).HasColumnName("UnitID");

                entity.HasOne(d => d.Unit)
                    .WithMany(p => p.Prices)
                    .HasForeignKey(d => d.UnitId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProductPrices_Units");
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.HasIndex(e => new { e.BrandId, e.CategoryId }, "IX_Products");

                entity.HasIndex(e => e.BrandId, "IX_Products_1");

                entity.HasIndex(e => e.CategoryId, "IX_Products_2");

                entity.HasIndex(e => e.ProductTypeId, "IX_Products_3");

                entity.HasIndex(e => e.UsageTypeId, "IX_Products_4");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.BrandId).HasColumnName("BrandID");

                entity.Property(e => e.CategoryId).HasColumnName("CategoryID");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.IsCod).HasColumnName("IsCOD");

                entity.Property(e => e.IsDelete).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsEmi).HasColumnName("IsEMI");

                entity.Property(e => e.IsSubscribable).HasDefaultValueSql("((0))");

                entity.Property(e => e.LaunchDate).HasColumnType("datetime");

                entity.Property(e => e.LinkUrl)
                    .HasMaxLength(500)
                    .HasColumnName("LinkURL");

                entity.Property(e => e.ManufactureId).HasColumnName("ManufactureID");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Price).HasColumnType("decimal(15, 3)");

                entity.Property(e => e.ProductCode).HasMaxLength(100);

                entity.Property(e => e.ProductName).HasMaxLength(500);

                entity.Property(e => e.ProductSetId).HasColumnName("ProductSetID");

                entity.Property(e => e.ProductTypeId).HasColumnName("ProductTypeID");

                entity.Property(e => e.Rating).HasColumnType("decimal(5, 3)");

                entity.Property(e => e.Skuid).HasColumnName("SKUID");

                entity.Property(e => e.StockTypeId).HasColumnName("StockTypeID");

                entity.Property(e => e.UnitId).HasColumnName("UnitID");

                entity.Property(e => e.UsageTypeId).HasColumnName("UsageTypeID");

                entity.HasOne(d => d.Brand)
                    .WithMany(p => p.Products)
                    .HasForeignKey(d => d.BrandId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Products_Brands");

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.Products)
                    .HasForeignKey(d => d.CategoryId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Products_Categories");

                entity.HasOne(d => d.ProductSet)
                    .WithMany(p => p.Products)
                    .HasForeignKey(d => d.ProductSetId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Products_ProductSets");

                entity.HasOne(d => d.ProductType)
                    .WithMany(p => p.Products)
                    .HasForeignKey(d => d.ProductTypeId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Products_ProductTypes");

                entity.HasOne(d => d.Sku)
                    .WithMany(p => p.ProductSkus)
                    .HasForeignKey(d => d.Skuid)
                    .HasConstraintName("FK_Products_Units1");

                entity.HasOne(d => d.StockType)
                    .WithMany(p => p.Products)
                    .HasForeignKey(d => d.StockTypeId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Products_StockTypes");

                entity.HasOne(d => d.Unit)
                    .WithMany(p => p.ProductUnits)
                    .HasForeignKey(d => d.UnitId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Products_Units");

                entity.HasOne(d => d.UsageType)
                    .WithMany(p => p.Products)
                    .HasForeignKey(d => d.UsageTypeId)
                    .HasConstraintName("FK_Products_UsageTypes");
            });

            modelBuilder.Entity<ProductAssociation>(entity =>
            {
                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(2000);

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.IsDelete).HasDefaultValueSql("((0))");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.ProductAssociatonName).HasMaxLength(200);
            });

            modelBuilder.Entity<ProductAssociationProductVariation>(entity =>
            {
                entity.HasIndex(e => e.ProductAssociationId, "IX_ProductAssociationProductVariations");

                entity.HasIndex(e => e.ProductVariationId, "IX_ProductAssociationProductVariations_1");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.IsDelete).HasDefaultValueSql("((0))");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.ProductAssociationId).HasColumnName("ProductAssociationID");

                entity.Property(e => e.ProductVariationId).HasColumnName("ProductVariationID");

                entity.HasOne(d => d.ProductAssociation)
                    .WithMany(p => p.ProductAssociationProductVariations)
                    .HasForeignKey(d => d.ProductAssociationId)
                    .HasConstraintName("FK_ProductAssociationProductVariations_ProductAssociations");

                entity.HasOne(d => d.ProductVariation)
                    .WithMany(p => p.ProductAssociationProductVariations)
                    .HasForeignKey(d => d.ProductVariationId)
                    .HasConstraintName("FK_ProductAssociationProductVariations_ProductVariations");
            });

            modelBuilder.Entity<ProductDiscount>(entity =>
            {
                entity.HasIndex(e => e.BrandId, "IX_ProductDiscounts");

                entity.HasIndex(e => e.DiscountId, "IX_ProductDiscounts_1");

                entity.HasIndex(e => e.ProductId, "IX_ProductDiscounts_2");

                entity.HasIndex(e => e.ProductVariationId, "IX_ProductDiscounts_3");

                entity.HasIndex(e => new { e.ProductVariationId, e.DiscountId, e.ProductId }, "IX_ProductDiscounts_4");

                entity.HasIndex(e => e.DiscountTypeId, "IX_ProductDiscounts_5");

                entity.HasIndex(e => e.Id, "IX_ProductDiscounts_6");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.BrandId).HasColumnName("BrandID");

                entity.Property(e => e.CategoryId).HasColumnName("CategoryID");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DiscountId).HasColumnName("DiscountID");

                entity.Property(e => e.DiscountOptionId).HasColumnName("DiscountOptionID");

                entity.Property(e => e.DiscountTypeId).HasColumnName("DiscountTypeID");

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.IsDelete).HasDefaultValueSql("((0))");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.ProductVariationId).HasColumnName("ProductVariationID");

                entity.HasOne(d => d.Brand)
                    .WithMany(p => p.ProductDiscounts)
                    .HasForeignKey(d => d.BrandId)
                    .HasConstraintName("FK_ProductDiscounts_Brands");

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.ProductDiscounts)
                    .HasForeignKey(d => d.CategoryId)
                    .HasConstraintName("FK_ProductDiscounts_Categories");

                entity.HasOne(d => d.Discount)
                    .WithMany(p => p.ProductDiscounts)
                    .HasForeignKey(d => d.DiscountId)
                    .HasConstraintName("FK_ProductDiscounts_Discounts");

                entity.HasOne(d => d.DiscountOption)
                    .WithMany(p => p.ProductDiscounts)
                    .HasForeignKey(d => d.DiscountOptionId)
                    .HasConstraintName("FK_ProductDiscounts_DiscountOptioins");

                entity.HasOne(d => d.DiscountType)
                    .WithMany(p => p.ProductDiscounts)
                    .HasForeignKey(d => d.DiscountTypeId)
                    .HasConstraintName("FK_ProductDiscounts_DiscountTypes");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.ProductDiscounts)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("FK_ProductDiscounts_Products");

                entity.HasOne(d => d.ProductVariation)
                    .WithMany(p => p.ProductDiscounts)
                    .HasForeignKey(d => d.ProductVariationId)
                    .HasConstraintName("FK_ProductDiscounts_ProductVariations");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.ProductDiscounts)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_ProductDiscounts_UserDetails");
            });

            modelBuilder.Entity<ProductPopulationFactor>(entity =>
            {
                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(2000);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.ProductPopulationFactorName)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ProductReview>(entity =>
            {
                entity.HasIndex(e => e.ProductId, "IX_ProductReviews");

                entity.HasIndex(e => e.ProductVariationId, "IX_ProductReviews_1");

                entity.HasIndex(e => e.UserId, "IX_ProductReviews_2");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Email).HasMaxLength(200);

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.IsDelete).HasDefaultValueSql("((0))");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.ProductVariationId).HasColumnName("ProductVariationID");

                entity.Property(e => e.ReviewTitle).HasMaxLength(2000);

                entity.Property(e => e.UserName).HasMaxLength(200);

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.ProductReviews)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("FK_ProductReviews_Products");

                entity.HasOne(d => d.ProductVariation)
                    .WithMany(p => p.ProductReviews)
                    .HasForeignKey(d => d.ProductVariationId)
                    .HasConstraintName("FK_ProductReviews_ProductVariations");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.ProductReviewUsers)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_ProductReviews_UserDetails");

                entity.HasOne(d => d.VarifiedByNavigation)
                    .WithMany(p => p.ProductReviewVarifiedByNavigations)
                    .HasForeignKey(d => d.VarifiedBy)
                    .HasConstraintName("FK_ProductReviews_UserDetails1");
            });

            modelBuilder.Entity<ProductSet>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.IsDelete).HasDefaultValueSql("((0))");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.ProductSetName).HasMaxLength(200);
            });

            modelBuilder.Entity<ProductSetProduct>(entity =>
            {
                entity.HasIndex(e => new { e.ProductId, e.ProductSetId }, "IX_ProductSetProducts");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.ProductSetId).HasColumnName("ProductSetID");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.ProductSetProducts)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_ProductSetProducts_Products");

                entity.HasOne(d => d.ProductSet)
                    .WithMany(p => p.ProductSetProducts)
                    .HasForeignKey(d => d.ProductSetId)
                    .HasConstraintName("FK_ProductSetProducts_ProdutSets");
            });

            modelBuilder.Entity<ProductShipment>(entity =>
            {
                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Dimension).HasMaxLength(50);

                entity.Property(e => e.ProductVariatioinPriceId).HasColumnName("ProductVariatioinPriceID");

                entity.Property(e => e.ShipmentCharges).HasColumnType("decimal(15, 3)");

                entity.Property(e => e.UnitId).HasColumnName("UnitID");

                entity.Property(e => e.Weight).HasColumnType("decimal(15, 3)");

                entity.HasOne(d => d.ProductVariatioinPrice)
                    .WithMany(p => p.ProductShipments)
                    .HasForeignKey(d => d.ProductVariatioinPriceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProductShipments_ProductVariationPrices");

                entity.HasOne(d => d.Unit)
                    .WithMany(p => p.ProductShipments)
                    .HasForeignKey(d => d.UnitId)
                    .HasConstraintName("FK_ProductShipments_Units");
            });

            modelBuilder.Entity<ProductSpecification>(entity =>
            {
                entity.HasIndex(e => e.ProductId, "IX_ProductSpecifications_1");

                entity.HasIndex(e => e.SpecificationGroupId, "IX_ProductSpecifications_2");

                entity.HasIndex(e => e.SpecificationId, "IX_ProductSpecifications_3");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.IsDelete).HasDefaultValueSql("((0))");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.SpecificationGroupId).HasColumnName("SpecificationGroupID");

                entity.Property(e => e.SpecificationId).HasColumnName("SpecificationID");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.ProductSpecifications)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("FK_ProductSpecifications_Products");

                entity.HasOne(d => d.SpecificationGroup)
                    .WithMany(p => p.ProductSpecifications)
                    .HasForeignKey(d => d.SpecificationGroupId)
                    .HasConstraintName("FK_ProductSpecifications_SpecificationGroups");

                entity.HasOne(d => d.Specification)
                    .WithMany(p => p.ProductSpecifications)
                    .HasForeignKey(d => d.SpecificationId)
                    .HasConstraintName("FK_ProductSpecifications_Specifications");
            });

            modelBuilder.Entity<ProductStatitic>(entity =>
            {
                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(2000);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.HasOne(d => d.IdNavigation)
                    .WithOne(p => p.ProductStatitic)
                    .HasForeignKey<ProductStatitic>(d => d.Id)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProductStatitics_ProductVariations");
            });

            modelBuilder.Entity<ProductStock>(entity =>
            {
                entity.HasIndex(e => e.ProductVariationId, "IX_ProductStocks");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.LocationId).HasColumnName("LocationID");

                entity.Property(e => e.ProductVariationId).HasColumnName("ProductVariationID");

                entity.Property(e => e.TransactionTypeId).HasColumnName("TransactionTypeID");

                entity.Property(e => e.UnitId).HasColumnName("UnitID");

                entity.HasOne(d => d.ProductVariation)
                    .WithMany(p => p.ProductStocks)
                    .HasForeignKey(d => d.ProductVariationId)
                    .HasConstraintName("FK_ProductStocks_ProductVariations");

                entity.HasOne(d => d.TransactionType)
                    .WithMany(p => p.ProductStocks)
                    .HasForeignKey(d => d.TransactionTypeId)
                    .HasConstraintName("FK_ProductStocks_TransactionTypes");

                entity.HasOne(d => d.Unit)
                    .WithMany(p => p.ProductStocks)
                    .HasForeignKey(d => d.UnitId)
                    .HasConstraintName("FK_ProductStocks_Units");
            });

            modelBuilder.Entity<ProductTax>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.TaxId).HasColumnName("TaxID");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.ProductTaxes)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("FK_ProductTaxs_Products");

                entity.HasOne(d => d.Tax)
                    .WithMany(p => p.ProductTaxes)
                    .HasForeignKey(d => d.TaxId)
                    .HasConstraintName("FK_ProductTaxs_Taxs");
            });

            modelBuilder.Entity<ProductType>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Description).HasMaxLength(2000);

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.IsDelete).HasDefaultValueSql("((0))");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ProductTypeName).HasMaxLength(200);
            });

            modelBuilder.Entity<ProductVariation>(entity =>
            {
                entity.HasIndex(e => e.ProductId, "IX_ProductVariations");

                entity.HasIndex(e => e.ProductAssociationId, "IX_ProductVariations_1");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Caption).HasMaxLength(200);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.IsDelete).HasDefaultValueSql("((0))");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.ProductAssociationId).HasColumnName("ProductAssociationID");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.Rating).HasColumnType("decimal(15, 3)");

                entity.HasOne(d => d.ProductAssociation)
                    .WithMany(p => p.ProductVariations)
                    .HasForeignKey(d => d.ProductAssociationId)
                    .HasConstraintName("FK_ProductVariations_ProductAssociations");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.ProductVariations)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProductVariations_Products");
            });

            modelBuilder.Entity<ProductVariationImage>(entity =>
            {
                entity.HasIndex(e => e.ImageId, "IX_ProductVariationImages");

                entity.HasIndex(e => e.ImageId, "IX_ProductVariationImages_1");

                entity.HasIndex(e => new { e.ImageId, e.ProductVariationId }, "IX_ProductVariationImages_2");

                entity.HasIndex(e => new { e.ImageId, e.ImageOrderNo, e.ProductVariationId }, "IX_ProductVariationImages_3");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.ImageId).HasColumnName("ImageID");

                entity.Property(e => e.ProductVariationId).HasColumnName("ProductVariationID");

                entity.HasOne(d => d.Image)
                    .WithMany(p => p.ProductVariationImages)
                    .HasForeignKey(d => d.ImageId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProductVariationImages_Images");

                entity.HasOne(d => d.ProductVariation)
                    .WithMany(p => p.ProductVariationImages)
                    .HasForeignKey(d => d.ProductVariationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProductVariationImages_ProductVariations1");
            });

            modelBuilder.Entity<ProductVariationPrice>(entity =>
            {
                entity.HasIndex(e => e.Barcode, "IX_ProductVariationPrices");

                entity.HasIndex(e => e.PriceId, "IX_ProductVariationPrices_1");

                entity.HasIndex(e => e.ProductVariationId, "IX_ProductVariationPrices_2");

                entity.HasIndex(e => new { e.PriceId, e.ProductVariationId }, "IX_ProductVariationPrices_3");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Barcode).HasMaxLength(32);

                entity.Property(e => e.PriceId).HasColumnName("PriceID");

                entity.Property(e => e.ProductVariationId).HasColumnName("ProductVariationID");

                entity.HasOne(d => d.Price)
                    .WithMany(p => p.ProductVariationPrices)
                    .HasForeignKey(d => d.PriceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProductVariationPrices_ProductPrices");

                entity.HasOne(d => d.ProductVariation)
                    .WithMany(p => p.ProductVariationPrices)
                    .HasForeignKey(d => d.ProductVariationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProductVariationPrices_ProductVariations");
            });

            modelBuilder.Entity<ProductVariationValue>(entity =>
            {
                entity.HasIndex(e => new { e.ProductId, e.VariationId }, "IX_ProductVariationValues");

                entity.HasIndex(e => e.ProductId, "IX_ProductVariationValues_1");

                entity.HasIndex(e => e.VariationId, "IX_ProductVariationValues_2");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.VariationId).HasColumnName("VariationID");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.ProductVariationValues)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProductVariationValues_Products");

                entity.HasOne(d => d.Variation)
                    .WithMany(p => p.ProductVariationValues)
                    .HasForeignKey(d => d.VariationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProductVariationValues_Variations");
            });

            modelBuilder.Entity<Profile>(entity =>
            {
                entity.HasKey(e => e.UserId)
                    .HasName("PK__Profiles__1788CC4C300B4ED8");

                entity.Property(e => e.UserId).ValueGeneratedNever();

                entity.Property(e => e.LastUpdatedDate).HasColumnType("datetime");

                entity.Property(e => e.PropertyNames).HasMaxLength(4000);

                entity.Property(e => e.PropertyValueBinary).HasColumnType("image");

                entity.Property(e => e.PropertyValueStrings).HasMaxLength(4000);

                entity.HasOne(d => d.User)
                    .WithOne(p => p.Profile)
                    .HasForeignKey<Profile>(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("UserProfile");
            });

            modelBuilder.Entity<ProofType>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(2000);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.ProofTypeName).HasMaxLength(200);
            });

            modelBuilder.Entity<Purchase>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.CurrencyId).HasColumnName("CurrencyID");

                entity.Property(e => e.CurrencyValue).HasColumnType("decimal(5, 3)");

                entity.Property(e => e.Description).HasMaxLength(2000);

                entity.Property(e => e.ExternalBillNo).HasMaxLength(50);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.NetPayable).HasColumnType("decimal(15, 3)");

                entity.Property(e => e.OtherAdditions).HasColumnType("decimal(15, 3)");

                entity.Property(e => e.OtherDeductions).HasColumnType("decimal(15, 3)");

                entity.Property(e => e.PersonAccountId).HasColumnName("PersonAccountID");

                entity.Property(e => e.PurchaseBillNo)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PurchaseStatusId).HasColumnName("PurchaseStatusID");

                entity.Property(e => e.TotalAmount).HasColumnType("decimal(15, 3)");

                entity.Property(e => e.TotalDiscount).HasColumnType("decimal(15, 3)");

                entity.Property(e => e.TotalShipmentCharges).HasColumnType("decimal(15, 3)");

                entity.Property(e => e.TransactionCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TransactionDate).HasColumnType("datetime");

                entity.HasOne(d => d.Currency)
                    .WithMany(p => p.Purchases)
                    .HasForeignKey(d => d.CurrencyId)
                    .HasConstraintName("FK_Purchases_Currencies");

                entity.HasOne(d => d.PersonAccount)
                    .WithMany(p => p.Purchases)
                    .HasForeignKey(d => d.PersonAccountId)
                    .HasConstraintName("FK_Purchases_PersonAccounts");
            });

            modelBuilder.Entity<PurchaseDetail>(entity =>
            {
                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Amount).HasColumnType("decimal(15, 3)");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(2000);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.PriceId).HasColumnName("PriceID");

                entity.Property(e => e.ProductDiscountId).HasColumnName("ProductDiscountID");

                entity.Property(e => e.ProductVariationId).HasColumnName("ProductVariationID");

                entity.Property(e => e.PurchaseId).HasColumnName("PurchaseID");

                entity.Property(e => e.Rate).HasColumnType("decimal(15, 3)");

                entity.Property(e => e.UnitId).HasColumnName("UnitID");

                entity.HasOne(d => d.Price)
                    .WithMany(p => p.PurchaseDetails)
                    .HasForeignKey(d => d.PriceId)
                    .HasConstraintName("FK_PurchaseDetails_Prices");

                entity.HasOne(d => d.ProductVariation)
                    .WithMany(p => p.PurchaseDetails)
                    .HasForeignKey(d => d.ProductVariationId)
                    .HasConstraintName("FK_PurchaseDetails_ProductVariations");

                entity.HasOne(d => d.Purchase)
                    .WithMany(p => p.PurchaseDetails)
                    .HasForeignKey(d => d.PurchaseId)
                    .HasConstraintName("FK_PurchaseDetails_Purchases");

                entity.HasOne(d => d.Unit)
                    .WithMany(p => p.PurchaseDetails)
                    .HasForeignKey(d => d.UnitId)
                    .HasConstraintName("FK_PurchaseDetails_Units");
            });

            modelBuilder.Entity<PurchaseOrder>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.CurrencyId).HasColumnName("CurrencyID");

                entity.Property(e => e.CurrencyValue).HasColumnType("decimal(5, 3)");

                entity.Property(e => e.Description).HasMaxLength(2000);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.PersonAccountId).HasColumnName("PersonAccountID");

                entity.Property(e => e.PurchaseOrderNo)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PurchaseOrderStatusId).HasColumnName("PurchaseOrderStatusID");

                entity.Property(e => e.PurchaseOrderedBy).HasColumnName("PurchaseOrderedBY");

                entity.Property(e => e.TotalAmount).HasColumnType("decimal(15, 3)");

                entity.Property(e => e.TransactionCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TransactionDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<PurchaseOrderDetail>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Amount).HasColumnType("decimal(15, 3)");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(2000);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.PriceId).HasColumnName("PriceID");

                entity.Property(e => e.ProductVariationId).HasColumnName("ProductVariationID");

                entity.Property(e => e.PurchaseOrderId).HasColumnName("PurchaseOrderID");

                entity.Property(e => e.Rate).HasColumnType("decimal(15, 3)");

                entity.Property(e => e.UnitId).HasColumnName("UnitID");

                entity.HasOne(d => d.ProductVariation)
                    .WithMany()
                    .HasForeignKey(d => d.ProductVariationId)
                    .HasConstraintName("FK_PurchaseOrderDetails_ProductVariations");

                entity.HasOne(d => d.PurchaseOrder)
                    .WithMany()
                    .HasForeignKey(d => d.PurchaseOrderId)
                    .HasConstraintName("FK_PurchaseOrderDetails_PurchaseOrders");

                entity.HasOne(d => d.Unit)
                    .WithMany()
                    .HasForeignKey(d => d.UnitId)
                    .HasConstraintName("FK_PurchaseOrderDetails_Units");
            });

            modelBuilder.Entity<Role>(entity =>
            {
                entity.Property(e => e.RoleId).ValueGeneratedNever();

                entity.Property(e => e.Description).HasMaxLength(256);

                entity.Property(e => e.RoleName).HasMaxLength(256);

                entity.HasOne(d => d.Application)
                    .WithMany(p => p.Roles)
                    .HasForeignKey(d => d.ApplicationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("RoleApplication");
            });

            modelBuilder.Entity<RolePage>(entity =>
            {
                entity.HasIndex(e => new { e.PageId, e.RoleId }, "IX_RolePages");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.PageId).HasColumnName("PageID");

                entity.Property(e => e.Permission)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.RoleId).HasColumnName("RoleID");

                entity.HasOne(d => d.Page)
                    .WithMany(p => p.RolePages)
                    .HasForeignKey(d => d.PageId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RolePages_Pages");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.RolePages)
                    .HasForeignKey(d => d.RoleId)
                    .HasConstraintName("FK_RolePages_Roles");
            });

            modelBuilder.Entity<Sale>(entity =>
            {
                entity.HasIndex(e => e.PaymentMethodId, "IX_Sales");

                entity.HasIndex(e => e.PersonAccountId, "IX_Sales_1");

                entity.HasIndex(e => e.SalesOrderId, "IX_Sales_2");

                entity.HasIndex(e => e.ShippingAddressId, "IX_Sales_3");

                entity.HasIndex(e => e.BillingAddressId, "IX_Sales_4");

                entity.HasIndex(e => e.SalesStatusId, "IX_Sales_5");

                entity.HasIndex(e => e.Id, "IX_Sales_6");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.BillingAddressId).HasColumnName("BillingAddressID");

                entity.Property(e => e.BillingAddressJson).HasColumnName("BillingAddressJSON");

                entity.Property(e => e.ContactNumber).HasMaxLength(20);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CurrencyFormat).HasMaxLength(50);

                entity.Property(e => e.CurrencyId).HasColumnName("CurrencyID");

                entity.Property(e => e.CurrencyValue).HasColumnType("decimal(5, 3)");

                entity.Property(e => e.DeliveredDate).HasColumnType("datetime");

                entity.Property(e => e.Descriptions).HasMaxLength(2000);

                entity.Property(e => e.DueDate).HasColumnType("datetime");

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.IsDelete).HasDefaultValueSql("((0))");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.NetPayable).HasColumnType("decimal(15, 3)");

                entity.Property(e => e.OtherAdditions).HasColumnType("decimal(15, 3)");

                entity.Property(e => e.OtherDeductions).HasColumnType("decimal(15, 3)");

                entity.Property(e => e.PaymentMethodId).HasColumnName("PaymentMethodID");

                entity.Property(e => e.PaymentReceiveDate).HasColumnType("datetime");

                entity.Property(e => e.PersonAccountId).HasColumnName("PersonAccountID");

                entity.Property(e => e.ResBankRefNo)
                    .HasMaxLength(200)
                    .HasColumnName("Res_Bank_Ref_No");

                entity.Property(e => e.ResCardName)
                    .HasMaxLength(200)
                    .HasColumnName("Res_Card_Name");

                entity.Property(e => e.ResCoRelationId)
                    .HasMaxLength(200)
                    .HasColumnName("Res_CoRelationID");

                entity.Property(e => e.ResCurrecnyCode)
                    .HasMaxLength(5)
                    .HasColumnName("Res_CurrecnyCode");

                entity.Property(e => e.ResDiscountValue)
                    .HasColumnType("decimal(15, 3)")
                    .HasColumnName("Res_Discount_Value");

                entity.Property(e => e.ResIsTransactionSuccessFul).HasColumnName("Res_IsTransactionSuccessFul");

                entity.Property(e => e.ResJson).HasColumnName("Res_JSON");

                entity.Property(e => e.ResMessage)
                    .HasMaxLength(500)
                    .HasColumnName("Res_Message");

                entity.Property(e => e.ResNetReceivedAmount)
                    .HasColumnType("decimal(15, 3)")
                    .HasColumnName("Res_NetReceivedAmount");

                entity.Property(e => e.ResOfferCode)
                    .HasMaxLength(200)
                    .HasColumnName("Res_Offer_Code");

                entity.Property(e => e.ResOfferType)
                    .HasMaxLength(200)
                    .HasColumnName("Res_Offer_Type");

                entity.Property(e => e.ResPaymentTransactionNo)
                    .HasMaxLength(200)
                    .HasColumnName("Res_PaymentTransactionNo");

                entity.Property(e => e.ResTimeStamp)
                    .HasColumnType("datetime")
                    .HasColumnName("Res_TimeStamp");

                entity.Property(e => e.ResVault)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("Res_Vault")
                    .IsFixedLength();

                entity.Property(e => e.SaleBillNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SalesOrderId).HasColumnName("SalesOrderID");

                entity.Property(e => e.SalesStatusId).HasColumnName("SalesStatusID");

                entity.Property(e => e.SalesTypeId).HasColumnName("SalesTypeID");

                entity.Property(e => e.ShippingAddressId).HasColumnName("ShippingAddressID");

                entity.Property(e => e.ShippingAddressJson).HasColumnName("ShippingAddressJSON");

                entity.Property(e => e.ShippingAgentId).HasColumnName("ShippingAgentID");

                entity.Property(e => e.ShippingAgentTokenId)
                    .HasMaxLength(100)
                    .HasColumnName("ShippingAgentTokenID");

                entity.Property(e => e.ShippingId).HasColumnName("ShippingID");

                entity.Property(e => e.ShippingTrackingUrl).HasColumnName("ShippingTrackingURL");

                entity.Property(e => e.TotalAmount).HasColumnType("decimal(15, 3)");

                entity.Property(e => e.TotalDiscount).HasColumnType("decimal(15, 3)");

                entity.Property(e => e.TotalQuantity).HasColumnType("decimal(15, 3)");

                entity.Property(e => e.TotalShipmentCharge).HasColumnType("decimal(15, 3)");

                entity.Property(e => e.TotalTax).HasColumnType("decimal(15, 3)");

                entity.Property(e => e.TransactionDate).HasColumnType("datetime");

                entity.Property(e => e.TransactionTypeCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.BillingAddress)
                    .WithMany(p => p.SaleBillingAddresses)
                    .HasForeignKey(d => d.BillingAddressId)
                    .HasConstraintName("FK_Sales_Addresses1");

                entity.HasOne(d => d.Currency)
                    .WithMany(p => p.Sales)
                    .HasForeignKey(d => d.CurrencyId)
                    .HasConstraintName("FK_Sales_Currencies");

                entity.HasOne(d => d.PaymentMethod)
                    .WithMany(p => p.Sales)
                    .HasForeignKey(d => d.PaymentMethodId)
                    .HasConstraintName("FK_Sales_PaymentMethods");

                entity.HasOne(d => d.PersonAccount)
                    .WithMany(p => p.Sales)
                    .HasForeignKey(d => d.PersonAccountId)
                    .HasConstraintName("FK_Sales_PersonAccounts");

                entity.HasOne(d => d.SalesOrder)
                    .WithMany(p => p.Sales)
                    .HasForeignKey(d => d.SalesOrderId)
                    .HasConstraintName("FK_Sales_SalesOrders");

                entity.HasOne(d => d.SalesStatus)
                    .WithMany(p => p.Sales)
                    .HasForeignKey(d => d.SalesStatusId)
                    .HasConstraintName("FK_Sales_SalesStatus");

                entity.HasOne(d => d.SalesType)
                    .WithMany(p => p.Sales)
                    .HasForeignKey(d => d.SalesTypeId)
                    .HasConstraintName("FK_Sales_SalesTypes");

                entity.HasOne(d => d.ShippingAddress)
                    .WithMany(p => p.SaleShippingAddresses)
                    .HasForeignKey(d => d.ShippingAddressId)
                    .HasConstraintName("FK_Sales_Addresses");
            });

            modelBuilder.Entity<SalesDetail>(entity =>
            {
                entity.HasIndex(e => e.PriceId, "IX_SalesDetails");

                entity.HasIndex(e => e.ProductVariationId, "IX_SalesDetails_1");

                entity.HasIndex(e => e.SalesId, "IX_SalesDetails_2");

                entity.HasIndex(e => e.ProductDiscountId1, "IX_SalesDetails_3");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Amount).HasColumnType("decimal(15, 3)");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(2000);

                entity.Property(e => e.DiscountAmount).HasColumnType("decimal(15, 3)");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Price).HasColumnType("decimal(15, 3)");

                entity.Property(e => e.PriceId).HasColumnName("PriceID");

                entity.Property(e => e.ProductCode).HasMaxLength(100);

                entity.Property(e => e.ProductDetailJson).HasColumnName("ProductDetailJSON");

                entity.Property(e => e.ProductDiscountId1).HasColumnName("ProductDiscountID1");

                entity.Property(e => e.ProductDiscountId2).HasColumnName("ProductDiscountID2");

                entity.Property(e => e.ProductDiscountId3).HasColumnName("ProductDiscountID3");

                entity.Property(e => e.ProductName).HasMaxLength(500);

                entity.Property(e => e.ProductTaxId).HasColumnName("ProductTaxID");

                entity.Property(e => e.ProductVariationId).HasColumnName("ProductVariationID");

                entity.Property(e => e.Quantity).HasColumnType("decimal(15, 3)");

                entity.Property(e => e.SalesId).HasColumnName("SalesID");

                entity.Property(e => e.TaxId).HasColumnName("TaxID");

                entity.Property(e => e.UnitId).HasColumnName("UnitID");

                entity.HasOne(d => d.PriceNavigation)
                    .WithMany(p => p.SalesDetails)
                    .HasForeignKey(d => d.PriceId)
                    .HasConstraintName("FK_SalesDetails_Prices");

                entity.HasOne(d => d.ProductVariation)
                    .WithMany(p => p.SalesDetails)
                    .HasForeignKey(d => d.ProductVariationId)
                    .HasConstraintName("FK_SalesDetails_ProductVariations");

                entity.HasOne(d => d.Sales)
                    .WithMany(p => p.SalesDetails)
                    .HasForeignKey(d => d.SalesId)
                    .HasConstraintName("FK_SalesDetails_Sales");
            });

            modelBuilder.Entity<SalesHistoryTransaction>(entity =>
            {
                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.SalesId).HasColumnName("SalesID");

                entity.Property(e => e.SalesStausId).HasColumnName("SalesStausID");

                entity.Property(e => e.TransactionDate).HasColumnType("datetime");

                entity.HasOne(d => d.SalesStaus)
                    .WithMany(p => p.SalesHistoryTransactions)
                    .HasForeignKey(d => d.SalesStausId)
                    .HasConstraintName("FK_SalesHistoryTransactions_SalesStatus");
            });

            modelBuilder.Entity<SalesOrder>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.BillingAddressId).HasColumnName("BillingAddressID");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CurrencyId).HasColumnName("CurrencyID");

                entity.Property(e => e.CurrencyValue).HasColumnType("decimal(5, 3)");

                entity.Property(e => e.DeliveredDate).HasColumnType("datetime");

                entity.Property(e => e.Descriptions).HasMaxLength(2000);

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.IsDelete).HasDefaultValueSql("((0))");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.NetPayable).HasColumnType("decimal(15, 3)");

                entity.Property(e => e.OrderStatusId).HasColumnName("OrderStatusID");

                entity.Property(e => e.OtherAdditions).HasColumnType("decimal(15, 3)");

                entity.Property(e => e.OtherDeductions).HasColumnType("decimal(15, 3)");

                entity.Property(e => e.PaymentMethodId).HasColumnName("PaymentMethodID");

                entity.Property(e => e.PaymentReceiveDate).HasColumnType("datetime");

                entity.Property(e => e.PersonAccountId).HasColumnName("PersonAccountID");

                entity.Property(e => e.Series)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShippingAddressId).HasColumnName("ShippingAddressID");

                entity.Property(e => e.ShippingAgentId).HasColumnName("ShippingAgentID");

                entity.Property(e => e.ShippingAgentTokenId)
                    .HasMaxLength(100)
                    .HasColumnName("ShippingAgentTokenID");

                entity.Property(e => e.ShippingId).HasColumnName("ShippingID");

                entity.Property(e => e.ShippmentDate).HasColumnType("datetime");

                entity.Property(e => e.TotalAmount).HasColumnType("decimal(15, 3)");

                entity.Property(e => e.TotalDiscount).HasColumnType("decimal(15, 3)");

                entity.Property(e => e.TotalShipmentCharge).HasColumnType("decimal(15, 3)");

                entity.HasOne(d => d.Currency)
                    .WithMany(p => p.SalesOrders)
                    .HasForeignKey(d => d.CurrencyId)
                    .HasConstraintName("FK_SalesOrders_Currencies");

                entity.HasOne(d => d.PersonAccount)
                    .WithMany(p => p.SalesOrders)
                    .HasForeignKey(d => d.PersonAccountId)
                    .HasConstraintName("FK_SalesOrders_PersonAccounts");
            });

            modelBuilder.Entity<SalesOrderDetail>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Amount).HasColumnType("decimal(15, 3)");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DiscountAmount).HasColumnType("decimal(15, 3)");

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.IsDelete).HasDefaultValueSql("((0))");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.PriceId).HasColumnName("PriceID");

                entity.Property(e => e.ProductDiscountId).HasColumnName("ProductDiscountID");

                entity.Property(e => e.ProductVariationId).HasColumnName("ProductVariationID");

                entity.Property(e => e.Rate).HasColumnType("decimal(15, 3)");

                entity.Property(e => e.Remark).HasMaxLength(2000);

                entity.Property(e => e.SalesOrderId).HasColumnName("SalesOrderID");

                entity.Property(e => e.UnitId).HasColumnName("UnitID");
            });

            modelBuilder.Entity<SalesStatus>(entity =>
            {
                entity.ToTable("SalesStatus");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(2000);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.SaleStatusName).HasMaxLength(200);
            });

            modelBuilder.Entity<SalesType>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Description).HasMaxLength(2000);

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.IsDelete).HasDefaultValueSql("((0))");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SalesTypeName)
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Seocontent>(entity =>
            {
                entity.ToTable("SEOContents");

                entity.HasIndex(e => e.Id, "IX_SEOContents_1")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.BrandId).HasColumnName("BrandID");

                entity.Property(e => e.CategoryId).HasColumnName("CategoryID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.MetaDescription).HasMaxLength(500);

                entity.Property(e => e.MetaKeywords).HasMaxLength(500);

                entity.Property(e => e.MetaTitles).HasMaxLength(500);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.HasOne(d => d.Brand)
                    .WithMany(p => p.Seocontents)
                    .HasForeignKey(d => d.BrandId)
                    .HasConstraintName("FK_SEOContents_Brands");

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.Seocontents)
                    .HasForeignKey(d => d.CategoryId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_SEOContents_Category");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.Seocontents)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("FK_SEOContents_Products");
            });

            modelBuilder.Entity<ShipmentAgent>(entity =>
            {
                entity.HasIndex(e => e.Id, "IX_ShipmentAgents");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AddressId).HasColumnName("AddressID");

                entity.Property(e => e.CompanyName).HasMaxLength(200);

                entity.Property(e => e.ContactPersonName).HasMaxLength(200);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Description).HasMaxLength(2000);

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.IsDelete).HasDefaultValueSql("((0))");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.PersonContactNo).HasMaxLength(50);

                entity.Property(e => e.ShipAgentTypeId).HasColumnName("ShipAgentTypeID");

                entity.Property(e => e.TrackingUrl)
                    .HasMaxLength(500)
                    .HasColumnName("TrackingURL");

                entity.Property(e => e.Website).HasMaxLength(500);

                entity.HasOne(d => d.Address)
                    .WithMany(p => p.ShipmentAgents)
                    .HasForeignKey(d => d.AddressId)
                    .HasConstraintName("FK_ShipmentAgents_Addresses");

                entity.HasOne(d => d.ShipAgentType)
                    .WithMany(p => p.ShipmentAgents)
                    .HasForeignKey(d => d.ShipAgentTypeId)
                    .HasConstraintName("FK_ShipmentAgents_ShipmentAgentTypes");
            });

            modelBuilder.Entity<ShipmentAgentCourierServiceProvider>(entity =>
            {
                entity.HasIndex(e => e.ShipmentAgentId, "IX_ShipmentAgentCourierServiceProviders");

                entity.HasIndex(e => e.CourierServiceProviderId, "IX_ShipmentAgentCourierServiceProviders_1");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CourierServiceProviderId).HasColumnName("CourierServiceProviderID");

                entity.Property(e => e.CreatedDat).HasColumnType("datetime");

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.IsDelete).HasDefaultValueSql("((0))");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.ShipmentAgentId).HasColumnName("ShipmentAgentID");

                entity.HasOne(d => d.CourierServiceProvider)
                    .WithMany(p => p.ShipmentAgentCourierServiceProviderCourierServiceProviders)
                    .HasForeignKey(d => d.CourierServiceProviderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ShipmentAgentCourierServiceProviders_ShipmentAgentCourierServiceProviders");

                entity.HasOne(d => d.ShipmentAgent)
                    .WithMany(p => p.ShipmentAgentCourierServiceProviderShipmentAgents)
                    .HasForeignKey(d => d.ShipmentAgentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ShipmentAgentCourierServiceProviders_ShipmentAgents");
            });

            modelBuilder.Entity<ShipmentAgentRegion>(entity =>
            {
                entity.HasIndex(e => e.ShipmentAgentId, "IX_ShipmentAgentRegions");

                entity.HasIndex(e => e.StateId, "IX_ShipmentAgentRegions_1");

                entity.HasIndex(e => e.CountryId, "IX_ShipmentAgentRegions_2");

                entity.HasIndex(e => e.CityId, "IX_ShipmentAgentRegions_3");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.CityId).HasColumnName("CityID");

                entity.Property(e => e.CountryId).HasColumnName("CountryID");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.IsDelete).HasDefaultValueSql("((0))");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ShipmentAgentId).HasColumnName("ShipmentAgentID");

                entity.Property(e => e.ShippingCharges).HasColumnType("decimal(15, 3)");

                entity.Property(e => e.StateId).HasColumnName("StateID");

                entity.HasOne(d => d.City)
                    .WithMany(p => p.ShipmentAgentRegions)
                    .HasForeignKey(d => d.CityId)
                    .HasConstraintName("FK_ShipmentAgentRegions_Cities");

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.ShipmentAgentRegions)
                    .HasForeignKey(d => d.CountryId)
                    .HasConstraintName("FK_ShipmentAgentRegions_Countries");

                entity.HasOne(d => d.ShipmentAgent)
                    .WithMany(p => p.ShipmentAgentRegions)
                    .HasForeignKey(d => d.ShipmentAgentId)
                    .HasConstraintName("FK_ShipmentAgentRegions_ShipmentAgentRegions");

                entity.HasOne(d => d.State)
                    .WithMany(p => p.ShipmentAgentRegions)
                    .HasForeignKey(d => d.StateId)
                    .HasConstraintName("FK_ShipmentAgentRegions_States");
            });

            modelBuilder.Entity<ShipmentAgentRegionRate>(entity =>
            {
                entity.HasIndex(e => e.ShipmentAgentRegionId, "IX_ShipmentAgentRegionRates");

                entity.HasIndex(e => e.UnitId, "IX_ShipmentAgentRegionRates_1");

                entity.HasIndex(e => new { e.MaxWeight, e.MinWeight, e.UnitId }, "IX_ShipmentAgentRegionRates_2");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ExtraPackingWeight).HasColumnType("decimal(15, 3)");

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.IsDelete).HasDefaultValueSql("((0))");

                entity.Property(e => e.MaxWeight).HasColumnType("decimal(15, 3)");

                entity.Property(e => e.MinWeight).HasColumnType("decimal(15, 3)");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Rate).HasColumnType("decimal(15, 3)");

                entity.Property(e => e.ShipmentAgentRegionId).HasColumnName("ShipmentAgentRegionID");

                entity.Property(e => e.UnitId).HasColumnName("UnitID");

                entity.HasOne(d => d.ShipmentAgentRegion)
                    .WithMany(p => p.ShipmentAgentRegionRates)
                    .HasForeignKey(d => d.ShipmentAgentRegionId)
                    .HasConstraintName("FK_ShipmentRates_ShipmentRates2");
            });

            modelBuilder.Entity<ShipmentAgentType>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AgentTypeName).HasMaxLength(200);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Description).HasMaxLength(2000);

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.IsDelete).HasDefaultValueSql("((0))");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<ShipmentOffer>(entity =>
            {
                entity.HasIndex(e => new { e.MetrocityId, e.CountryId, e.StateId, e.CityId }, "IX_ShipmentOffers");

                entity.HasIndex(e => e.StartDate, "IX_ShipmentOffers_1");

                entity.HasIndex(e => e.EndDate, "IX_ShipmentOffers_2");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.CityId).HasColumnName("CityID");

                entity.Property(e => e.CountryId).HasColumnName("CountryID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.MetrocityId).HasColumnName("MetrocityID");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.OfferName).HasMaxLength(500);

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.Property(e => e.StateId).HasColumnName("StateID");

                entity.HasOne(d => d.City)
                    .WithMany(p => p.ShipmentOffers)
                    .HasForeignKey(d => d.CityId)
                    .HasConstraintName("FK_ShipmentOffers_Cities");

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.ShipmentOffers)
                    .HasForeignKey(d => d.CountryId)
                    .HasConstraintName("FK_ShipmentOffers_Countries");

                entity.HasOne(d => d.Metrocity)
                    .WithMany(p => p.ShipmentOffers)
                    .HasForeignKey(d => d.MetrocityId)
                    .HasConstraintName("FK_ShipmentOffers_MetroCities");

                entity.HasOne(d => d.State)
                    .WithMany(p => p.ShipmentOffers)
                    .HasForeignKey(d => d.StateId)
                    .HasConstraintName("FK_ShipmentOffers_States");
            });

            modelBuilder.Entity<ShipmentOfferCondition>(entity =>
            {
                entity.HasIndex(e => e.ShipmentOfferId, "IX_ShipmentOfferConditions");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.FixShipmentAmount).HasColumnType("decimal(15, 3)");

                entity.Property(e => e.FixShipmentDiscountAmount).HasColumnType("decimal(15, 3)");

                entity.Property(e => e.MaxOrderPrice).HasColumnType("decimal(15, 3)");

                entity.Property(e => e.MaxOrderWeight).HasColumnType("decimal(15, 3)");

                entity.Property(e => e.MinOrderPrice).HasColumnType("decimal(15, 3)");

                entity.Property(e => e.MinOrderWeight).HasColumnType("decimal(15, 3)");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.ShipmentDiscountPercent).HasColumnType("decimal(15, 3)");

                entity.Property(e => e.ShipmentOfferId).HasColumnName("ShipmentOfferID");

                entity.Property(e => e.UnitId).HasColumnName("UnitID");

                entity.HasOne(d => d.ShipmentOffer)
                    .WithMany(p => p.ShipmentOfferConditions)
                    .HasForeignKey(d => d.ShipmentOfferId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ShipmentOfferConditions_ShipmentOffers");

                entity.HasOne(d => d.Unit)
                    .WithMany(p => p.ShipmentOfferConditions)
                    .HasForeignKey(d => d.UnitId)
                    .HasConstraintName("FK_ShipmentOfferConditions_Units");
            });

            modelBuilder.Entity<Sm>(entity =>
            {
                entity.ToTable("SMS");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.ExpireDate).HasColumnType("datetime");

                entity.Property(e => e.Smsname)
                    .HasMaxLength(500)
                    .HasColumnName("SMSName");

                entity.Property(e => e.StartDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<Smsqueue>(entity =>
            {
                entity.ToTable("SMSQueues");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.SendDate).HasColumnType("datetime");

                entity.Property(e => e.Smsid).HasColumnName("SMSID");

                entity.HasOne(d => d.Sms)
                    .WithMany(p => p.Smsqueues)
                    .HasForeignKey(d => d.Smsid)
                    .HasConstraintName("FK_SMSQueues_SMSQueues");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Smsqueues)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_SMSQueues_UserDetails");
            });

            modelBuilder.Entity<Smstopic>(entity =>
            {
                entity.ToTable("SMSTopics");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Smsid).HasColumnName("SMSID");

                entity.Property(e => e.TopicId).HasColumnName("TopicID");

                entity.HasOne(d => d.Sms)
                    .WithMany(p => p.Smstopics)
                    .HasForeignKey(d => d.Smsid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SMSTopics_SMS");

                entity.HasOne(d => d.Topic)
                    .WithMany(p => p.Smstopics)
                    .HasForeignKey(d => d.TopicId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SMSTopics_Topics");
            });

            modelBuilder.Entity<Specification>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Description).HasMaxLength(2000);

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SpecificationName).HasMaxLength(500);
            });

            modelBuilder.Entity<SpecificationGroup>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Description).HasMaxLength(2000);

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SpecificationGroupName).HasMaxLength(200);
            });

            modelBuilder.Entity<SpecificatonGroupSpecification>(entity =>
            {
                entity.HasIndex(e => new { e.SpecificationGroupId, e.SpecificationId }, "IX_SpecificatonGroupSpecifications");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.SpecificationGroupId).HasColumnName("SpecificationGroupID");

                entity.Property(e => e.SpecificationId).HasColumnName("SpecificationID");

                entity.HasOne(d => d.SpecificationGroup)
                    .WithMany(p => p.SpecificatonGroupSpecifications)
                    .HasForeignKey(d => d.SpecificationGroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SpecificatonGroupSpecifications_SpecificatonGroupSpecifications");

                entity.HasOne(d => d.Specification)
                    .WithMany(p => p.SpecificatonGroupSpecifications)
                    .HasForeignKey(d => d.SpecificationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SpecificatonGroupSpecifications_Specifications");
            });

            modelBuilder.Entity<State>(entity =>
            {
                entity.HasIndex(e => e.CountryId, "IX_States");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CountryId).HasColumnName("CountryID");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Description).HasMaxLength(2000);

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.IsDelete).HasDefaultValueSql("((0))");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.StateCode)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.StateName).HasMaxLength(200);

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.States)
                    .HasForeignKey(d => d.CountryId)
                    .HasConstraintName("FK_States_Countries");
            });

            modelBuilder.Entity<StockType>(entity =>
            {
                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(2000);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.StockTypeName).HasMaxLength(100);
            });

            modelBuilder.Entity<SystemFlag>(entity =>
            {
                entity.HasIndex(e => e.FlagGroupId, "IX_SystemFlags");

                entity.HasIndex(e => e.SystemFlagName, "IX_SystemFlags_1");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Caption).HasMaxLength(2000);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Description).HasMaxLength(2000);

                entity.Property(e => e.FlagGroupId).HasColumnName("FlagGroupID");

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.IsDelete).HasDefaultValueSql("((0))");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SystemFlagName).HasMaxLength(200);

                entity.Property(e => e.ToolTip).HasMaxLength(2000);

                entity.Property(e => e.ValueTypeId).HasColumnName("ValueTypeID");

                entity.HasOne(d => d.FlagGroup)
                    .WithMany(p => p.SystemFlags)
                    .HasForeignKey(d => d.FlagGroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SystemFlags_FlagGroups");

                entity.HasOne(d => d.ModifiedByUser)
                    .WithMany(p => p.SystemFlags)
                    .HasForeignKey(d => d.ModifiedByUserId)
                    .HasConstraintName("FK_SystemFlags_UserDetails");

                entity.HasOne(d => d.ValueType)
                    .WithMany(p => p.SystemFlags)
                    .HasForeignKey(d => d.ValueTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SystemFlags_ValueTypes");
            });

            modelBuilder.Entity<Tax>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(2000);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.TaxName).HasMaxLength(200);

                entity.Property(e => e.Value).HasColumnType("decimal(15, 3)");
            });

            modelBuilder.Entity<TextProperty>(entity =>
            {
                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Color).HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(2000);

                entity.Property(e => e.FontAlign).HasMaxLength(50);

                entity.Property(e => e.FontName).HasMaxLength(200);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Text).HasMaxLength(500);

                entity.Property(e => e.TypeOfText).HasMaxLength(500);

                entity.Property(e => e.WordArtName).HasMaxLength(50);
            });

            modelBuilder.Entity<Token>(entity =>
            {
                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ExpiryDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Token1)
                    .HasMaxLength(128)
                    .IsUnicode(false)
                    .HasColumnName("Token");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Tokens)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tokens_UserDetails");
            });

            modelBuilder.Entity<Topic>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.ParentTopicId).HasColumnName("ParentTopicID");

                entity.Property(e => e.TopicName).HasMaxLength(200);

                entity.HasOne(d => d.ParentTopic)
                    .WithMany(p => p.InverseParentTopic)
                    .HasForeignKey(d => d.ParentTopicId)
                    .HasConstraintName("FK_Topics_Topics1");
            });

            modelBuilder.Entity<TopicMail>(entity =>
            {
                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.BrandId).HasColumnName("BrandID");

                entity.Property(e => e.CategoryId).HasColumnName("CategoryID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.MailId).HasColumnName("MailID");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.TopicId).HasColumnName("TopicID");

                entity.HasOne(d => d.Brand)
                    .WithMany(p => p.TopicMails)
                    .HasForeignKey(d => d.BrandId)
                    .HasConstraintName("FK_TopicMails_Brands");

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.TopicMails)
                    .HasForeignKey(d => d.CategoryId)
                    .HasConstraintName("FK_TopicMails_Categories");

                entity.HasOne(d => d.Mail)
                    .WithMany(p => p.TopicMails)
                    .HasForeignKey(d => d.MailId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TopicMails_Mails");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.TopicMails)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("FK_TopicMails_Products");

                entity.HasOne(d => d.Topic)
                    .WithMany(p => p.TopicMails)
                    .HasForeignKey(d => d.TopicId)
                    .HasConstraintName("FK_TopicMails_Topics");
            });

            modelBuilder.Entity<TransactionType>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(2000);

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.IsDelete).HasDefaultValueSql("((0))");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.TransactionCode)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TransactionTypeName).HasMaxLength(200);
            });

            modelBuilder.Entity<Unit>(entity =>
            {
                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Description).HasMaxLength(2000);

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.IsDelete).HasDefaultValueSql("((0))");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UnitCode)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UnitName)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<UsageType>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Description).HasMaxLength(2000);

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UsageTypeName).HasMaxLength(500);
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.Property(e => e.UserId).ValueGeneratedNever();

                entity.Property(e => e.LastActivityDate).HasColumnType("datetime");

                entity.Property(e => e.UserName).HasMaxLength(50);

                entity.HasOne(d => d.Application)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.ApplicationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("UserApplication");

                entity.HasMany(d => d.Roles)
                    .WithMany(p => p.Users)
                    .UsingEntity<Dictionary<string, object>>(
                        "UsersInRole",
                        l => l.HasOne<Role>().WithMany().HasForeignKey("RoleId").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("UsersInRoleRole"),
                        r => r.HasOne<User>().WithMany().HasForeignKey("UserId").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("UsersInRoleUser"),
                        j =>
                        {
                            j.HasKey("UserId", "RoleId").HasName("PK__UsersInR__AF2760AD3E1F151E");

                            j.ToTable("UsersInRoles");
                        });
            });

            modelBuilder.Entity<UserAddress>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AddressId).HasColumnName("AddressID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.IsDelete).HasDefaultValueSql("((0))");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.HasOne(d => d.Address)
                    .WithMany(p => p.UserAddresses)
                    .HasForeignKey(d => d.AddressId)
                    .HasConstraintName("FK_UserAddresses_UserAddresses");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserAddresses)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_UserAddresses_UserDetails");
            });

            modelBuilder.Entity<UserContact>(entity =>
            {
                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.ContactNo)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.ContactTypeId).HasColumnName("ContactTypeID");

                entity.Property(e => e.CountryCode)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(2000);

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.IsDelete).HasDefaultValueSql("((0))");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.HasOne(d => d.ContactType)
                    .WithMany(p => p.UserContacts)
                    .HasForeignKey(d => d.ContactTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserContacts_ContactTypes");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserContacts)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserContacts_UserDetails");
            });

            modelBuilder.Entity<UserDetail>(entity =>
            {
                entity.HasKey(e => e.UserId);

                entity.Property(e => e.UserId).ValueGeneratedNever();

                entity.Property(e => e.Birthdate).HasColumnType("date");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FirstName).HasMaxLength(50);

                entity.Property(e => e.Gender).HasMaxLength(6);

                entity.Property(e => e.LastName).HasMaxLength(50);

                entity.Property(e => e.MiddleName).HasMaxLength(50);

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ProofNo).HasMaxLength(50);

                entity.Property(e => e.ProofTypeId).HasColumnName("ProofTypeID");

                entity.Property(e => e.UserTypeId).HasColumnName("UserTypeID");

                entity.HasOne(d => d.ProofType)
                    .WithMany(p => p.UserDetails)
                    .HasForeignKey(d => d.ProofTypeId)
                    .HasConstraintName("FK_UserDetails_ProofTypes");

                entity.HasOne(d => d.User)
                    .WithOne(p => p.UserDetail)
                    .HasForeignKey<UserDetail>(d => d.UserId)
                    .HasConstraintName("FK_UserDetails_Users");

                entity.HasOne(d => d.UserType)
                    .WithMany(p => p.UserDetails)
                    .HasForeignKey(d => d.UserTypeId)
                    .HasConstraintName("FK_UserDetails_UserTypes");
            });

            modelBuilder.Entity<UserFlag>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Caption).HasMaxLength(500);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(2000);

                entity.Property(e => e.FlagGroupId).HasColumnName("FlagGroupID");

                entity.Property(e => e.FlagName).HasMaxLength(200);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.ToolTip).HasMaxLength(1000);

                entity.Property(e => e.ValueTypeId).HasColumnName("ValueTypeID");

                entity.HasOne(d => d.FlagGroup)
                    .WithMany(p => p.UserFlags)
                    .HasForeignKey(d => d.FlagGroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserFlags_FlagGroups");

                entity.HasOne(d => d.ValueType)
                    .WithMany(p => p.UserFlags)
                    .HasForeignKey(d => d.ValueTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserFlags_ValueTypes");
            });

            modelBuilder.Entity<UserFlagValue>(entity =>
            {
                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.IsDelete).HasDefaultValueSql("((0))");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.UserFlagId).HasColumnName("UserFlagID");

                entity.Property(e => e.UserFlagValue1).HasColumnName("UserFlagValue");

                entity.HasOne(d => d.UserFlag)
                    .WithMany(p => p.UserFlagValues)
                    .HasForeignKey(d => d.UserFlagId)
                    .HasConstraintName("FK_UserFlagValues_UserFlagValues");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserFlagValues)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_UserFlagValues_UserDetails");
            });

            modelBuilder.Entity<UserLog>(entity =>
            {
                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.ActivityTime).HasColumnType("datetime");

                entity.Property(e => e.ActivityTypeId).HasColumnName("ActivityTypeID");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Ipaddress)
                    .HasMaxLength(50)
                    .HasColumnName("IPAddress");

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.IsDelete).HasDefaultValueSql("((0))");

                entity.Property(e => e.MachineId)
                    .HasMaxLength(200)
                    .HasColumnName("MachineID");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.UserAgent).HasMaxLength(100);

                entity.HasOne(d => d.ActivityType)
                    .WithMany(p => p.UserLogs)
                    .HasForeignKey(d => d.ActivityTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserLogs_ActivityTypes");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserLogs)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserLogs_UserDetails");
            });

            modelBuilder.Entity<UserProperty>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Description).HasMaxLength(2000);

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.IsDelete).HasDefaultValueSql("((0))");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.PropertyName).HasMaxLength(200);
            });

            modelBuilder.Entity<UserPropertyValue>(entity =>
            {
                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.UserPropertyId).HasColumnName("UserPropertyID");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserPropertyValues)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_UserPropertyValues_Users");

                entity.HasOne(d => d.UserProperty)
                    .WithMany(p => p.UserPropertyValues)
                    .HasForeignKey(d => d.UserPropertyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserPropertyValues_UserProperties");
            });

            modelBuilder.Entity<UserSubscription>(entity =>
            {
                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.BrandId).HasColumnName("BrandID");

                entity.Property(e => e.CategoryId).HasColumnName("CategoryID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Email).HasMaxLength(200);

                entity.Property(e => e.ExpireDate).HasColumnType("datetime");

                entity.Property(e => e.IsSmssubscriber).HasColumnName("IsSMSSubscriber");

                entity.Property(e => e.Mobile).HasMaxLength(50);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.Property(e => e.TopicId).HasColumnName("TopicID");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.UserName).HasMaxLength(500);

                entity.HasOne(d => d.Brand)
                    .WithMany(p => p.UserSubscriptions)
                    .HasForeignKey(d => d.BrandId)
                    .HasConstraintName("FK_UserSubscriptions_Brands");

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.UserSubscriptions)
                    .HasForeignKey(d => d.CategoryId)
                    .HasConstraintName("FK_UserSubscriptions_Categories");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.UserSubscriptions)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("FK_UserSubscriptions_Products");

                entity.HasOne(d => d.Topic)
                    .WithMany(p => p.UserSubscriptions)
                    .HasForeignKey(d => d.TopicId)
                    .HasConstraintName("FK_UserSubscriptions_Topics");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserSubscriptions)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_UserSubscriptions_UserDetails");
            });

            modelBuilder.Entity<UserType>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Description).HasMaxLength(2000);

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.IsDelete).HasDefaultValueSql("((0))");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UserTypeName).HasMaxLength(200);
            });

            modelBuilder.Entity<UsersOauthAccount>(entity =>
            {
                entity.ToTable("UsersOAuthAccounts");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Email).HasMaxLength(200);

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.IsDelete).HasDefaultValueSql("((0))");

                entity.Property(e => e.LastUsedUtc).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.OauthProviderId).HasColumnName("OAuthProviderID");

                entity.Property(e => e.ProviderUserId)
                    .HasMaxLength(200)
                    .HasColumnName("ProviderUserID");

                entity.Property(e => e.ProviderUserName).HasMaxLength(200);

                entity.Property(e => e.UserProfilePicPath).HasMaxLength(500);

                entity.HasOne(d => d.OauthProvider)
                    .WithMany(p => p.UsersOauthAccounts)
                    .HasForeignKey(d => d.OauthProviderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UsersOAuthAccounts_OAuthProviders");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UsersOauthAccounts)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_UsersOAuthAccounts_UserDetails");
            });

            modelBuilder.Entity<UsersOauthDatum>(entity =>
            {
                entity.HasKey(e => e.UserId);

                entity.ToTable("UsersOAuthData");

                entity.Property(e => e.UserId).ValueGeneratedNever();

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.HasOne(d => d.User)
                    .WithOne(p => p.UsersOauthDatum)
                    .HasForeignKey<UsersOauthDatum>(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UsersOAuthData_UserDetails");
            });

            modelBuilder.Entity<ValueType>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.ValueTypeName).HasMaxLength(200);
            });

            modelBuilder.Entity<Variation>(entity =>
            {
                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(2000);

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.IsDelete).HasDefaultValueSql("((0))");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.VariationName).HasMaxLength(200);
            });

            modelBuilder.Entity<Warehouse>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.WarehouseName).HasMaxLength(200);
            });

            OnModelCreatingPartial(modelBuilder);

            base.OnModelCreating(modelBuilder);
        }
        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
