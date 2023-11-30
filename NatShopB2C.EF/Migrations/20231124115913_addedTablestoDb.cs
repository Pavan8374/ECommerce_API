using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NatShopB2C.EF.Migrations
{
    public partial class addedTablestoDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ActivityTypes",
                columns: table => new
                {
                    ID = table.Column<short>(type: "smallint", nullable: false),
                    ActivityTypeName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((1))"),
                    IsDelete = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))"),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ActivityTypes", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "AddressTypes",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AddressTypeName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: true),
                    IsDelete = table.Column<bool>(type: "bit", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AddressTypes", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Advertiesments",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Description = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    ImagePath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    URL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Priority = table.Column<int>(type: "int", nullable: true),
                    StartDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    EndDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "((1))"),
                    IsDelete = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))"),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Advertiesments", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Applications",
                columns: table => new
                {
                    ApplicationId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ApplicationName = table.Column<string>(type: "nvarchar(235)", maxLength: 235, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Applications", x => x.ApplicationId);
                });

            migrationBuilder.CreateTable(
                name: "ArtCategories",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ArtCategoryName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    ParentArtCategoryID = table.Column<int>(type: "int", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: true),
                    IsDelete = table.Column<bool>(type: "bit", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArtCategories", x => x.ID);
                    table.ForeignKey(
                        name: "FK_ArtCategories_ArtCategories",
                        column: x => x.ParentArtCategoryID,
                        principalTable: "ArtCategories",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "Brands",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BrandName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: true),
                    Rating = table.Column<decimal>(type: "decimal(3,2)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "((1))"),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Brands", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "CanvasTypes",
                columns: table => new
                {
                    ID = table.Column<byte>(type: "tinyint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CanvasTypeName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Height = table.Column<int>(type: "int", nullable: true),
                    Width = table.Column<int>(type: "int", nullable: true),
                    PositionX = table.Column<int>(type: "int", nullable: true),
                    PositionY = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true),
                    ExportX = table.Column<int>(type: "int", nullable: true),
                    ExportY = table.Column<int>(type: "int", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: true),
                    IsDelete = table.Column<bool>(type: "bit", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CanvasTypes", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: true),
                    Depth = table.Column<int>(type: "int", nullable: true),
                    ParentCategoryID = table.Column<int>(type: "int", nullable: true),
                    IsLeaf = table.Column<bool>(type: "bit", nullable: true),
                    IsSubscribable = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))"),
                    IsActive = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((1))"),
                    IsDelete = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))"),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Categories_Categories",
                        column: x => x.ParentCategoryID,
                        principalTable: "Categories",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "CMSPages",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PageName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    URL = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    MetaTitles = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    MetaKeywords = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    MetaDescription = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: true),
                    IsDelete = table.Column<bool>(type: "bit", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CMSPages", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "ContactTypes",
                columns: table => new
                {
                    ID = table.Column<short>(type: "smallint", nullable: false),
                    ContactTypeName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Description = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: true),
                    IsDelete = table.Column<bool>(type: "bit", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContactTypes", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Countries",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ISOCode = table.Column<string>(type: "char(2)", unicode: false, fixedLength: true, maxLength: 2, nullable: true),
                    ISOCode3 = table.Column<string>(type: "char(5)", unicode: false, fixedLength: true, maxLength: 5, nullable: true),
                    CountryName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    DialCode = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: true),
                    Population = table.Column<int>(type: "int", nullable: true),
                    Area = table.Column<decimal>(type: "decimal(18,3)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((1))"),
                    IsDelete = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))"),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Countries", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Currencies",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(type: "char(10)", unicode: false, fixedLength: true, maxLength: 10, nullable: false),
                    CurrencyName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    Icon = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    Value = table.Column<decimal>(type: "decimal(15,5)", nullable: false),
                    AsOnDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    IsBaseCurrency = table.Column<bool>(type: "bit", nullable: true),
                    IsDefaultCurrency = table.Column<bool>(type: "bit", nullable: true),
                    Culture = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((1))"),
                    IsDelete = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))"),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Currencies", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "varchar(max)", unicode: false, nullable: false),
                    MobileNumber = table.Column<string>(type: "varchar(max)", unicode: false, nullable: false),
                    Email = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    IpAddress = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Browser = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "DayWiseSales",
                columns: table => new
                {
                    name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    StartDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    EndDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    Orders = table.Column<decimal>(type: "decimal(15,3)", nullable: true),
                    Amount = table.Column<decimal>(type: "decimal(15,3)", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "DesignProducts",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DesignProductName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    ProductVariationID = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsPublished = table.Column<bool>(type: "bit", nullable: true),
                    IsCommitionApplicable = table.Column<bool>(type: "bit", nullable: true),
                    CommissionPercent = table.Column<decimal>(type: "decimal(6,3)", nullable: true),
                    CommitionFlat = table.Column<decimal>(type: "decimal(15,3)", nullable: true),
                    PublishImagePath = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: true),
                    PublishProductVariationID = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    TotalWorkArea = table.Column<decimal>(type: "decimal(15,3)", nullable: true),
                    DesignRate = table.Column<decimal>(type: "decimal(15,3)", nullable: true),
                    Size = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    Price = table.Column<decimal>(type: "decimal(15,3)", nullable: true),
                    Amount = table.Column<decimal>(type: "decimal(15,3)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsApproved = table.Column<bool>(type: "bit", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: true),
                    IsDelete = table.Column<bool>(type: "bit", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DesignProducts", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "DiscountTypes",
                columns: table => new
                {
                    ID = table.Column<byte>(type: "tinyint", nullable: false),
                    DiscountTypeName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((1))"),
                    IsDelete = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))"),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DiscountTypes", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "DiscountValueTypes",
                columns: table => new
                {
                    ID = table.Column<byte>(type: "tinyint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DiscountValueTypeName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((1))"),
                    IsDelete = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))"),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DiscountValueTypes", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Documents",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DocumentName = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    FilePath = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LastModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: true),
                    IsDelete = table.Column<bool>(type: "bit", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Documents", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "FeedbackActions",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ActionName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((1))"),
                    IsDelete = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))"),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FeedbackActions", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "FeedbackInquiryCategories",
                columns: table => new
                {
                    ID = table.Column<short>(type: "smallint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsFeedback = table.Column<bool>(type: "bit", nullable: true),
                    IsInquiry = table.Column<bool>(type: "bit", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((1))"),
                    IsDelete = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))"),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FeedbackInquiryCategories", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Filters",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FilterName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    Caption = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    ControlType = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: true),
                    IsDelete = table.Column<bool>(type: "bit", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Filters", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "FlagGroups",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FlagGroupName = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: true),
                    ParentFlagGroupID = table.Column<int>(type: "int", nullable: true),
                    DisplayOrder = table.Column<int>(type: "int", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: true),
                    IsDelete = table.Column<bool>(type: "bit", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FlagGroups", x => x.ID);
                    table.ForeignKey(
                        name: "FK_FlagGroups_FlagGroups",
                        column: x => x.ParentFlagGroupID,
                        principalTable: "FlagGroups",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "FooterSections",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FooterSectionName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Order = table.Column<short>(type: "smallint", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: true),
                    IsDelete = table.Column<bool>(type: "bit", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FooterSections", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Images",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ImagePath = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    Description = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: true),
                    Alt = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "((1))"),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Images", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Keywords",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Word = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    frequency = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Keywords", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Mails",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MailName = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Subject = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Priority = table.Column<int>(type: "int", nullable: true),
                    StartDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ExpireDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    IsHTML = table.Column<bool>(type: "bit", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((1))"),
                    IsDelete = table.Column<bool>(type: "bit", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mails", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Menus",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MenuName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    Caption = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    Key = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Order = table.Column<short>(type: "smallint", nullable: true),
                    URL = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    Level = table.Column<short>(type: "smallint", nullable: true),
                    Type = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    ImagePath = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    ParentMenuID = table.Column<int>(type: "int", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((1))"),
                    IsDelete = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))"),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Menus", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "MetroCities",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MetroCity = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    CountryID = table.Column<int>(type: "int", nullable: true),
                    StateID = table.Column<int>(type: "int", nullable: true),
                    NoOfCity = table.Column<int>(type: "int", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: true),
                    IsDelete = table.Column<bool>(type: "bit", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MetroCities", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "NotificationTypes",
                columns: table => new
                {
                    ID = table.Column<short>(type: "smallint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NotificationTypeName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    RedirectURL = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    ImagePath = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: true),
                    IsDelete = table.Column<bool>(type: "bit", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NotificationTypes", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "OAuthProviders",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProviderName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    ProviderIcon = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    ApplicationID = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    SecretKey = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    LoginURL = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    TokenURL = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    UserInfoURL = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    CallbackURL = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    Permission = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((1))"),
                    IsDelete = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))"),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OAuthProviders", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "OrderStatus",
                columns: table => new
                {
                    ID = table.Column<byte>(type: "tinyint", nullable: false),
                    OrderStatus = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Description = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: true),
                    IsDelete = table.Column<bool>(type: "bit", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderStatus", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Pages",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PageRelativeName = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: false),
                    AliasName = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: true),
                    IsRequiredPermission = table.Column<bool>(type: "bit", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((1))"),
                    IsDelete = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pages", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "PaymentMethodTypes",
                columns: table => new
                {
                    ID = table.Column<short>(type: "smallint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PaymentGatewayName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    ImagePath = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    Description = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: true),
                    DisplayOrder = table.Column<int>(type: "int", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: true),
                    IsDelete = table.Column<bool>(type: "bit", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentMethodTypes", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "PaymentPlugins",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PaymentPluginName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    PluginWebLink = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    ConfigurationText = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImagePath = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: true),
                    IsDelete = table.Column<bool>(type: "bit", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentPlugins", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "ProductAssociations",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProductAssociatonName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((1))"),
                    IsDelete = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))"),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductAssociations", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "ProductPopulationFactors",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false),
                    ProductPopulationFactorName = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: false),
                    Value = table.Column<double>(type: "float", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: true),
                    IsDelete = table.Column<bool>(type: "bit", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductPopulationFactors", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "ProductSets",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductSetName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((1))"),
                    IsDelete = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))"),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductSets", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "ProductTypes",
                columns: table => new
                {
                    ID = table.Column<short>(type: "smallint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductTypeName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    IsShowInCatalog = table.Column<bool>(type: "bit", nullable: true),
                    IsAllowSale = table.Column<bool>(type: "bit", nullable: true),
                    IsAllowPurchase = table.Column<bool>(type: "bit", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((1))"),
                    IsDelete = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))"),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductTypes", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "ProofTypes",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProofTypeName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: true),
                    IsDelete = table.Column<bool>(type: "bit", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProofTypes", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "PurchaseOrders",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PurchaseOrderNo = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    TransactionCode = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    PersonAccountID = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CurrencyID = table.Column<int>(type: "int", nullable: true),
                    CurrencyValue = table.Column<decimal>(type: "decimal(5,3)", nullable: true),
                    IsGeneralPurchase = table.Column<bool>(type: "bit", nullable: true),
                    TotalQuantity = table.Column<int>(type: "int", nullable: true),
                    TotalAmount = table.Column<decimal>(type: "decimal(15,3)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: true),
                    PurchaseOrderStatusID = table.Column<short>(type: "smallint", nullable: true),
                    PurchaseOrderedBY = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    PurchaseOrderApproveBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    TransactionDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: true),
                    IsDelete = table.Column<bool>(type: "bit", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PurchaseOrders", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "SalesOrderDetails",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "(newid())"),
                    SalesOrderID = table.Column<long>(type: "bigint", nullable: true),
                    SrNo = table.Column<byte>(type: "tinyint", nullable: true),
                    ProductVariationID = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    PriceID = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ProductDiscountID = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Quantity = table.Column<int>(type: "int", nullable: true),
                    UnitID = table.Column<short>(type: "smallint", nullable: true),
                    Rate = table.Column<decimal>(type: "decimal(15,3)", nullable: true),
                    DiscountAmount = table.Column<decimal>(type: "decimal(15,3)", nullable: true),
                    Amount = table.Column<decimal>(type: "decimal(15,3)", nullable: true),
                    Remark = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((1))"),
                    IsDelete = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))"),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SalesOrderDetails", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "SalesStatus",
                columns: table => new
                {
                    ID = table.Column<short>(type: "smallint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SaleStatusName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    Description = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: true),
                    IsDelete = table.Column<bool>(type: "bit", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SalesStatus", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "SalesTypes",
                columns: table => new
                {
                    ID = table.Column<short>(type: "smallint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SalesTypeName = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    Description = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((1))"),
                    IsDelete = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))"),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SalesTypes", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "ShipmentAgentTypes",
                columns: table => new
                {
                    ID = table.Column<short>(type: "smallint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AgentTypeName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    Description = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((1))"),
                    IsDelete = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))"),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShipmentAgentTypes", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "SMS",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SMSName = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Priority = table.Column<int>(type: "int", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    ExpireDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SMS", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "SpecificationGroups",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SpecificationGroupName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    Description = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "((1))"),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SpecificationGroups", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Specifications",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SpecificationName = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    Description = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "((1))"),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Specifications", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "StockTypes",
                columns: table => new
                {
                    ID = table.Column<short>(type: "smallint", nullable: false),
                    StockTypeName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: true),
                    IsDelete = table.Column<bool>(type: "bit", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StockTypes", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Taxs",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TaxName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    Value = table.Column<decimal>(type: "decimal(15,3)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: true),
                    IsDelete = table.Column<bool>(type: "bit", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Taxs", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "TextProperties",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Text = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    TypeOfText = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    FontName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    FontSize = table.Column<short>(type: "smallint", nullable: true),
                    FontAlign = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Rotation = table.Column<short>(type: "smallint", nullable: true),
                    Color = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Height = table.Column<short>(type: "smallint", nullable: true),
                    Weight = table.Column<short>(type: "smallint", nullable: true),
                    PositionX = table.Column<short>(type: "smallint", nullable: true),
                    PositionY = table.Column<short>(type: "smallint", nullable: true),
                    OriginalPositionX = table.Column<short>(type: "smallint", nullable: true),
                    OriginalPositionY = table.Column<short>(type: "smallint", nullable: true),
                    WordArtName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Description = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: true),
                    IsDelete = table.Column<bool>(type: "bit", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TextProperties", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Topics",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TopicName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    ParentTopicID = table.Column<int>(type: "int", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((1))"),
                    IsDelete = table.Column<bool>(type: "bit", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Topics", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Topics_Topics1",
                        column: x => x.ParentTopicID,
                        principalTable: "Topics",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "TransactionTypes",
                columns: table => new
                {
                    ID = table.Column<short>(type: "smallint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TransactionTypeName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    TransactionCode = table.Column<string>(type: "char(10)", unicode: false, fixedLength: true, maxLength: 10, nullable: true),
                    Description = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((1))"),
                    IsDelete = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))"),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TransactionTypes", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Units",
                columns: table => new
                {
                    ID = table.Column<short>(type: "smallint", nullable: false),
                    UnitCode = table.Column<string>(type: "char(5)", unicode: false, fixedLength: true, maxLength: 5, nullable: true),
                    UnitName = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    Description = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((1))"),
                    IsDelete = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))"),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Units", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "UsageTypes",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UsageTypeName = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    Description = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "((1))"),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UsageTypes", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "UserProperties",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PropertyName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    Description = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((1))"),
                    IsDelete = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))"),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserProperties", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "UserTypes",
                columns: table => new
                {
                    ID = table.Column<short>(type: "smallint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserTypeName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    Description = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((1))"),
                    IsDelete = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))"),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserTypes", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "ValueTypes",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ValueTypeName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: true),
                    IsDelete = table.Column<bool>(type: "bit", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ValueTypes", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Variations",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false),
                    VariationName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((1))"),
                    IsDelete = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))"),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Variations", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Warehouses",
                columns: table => new
                {
                    ID = table.Column<short>(type: "smallint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WarehouseName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: true),
                    IsDelete = table.Column<bool>(type: "bit", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Warehouses", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ApplicationId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RoleName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.RoleId);
                    table.ForeignKey(
                        name: "RoleApplication",
                        column: x => x.ApplicationId,
                        principalTable: "Applications",
                        principalColumn: "ApplicationId");
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ApplicationId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    IsAnonymous = table.Column<bool>(type: "bit", nullable: false),
                    LastActivityDate = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserId);
                    table.ForeignKey(
                        name: "UserApplication",
                        column: x => x.ApplicationId,
                        principalTable: "Applications",
                        principalColumn: "ApplicationId");
                });

            migrationBuilder.CreateTable(
                name: "Arts",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ArtName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    ImagePath = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: true),
                    ArtCategoryID = table.Column<int>(type: "int", nullable: true),
                    CreatedByCaption = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: true),
                    IsDelete = table.Column<bool>(type: "bit", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Arts", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Arts_ArtCategories",
                        column: x => x.ArtCategoryID,
                        principalTable: "ArtCategories",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "States",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StateCode = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true),
                    StateName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    CountryID = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((1))"),
                    IsDelete = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))"),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_States", x => x.ID);
                    table.ForeignKey(
                        name: "FK_States_Countries",
                        column: x => x.CountryID,
                        principalTable: "Countries",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DesignProductImages",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DesignProductID = table.Column<long>(type: "bigint", nullable: false),
                    OriginalImageID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CanvasTypeID = table.Column<byte>(type: "tinyint", nullable: true),
                    WorkArea = table.Column<decimal>(type: "decimal(15,3)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: true),
                    IsDelete = table.Column<bool>(type: "bit", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DesignProductImages", x => x.ID);
                    table.ForeignKey(
                        name: "FK_DesignProductImages_CanvasTypes",
                        column: x => x.CanvasTypeID,
                        principalTable: "CanvasTypes",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_DesignProductImages_DesignProducts",
                        column: x => x.DesignProductID,
                        principalTable: "DesignProducts",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "CategoryFilters",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryID = table.Column<int>(type: "int", nullable: true),
                    FilterID = table.Column<int>(type: "int", nullable: true),
                    Rank = table.Column<short>(type: "smallint", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: true),
                    Remark = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoryFilters", x => x.ID);
                    table.ForeignKey(
                        name: "FK_CategoryFilters_Categories",
                        column: x => x.CategoryID,
                        principalTable: "Categories",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_CategoryFilters_Filters",
                        column: x => x.FilterID,
                        principalTable: "Filters",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "FooterSectionLinks",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FooterSectionID = table.Column<int>(type: "int", nullable: false),
                    FooterSectionLinkCaption = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    URL = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    Order = table.Column<short>(type: "smallint", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: true),
                    IsDelete = table.Column<bool>(type: "bit", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FooterSectionLinks", x => x.ID);
                    table.ForeignKey(
                        name: "FK_FooterSectionLinks_FooterSections",
                        column: x => x.FooterSectionID,
                        principalTable: "FooterSections",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "BrandImages",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "(newid())"),
                    BrandID = table.Column<int>(type: "int", nullable: false),
                    ImageID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsDefault = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BrandImages", x => x.ID);
                    table.ForeignKey(
                        name: "FK_BrandImages_Brands1",
                        column: x => x.BrandID,
                        principalTable: "Brands",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BrandImages_Images1",
                        column: x => x.ImageID,
                        principalTable: "Images",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CategoryImages",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CategoryID = table.Column<int>(type: "int", nullable: false),
                    ImageID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ImageOrderNo = table.Column<int>(type: "int", nullable: true),
                    IsDefaultImage = table.Column<bool>(type: "bit", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: true),
                    IsDelete = table.Column<bool>(type: "bit", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoryImages", x => x.ID);
                    table.ForeignKey(
                        name: "FK_CategoryImages_Categories",
                        column: x => x.CategoryID,
                        principalTable: "Categories",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CategoryImages_Images",
                        column: x => x.ImageID,
                        principalTable: "Images",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Contents",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SubTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImageID = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ImageCaption = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    Align = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    DisplaySize = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    Height = table.Column<int>(type: "int", nullable: true),
                    Width = table.Column<int>(type: "int", nullable: true),
                    DisplayOrder = table.Column<int>(type: "int", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((1))"),
                    IsDelete = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))"),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contents", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Contents_Images",
                        column: x => x.ImageID,
                        principalTable: "Images",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "Discounts",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DiscountName = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    Discription = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: true),
                    ImageID = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    StartDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    EndDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((1))"),
                    IsDelete = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))"),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Discounts", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Discounts_Images",
                        column: x => x.ImageID,
                        principalTable: "Images",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "MailAttachments",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MailID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DocumentID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: true),
                    IsDelete = table.Column<bool>(type: "bit", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MailAttachments", x => x.ID);
                    table.ForeignKey(
                        name: "FK_MailAttachments_Documents",
                        column: x => x.DocumentID,
                        principalTable: "Documents",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_MailAttachments_Mails",
                        column: x => x.MailID,
                        principalTable: "Mails",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "MailQueues",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MailID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    IsDelivered = table.Column<bool>(type: "bit", nullable: true),
                    SendDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: true),
                    IsDelete = table.Column<bool>(type: "bit", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MailQueues", x => x.ID);
                    table.ForeignKey(
                        name: "FK_MailQueus_Mails",
                        column: x => x.MailID,
                        principalTable: "Mails",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "MailResources",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MailID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ImageID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MailResources", x => x.ID);
                    table.ForeignKey(
                        name: "FK_MailResources_Images",
                        column: x => x.ImageID,
                        principalTable: "Images",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_MailResources_Mails",
                        column: x => x.MailID,
                        principalTable: "Mails",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "Notifications",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NotificationText = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NotificationTypeID = table.Column<short>(type: "smallint", nullable: true),
                    RefID = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ImagePath1 = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    ImagePath2 = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    IsRead = table.Column<bool>(type: "bit", nullable: true),
                    RedirectURL = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: true),
                    IsDelete = table.Column<bool>(type: "bit", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notifications", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Notifications_NotificationTypes",
                        column: x => x.NotificationTypeID,
                        principalTable: "NotificationTypes",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "AdminMenus",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Caption = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    PageID = table.Column<int>(type: "int", nullable: true),
                    ParentMenuID = table.Column<int>(type: "int", nullable: true),
                    ImagePath = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    Order = table.Column<short>(type: "smallint", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((1))"),
                    IsDelete = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))"),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdminMenus", x => x.ID);
                    table.ForeignKey(
                        name: "FK_AdminMenues_AdminMenues",
                        column: x => x.ParentMenuID,
                        principalTable: "AdminMenus",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_AdminMenus_Pages",
                        column: x => x.PageID,
                        principalTable: "Pages",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "PaymentMethods",
                columns: table => new
                {
                    ID = table.Column<short>(type: "smallint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PaymentMethodName = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    Code = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ImagePath = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    PaymentMethodTypeID = table.Column<short>(type: "smallint", nullable: true),
                    PaymentPluginID = table.Column<int>(type: "int", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((1))"),
                    IsDelete = table.Column<bool>(type: "bit", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentMethods", x => x.ID);
                    table.ForeignKey(
                        name: "FK_PaymentMethods_PaymentGateways",
                        column: x => x.PaymentMethodTypeID,
                        principalTable: "PaymentMethodTypes",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_PaymentMethods_PaymentPlugins",
                        column: x => x.PaymentPluginID,
                        principalTable: "PaymentPlugins",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "SalesHistoryTransactions",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SalesID = table.Column<long>(type: "bigint", nullable: true),
                    SalesStausID = table.Column<short>(type: "smallint", nullable: true),
                    IsCustomerNotify = table.Column<bool>(type: "bit", nullable: true),
                    TransactionDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: true),
                    IsDelete = table.Column<bool>(type: "bit", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SalesHistoryTransactions", x => x.ID);
                    table.ForeignKey(
                        name: "FK_SalesHistoryTransactions_SalesStatus",
                        column: x => x.SalesStausID,
                        principalTable: "SalesStatus",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "CategorySpecificationGroupsSpecifications",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryID = table.Column<int>(type: "int", nullable: true),
                    SpecificationGroupID = table.Column<int>(type: "int", nullable: true),
                    SpecificationID = table.Column<int>(type: "int", nullable: true),
                    IsFilter = table.Column<bool>(type: "bit", nullable: true),
                    FilterRank = table.Column<int>(type: "int", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((1))"),
                    IsDelete = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))"),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategorySpecificationGroupsSpecifications", x => x.ID);
                    table.ForeignKey(
                        name: "FK_CategorySpecificaionGroups_Specifications",
                        column: x => x.SpecificationID,
                        principalTable: "Specifications",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_CategorySpecificaions_CategorySpecificaions",
                        column: x => x.CategoryID,
                        principalTable: "Categories",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CategorySpecificaions_SpecificationGroups",
                        column: x => x.SpecificationGroupID,
                        principalTable: "SpecificationGroups",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "SpecificatonGroupSpecifications",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SpecificationGroupID = table.Column<int>(type: "int", nullable: false),
                    SpecificationID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SpecificatonGroupSpecifications", x => x.ID);
                    table.ForeignKey(
                        name: "FK_SpecificatonGroupSpecifications_Specifications",
                        column: x => x.SpecificationID,
                        principalTable: "Specifications",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_SpecificatonGroupSpecifications_SpecificatonGroupSpecifications",
                        column: x => x.SpecificationGroupID,
                        principalTable: "SpecificationGroups",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "DesignProductOrders",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DesignProductID = table.Column<long>(type: "bigint", nullable: true),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    SizeCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    TextPropertyID1 = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    TextPropertyID2 = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    TextPropertyID3 = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    TextPropertyID4 = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    UnitID = table.Column<short>(type: "smallint", nullable: true),
                    Quantity = table.Column<decimal>(type: "decimal(15,3)", nullable: true),
                    Price = table.Column<decimal>(type: "decimal(15,3)", nullable: true),
                    IsGroupOrder = table.Column<bool>(type: "bit", nullable: true),
                    IsDelivered = table.Column<bool>(type: "bit", nullable: true),
                    TransactionDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: true),
                    IsDelete = table.Column<bool>(type: "bit", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DesignProductOrders", x => x.ID);
                    table.ForeignKey(
                        name: "FK_DesignProductOrders_DesignProductOrders",
                        column: x => x.DesignProductID,
                        principalTable: "DesignProducts",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_DesignProductOrders_TextProperties",
                        column: x => x.TextPropertyID1,
                        principalTable: "TextProperties",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_DesignProductOrders_TextProperties1",
                        column: x => x.TextPropertyID2,
                        principalTable: "TextProperties",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_DesignProductOrders_TextProperties2",
                        column: x => x.TextPropertyID3,
                        principalTable: "TextProperties",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_DesignProductOrders_TextProperties3",
                        column: x => x.TextPropertyID4,
                        principalTable: "TextProperties",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "SMSTopics",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SMSID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TopicID = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: true),
                    IsDelete = table.Column<bool>(type: "bit", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SMSTopics", x => x.ID);
                    table.ForeignKey(
                        name: "FK_SMSTopics_SMS",
                        column: x => x.SMSID,
                        principalTable: "SMS",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_SMSTopics_Topics",
                        column: x => x.TopicID,
                        principalTable: "Topics",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "Prices",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Caption = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    UnitID = table.Column<short>(type: "smallint", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(15,3)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Prices", x => x.ID);
                    table.ForeignKey(
                        name: "FK_ProductPrices_Units",
                        column: x => x.UnitID,
                        principalTable: "Units",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "CategoryUsageTypes",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryID = table.Column<int>(type: "int", nullable: true),
                    UsageTypeID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoryUsageTypes", x => x.ID);
                    table.ForeignKey(
                        name: "FK_CategoryUsageTypes_Categories",
                        column: x => x.CategoryID,
                        principalTable: "Categories",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CategoryUsageTypes_UsageTypes",
                        column: x => x.UsageTypeID,
                        principalTable: "UsageTypes",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProductCode = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ProductName = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    ProductTypeID = table.Column<short>(type: "smallint", nullable: true),
                    StockTypeID = table.Column<short>(type: "smallint", nullable: true),
                    ManufactureID = table.Column<int>(type: "int", nullable: true),
                    ProductSetID = table.Column<long>(type: "bigint", nullable: true),
                    UsageTypeID = table.Column<int>(type: "int", nullable: true),
                    LinkURL = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    UnitID = table.Column<short>(type: "smallint", nullable: true),
                    Quantity = table.Column<int>(type: "int", nullable: true),
                    Price = table.Column<decimal>(type: "decimal(15,3)", nullable: true),
                    MinOrderQuantity = table.Column<int>(type: "int", nullable: true),
                    MaxOrderQuantity = table.Column<int>(type: "int", nullable: true),
                    SKUID = table.Column<short>(type: "smallint", nullable: true),
                    Rating = table.Column<decimal>(type: "decimal(5,3)", nullable: true),
                    BrandID = table.Column<int>(type: "int", nullable: true),
                    CategoryID = table.Column<int>(type: "int", nullable: true),
                    LaunchDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    Popularity = table.Column<int>(type: "int", nullable: true),
                    IsNew = table.Column<bool>(type: "bit", nullable: true),
                    IsCOD = table.Column<bool>(type: "bit", nullable: true),
                    IsEMI = table.Column<bool>(type: "bit", nullable: true),
                    IsTaxable = table.Column<bool>(type: "bit", nullable: true),
                    IsSubscribable = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))"),
                    StockQuantity = table.Column<int>(type: "int", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((1))"),
                    IsDelete = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))"),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Products_Brands",
                        column: x => x.BrandID,
                        principalTable: "Brands",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Products_Categories",
                        column: x => x.CategoryID,
                        principalTable: "Categories",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Products_ProductSets",
                        column: x => x.ProductSetID,
                        principalTable: "ProductSets",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Products_ProductTypes",
                        column: x => x.ProductTypeID,
                        principalTable: "ProductTypes",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Products_StockTypes",
                        column: x => x.StockTypeID,
                        principalTable: "StockTypes",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Products_Units",
                        column: x => x.UnitID,
                        principalTable: "Units",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Products_Units1",
                        column: x => x.SKUID,
                        principalTable: "Units",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Products_UsageTypes",
                        column: x => x.UsageTypeID,
                        principalTable: "UsageTypes",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "UserFlags",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FlagName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    FlagGroupID = table.Column<int>(type: "int", nullable: false),
                    Caption = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    Description = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: true),
                    ToolTip = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    ValueTypeID = table.Column<int>(type: "int", nullable: false),
                    ValueList = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DefaultValue = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AutoRender = table.Column<bool>(type: "bit", nullable: true),
                    DisplayOrder = table.Column<int>(type: "int", nullable: true),
                    Limit = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: true),
                    IsDelete = table.Column<bool>(type: "bit", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserFlags", x => x.ID);
                    table.ForeignKey(
                        name: "FK_UserFlags_FlagGroups",
                        column: x => x.FlagGroupID,
                        principalTable: "FlagGroups",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_UserFlags_ValueTypes",
                        column: x => x.ValueTypeID,
                        principalTable: "ValueTypes",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "RolePages",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PageID = table.Column<int>(type: "int", nullable: false),
                    Permission = table.Column<string>(type: "char(5)", unicode: false, fixedLength: true, maxLength: 5, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RolePages", x => x.ID);
                    table.ForeignKey(
                        name: "FK_RolePages_Pages",
                        column: x => x.PageID,
                        principalTable: "Pages",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_RolePages_Roles",
                        column: x => x.RoleID,
                        principalTable: "Roles",
                        principalColumn: "RoleId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Memberships",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ApplicationId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    PasswordFormat = table.Column<int>(type: "int", nullable: false),
                    PasswordSalt = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    PasswordQuestion = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    PasswordAnswer = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: true),
                    IsApproved = table.Column<bool>(type: "bit", nullable: false),
                    IsLockedOut = table.Column<bool>(type: "bit", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    LastLoginDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    LastPasswordChangedDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    LastLockoutDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    FailedPasswordAttemptCount = table.Column<int>(type: "int", nullable: false),
                    FailedPasswordAttemptWindowStart = table.Column<DateTime>(type: "datetime", nullable: false),
                    FailedPasswordAnswerAttemptCount = table.Column<int>(type: "int", nullable: false),
                    FailedPasswordAnswerAttemptWindowsStart = table.Column<DateTime>(type: "datetime", nullable: false),
                    Comment = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Membersh__1788CC4C31FFB006", x => x.UserId);
                    table.ForeignKey(
                        name: "MembershipApplication",
                        column: x => x.ApplicationId,
                        principalTable: "Applications",
                        principalColumn: "ApplicationId");
                    table.ForeignKey(
                        name: "MembershipUser",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId");
                });

            migrationBuilder.CreateTable(
                name: "Profiles",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PropertyNames = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: false),
                    PropertyValueStrings = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: false),
                    PropertyValueBinary = table.Column<byte[]>(type: "image", nullable: false),
                    LastUpdatedDate = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Profiles__1788CC4C300B4ED8", x => x.UserId);
                    table.ForeignKey(
                        name: "UserProfile",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId");
                });

            migrationBuilder.CreateTable(
                name: "UserDetails",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    MiddleName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Birthdate = table.Column<DateTime>(type: "date", nullable: true),
                    Gender = table.Column<string>(type: "nvarchar(6)", maxLength: 6, nullable: true),
                    ProofTypeID = table.Column<int>(type: "int", nullable: true),
                    ProofNo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ProfilePicPath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserTypeID = table.Column<short>(type: "smallint", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: true),
                    IsDelete = table.Column<bool>(type: "bit", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserDetails", x => x.UserId);
                    table.ForeignKey(
                        name: "FK_UserDetails_ProofTypes",
                        column: x => x.ProofTypeID,
                        principalTable: "ProofTypes",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_UserDetails_Users",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserDetails_UserTypes",
                        column: x => x.UserTypeID,
                        principalTable: "UserTypes",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "UsersInRoles",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__UsersInR__AF2760AD3E1F151E", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "UsersInRoleRole",
                        column: x => x.RoleId,
                        principalTable: "Roles",
                        principalColumn: "RoleId");
                    table.ForeignKey(
                        name: "UsersInRoleUser",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId");
                });

            migrationBuilder.CreateTable(
                name: "ArtProperties",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ArtID = table.Column<int>(type: "int", nullable: false),
                    TypeOfImage = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Rotation = table.Column<short>(type: "smallint", nullable: true),
                    RotationPoint = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Color = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Width = table.Column<short>(type: "smallint", nullable: true),
                    Height = table.Column<short>(type: "smallint", nullable: true),
                    PositionX = table.Column<short>(type: "smallint", nullable: true),
                    PositionY = table.Column<short>(type: "smallint", nullable: true),
                    OriginalPositionX = table.Column<short>(type: "smallint", nullable: true),
                    OriginalPositionY = table.Column<short>(type: "smallint", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: true),
                    IsDelete = table.Column<bool>(type: "bit", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArtProperties", x => x.ID);
                    table.ForeignKey(
                        name: "FK_ArtProperties_Arts",
                        column: x => x.ArtID,
                        principalTable: "Arts",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "Cities",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CountryID = table.Column<int>(type: "int", nullable: true),
                    StateID = table.Column<int>(type: "int", nullable: true),
                    CityName = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    PostalCode = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    MetrocityID = table.Column<int>(type: "int", nullable: true),
                    MetroCity = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    Latitude = table.Column<decimal>(type: "decimal(9,6)", nullable: true),
                    Longitude = table.Column<decimal>(type: "decimal(9,6)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((1))"),
                    IsDelete = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))"),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cities", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Cities_Countries",
                        column: x => x.CountryID,
                        principalTable: "Countries",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Cities_MetroCities",
                        column: x => x.MetrocityID,
                        principalTable: "MetroCities",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Cities_States",
                        column: x => x.StateID,
                        principalTable: "States",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CMSPageContents",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CMSPageID = table.Column<int>(type: "int", nullable: false),
                    PageHeading = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContentID = table.Column<int>(type: "int", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((1))"),
                    IsDelete = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))"),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CMSPageContents", x => x.ID);
                    table.ForeignKey(
                        name: "FK_CMSPageContents_CMSPages",
                        column: x => x.CMSPageID,
                        principalTable: "CMSPages",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_PageContents_Contents",
                        column: x => x.ContentID,
                        principalTable: "Contents",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "DiscountOptioins",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DiscountID = table.Column<int>(type: "int", nullable: true),
                    Caption = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    MinBreakPoint = table.Column<int>(type: "int", nullable: true),
                    MaxBreakPoin = table.Column<int>(type: "int", nullable: true),
                    DiscountValueTypeID = table.Column<byte>(type: "tinyint", nullable: true),
                    DiscountValue = table.Column<decimal>(type: "decimal(15,3)", nullable: true),
                    Priority = table.Column<byte>(type: "tinyint", nullable: true),
                    BreakPointCode = table.Column<string>(type: "char(5)", unicode: false, fixedLength: true, maxLength: 5, nullable: true),
                    Note = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: true),
                    IsDelete = table.Column<bool>(type: "bit", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DiscountOptioins", x => x.ID);
                    table.ForeignKey(
                        name: "FK_DiscountOptioins_Discounts",
                        column: x => x.DiscountID,
                        principalTable: "Discounts",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_DiscountOptioins_DiscountValueTypes",
                        column: x => x.DiscountValueTypeID,
                        principalTable: "DiscountValueTypes",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "ProductSetProducts",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProductSetID = table.Column<long>(type: "bigint", nullable: true),
                    ProductID = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: true),
                    IsDelete = table.Column<bool>(type: "bit", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductSetProducts", x => x.ID);
                    table.ForeignKey(
                        name: "FK_ProductSetProducts_Products",
                        column: x => x.ProductID,
                        principalTable: "Products",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductSetProducts_ProdutSets",
                        column: x => x.ProductSetID,
                        principalTable: "ProductSets",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "ProductSpecifications",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProductID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SpecificationGroupID = table.Column<int>(type: "int", nullable: true),
                    SpecificationID = table.Column<int>(type: "int", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((1))"),
                    IsDelete = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))"),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductSpecifications", x => x.ID);
                    table.ForeignKey(
                        name: "FK_ProductSpecifications_Products",
                        column: x => x.ProductID,
                        principalTable: "Products",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductSpecifications_SpecificationGroups",
                        column: x => x.SpecificationGroupID,
                        principalTable: "SpecificationGroups",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_ProductSpecifications_Specifications",
                        column: x => x.SpecificationID,
                        principalTable: "Specifications",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductTaxs",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductID = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    TaxID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductTaxs", x => x.ID);
                    table.ForeignKey(
                        name: "FK_ProductTaxs_Products",
                        column: x => x.ProductID,
                        principalTable: "Products",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_ProductTaxs_Taxs",
                        column: x => x.TaxID,
                        principalTable: "Taxs",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "ProductVariations",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProductID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Caption = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    Rating = table.Column<decimal>(type: "decimal(15,3)", nullable: true),
                    Popularity = table.Column<int>(type: "int", nullable: true),
                    ProductAssociationID = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ProductVariationList = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsVariation = table.Column<bool>(type: "bit", nullable: true),
                    IsDefaultProductVariation = table.Column<bool>(type: "bit", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((1))"),
                    IsDelete = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))"),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductVariations", x => x.ID);
                    table.ForeignKey(
                        name: "FK_ProductVariations_ProductAssociations",
                        column: x => x.ProductAssociationID,
                        principalTable: "ProductAssociations",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_ProductVariations_Products",
                        column: x => x.ProductID,
                        principalTable: "Products",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "ProductVariationValues",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProductID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    VariationID = table.Column<int>(type: "int", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductVariationValues", x => x.ID);
                    table.ForeignKey(
                        name: "FK_ProductVariationValues_Products",
                        column: x => x.ProductID,
                        principalTable: "Products",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_ProductVariationValues_Variations",
                        column: x => x.VariationID,
                        principalTable: "Variations",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "SEOContents",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProductID = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CategoryID = table.Column<int>(type: "int", nullable: true),
                    BrandID = table.Column<int>(type: "int", nullable: true),
                    MetaTitles = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    MetaKeywords = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    MetaDescription = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: true),
                    IsDelete = table.Column<bool>(type: "bit", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SEOContents", x => x.ID);
                    table.ForeignKey(
                        name: "FK_SEOContents_Brands",
                        column: x => x.BrandID,
                        principalTable: "Brands",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_SEOContents_Category",
                        column: x => x.CategoryID,
                        principalTable: "Categories",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SEOContents_Products",
                        column: x => x.ProductID,
                        principalTable: "Products",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "TopicMails",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MailID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TopicID = table.Column<int>(type: "int", nullable: true),
                    ProductID = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CategoryID = table.Column<int>(type: "int", nullable: true),
                    BrandID = table.Column<int>(type: "int", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: true),
                    IsDelete = table.Column<bool>(type: "bit", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TopicMails", x => x.ID);
                    table.ForeignKey(
                        name: "FK_TopicMails_Brands",
                        column: x => x.BrandID,
                        principalTable: "Brands",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_TopicMails_Categories",
                        column: x => x.CategoryID,
                        principalTable: "Categories",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_TopicMails_Mails",
                        column: x => x.MailID,
                        principalTable: "Mails",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_TopicMails_Products",
                        column: x => x.ProductID,
                        principalTable: "Products",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_TopicMails_Topics",
                        column: x => x.TopicID,
                        principalTable: "Topics",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "Feedbacks",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FeedbackCategoryID = table.Column<short>(type: "smallint", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    IPAddress = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    ContactNo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    UserRating = table.Column<byte>(type: "tinyint", nullable: true),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Priority = table.Column<byte>(type: "tinyint", nullable: true),
                    IsUnread = table.Column<bool>(type: "bit", nullable: true),
                    ActionID = table.Column<int>(type: "int", nullable: true),
                    ActionDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ActionDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ActionBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: true),
                    IsDelete = table.Column<bool>(type: "bit", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Feedbacks", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Feedbacks_FeedbackActions",
                        column: x => x.ActionID,
                        principalTable: "FeedbackActions",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Feedbacks_FeedbackInquiryCategories",
                        column: x => x.FeedbackCategoryID,
                        principalTable: "FeedbackInquiryCategories",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Feedbacks_UserDetails",
                        column: x => x.ActionBy,
                        principalTable: "UserDetails",
                        principalColumn: "UserId");
                });

            migrationBuilder.CreateTable(
                name: "Inquiries",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    InquiryCategoryID = table.Column<short>(type: "smallint", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ResponderUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    ContactNo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Priority = table.Column<byte>(type: "tinyint", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((1))"),
                    IsDelete = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))"),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Inquiries", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Inquiries_FeedbackInquiryCategories",
                        column: x => x.InquiryCategoryID,
                        principalTable: "FeedbackInquiryCategories",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Inquiries_UserDetails",
                        column: x => x.UserId,
                        principalTable: "UserDetails",
                        principalColumn: "UserId");
                    table.ForeignKey(
                        name: "FK_Inquiries_UserDetails1",
                        column: x => x.ResponderUserId,
                        principalTable: "UserDetails",
                        principalColumn: "UserId");
                });

            migrationBuilder.CreateTable(
                name: "SMSQueues",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    SMSID = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsDelivered = table.Column<bool>(type: "bit", nullable: true),
                    SendDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: true),
                    IsDelete = table.Column<bool>(type: "bit", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SMSQueues", x => x.ID);
                    table.ForeignKey(
                        name: "FK_SMSQueues_SMSQueues",
                        column: x => x.SMSID,
                        principalTable: "SMS",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_SMSQueues_UserDetails",
                        column: x => x.UserId,
                        principalTable: "UserDetails",
                        principalColumn: "UserId");
                });

            migrationBuilder.CreateTable(
                name: "SystemFlags",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SystemFlagName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    FlagGroupID = table.Column<int>(type: "int", nullable: false),
                    Caption = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: true),
                    Description = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: true),
                    ToolTip = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: true),
                    ValueTypeID = table.Column<int>(type: "int", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ValueList = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DefaultValue = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedByUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Limit = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AutoRender = table.Column<bool>(type: "bit", nullable: true),
                    DisplayOrder = table.Column<int>(type: "int", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((1))"),
                    IsDelete = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))"),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SystemFlags", x => x.ID);
                    table.ForeignKey(
                        name: "FK_SystemFlags_FlagGroups",
                        column: x => x.FlagGroupID,
                        principalTable: "FlagGroups",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_SystemFlags_UserDetails",
                        column: x => x.ModifiedByUserId,
                        principalTable: "UserDetails",
                        principalColumn: "UserId");
                    table.ForeignKey(
                        name: "FK_SystemFlags_ValueTypes",
                        column: x => x.ValueTypeID,
                        principalTable: "ValueTypes",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "Tokens",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Token = table.Column<string>(type: "varchar(128)", unicode: false, maxLength: 128, nullable: false),
                    ExpiryDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    IsUsed = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tokens", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Tokens_UserDetails",
                        column: x => x.UserId,
                        principalTable: "UserDetails",
                        principalColumn: "UserId");
                });

            migrationBuilder.CreateTable(
                name: "UserContacts",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ContactTypeID = table.Column<short>(type: "smallint", nullable: false),
                    CountryCode = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true),
                    ContactNo = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: true),
                    Priority = table.Column<byte>(type: "tinyint", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((1))"),
                    IsDelete = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))"),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserContacts", x => x.ID);
                    table.ForeignKey(
                        name: "FK_UserContacts_ContactTypes",
                        column: x => x.ContactTypeID,
                        principalTable: "ContactTypes",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_UserContacts_UserDetails",
                        column: x => x.UserId,
                        principalTable: "UserDetails",
                        principalColumn: "UserId");
                });

            migrationBuilder.CreateTable(
                name: "UserFlagValues",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserFlagID = table.Column<int>(type: "int", nullable: true),
                    UserFlagValue = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((1))"),
                    IsDelete = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))"),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserFlagValues", x => x.ID);
                    table.ForeignKey(
                        name: "FK_UserFlagValues_UserDetails",
                        column: x => x.UserId,
                        principalTable: "UserDetails",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserFlagValues_UserFlagValues",
                        column: x => x.UserFlagID,
                        principalTable: "UserFlags",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "UserLogs",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ActivityTypeID = table.Column<short>(type: "smallint", nullable: false),
                    ActivityTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    IPAddress = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    MachineID = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    UserAgent = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((1))"),
                    IsDelete = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))"),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserLogs", x => x.ID);
                    table.ForeignKey(
                        name: "FK_UserLogs_ActivityTypes",
                        column: x => x.ActivityTypeID,
                        principalTable: "ActivityTypes",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_UserLogs_UserDetails",
                        column: x => x.UserId,
                        principalTable: "UserDetails",
                        principalColumn: "UserId");
                });

            migrationBuilder.CreateTable(
                name: "UserPropertyValues",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserPropertyID = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserPropertyValues", x => x.ID);
                    table.ForeignKey(
                        name: "FK_UserPropertyValues_UserProperties",
                        column: x => x.UserPropertyID,
                        principalTable: "UserProperties",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_UserPropertyValues_Users",
                        column: x => x.UserId,
                        principalTable: "UserDetails",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UsersOAuthAccounts",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ProviderUserID = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    ProviderUserName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    UserProfilePicPath = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    OAuthProviderID = table.Column<int>(type: "int", nullable: false),
                    LastUsedUtc = table.Column<DateTime>(type: "datetime", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((1))"),
                    IsDelete = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))"),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UsersOAuthAccounts", x => x.ID);
                    table.ForeignKey(
                        name: "FK_UsersOAuthAccounts_OAuthProviders",
                        column: x => x.OAuthProviderID,
                        principalTable: "OAuthProviders",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_UsersOAuthAccounts_UserDetails",
                        column: x => x.UserId,
                        principalTable: "UserDetails",
                        principalColumn: "UserId");
                });

            migrationBuilder.CreateTable(
                name: "UsersOAuthData",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsLocalAccountActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UsersOAuthData", x => x.UserId);
                    table.ForeignKey(
                        name: "FK_UsersOAuthData_UserDetails",
                        column: x => x.UserId,
                        principalTable: "UserDetails",
                        principalColumn: "UserId");
                });

            migrationBuilder.CreateTable(
                name: "UserSubscriptions",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserID = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    Mobile = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    TopicID = table.Column<int>(type: "int", nullable: true),
                    ProductID = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    BrandID = table.Column<int>(type: "int", nullable: true),
                    CategoryID = table.Column<int>(type: "int", nullable: true),
                    Daily = table.Column<int>(type: "int", nullable: true),
                    Weekly = table.Column<int>(type: "int", nullable: true),
                    Monthly = table.Column<int>(type: "int", nullable: true),
                    Weekends = table.Column<int>(type: "int", nullable: true),
                    IsRegister = table.Column<bool>(type: "bit", nullable: true),
                    StartDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ExpireDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsEmailSubscriber = table.Column<bool>(type: "bit", nullable: true),
                    IsSMSSubscriber = table.Column<bool>(type: "bit", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: true),
                    IsDelete = table.Column<bool>(type: "bit", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserSubscriptions", x => x.ID);
                    table.ForeignKey(
                        name: "FK_UserSubscriptions_Brands",
                        column: x => x.BrandID,
                        principalTable: "Brands",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_UserSubscriptions_Categories",
                        column: x => x.CategoryID,
                        principalTable: "Categories",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_UserSubscriptions_Products",
                        column: x => x.ProductID,
                        principalTable: "Products",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_UserSubscriptions_Topics",
                        column: x => x.TopicID,
                        principalTable: "Topics",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_UserSubscriptions_UserDetails",
                        column: x => x.UserID,
                        principalTable: "UserDetails",
                        principalColumn: "UserId");
                });

            migrationBuilder.CreateTable(
                name: "DesignProductImageRecepies",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DesignProductImageID = table.Column<long>(type: "bigint", nullable: true),
                    TextPropertyID = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ArtPropertyID = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DisplayPriority = table.Column<short>(type: "smallint", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: true),
                    IsDelete = table.Column<bool>(type: "bit", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DesignProductImageRecepies", x => x.ID);
                    table.ForeignKey(
                        name: "FK_DesignProductImageRecepies_ArtProperties",
                        column: x => x.ArtPropertyID,
                        principalTable: "ArtProperties",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_DesignProductImageRecepies_DesignProductImageRecepies",
                        column: x => x.TextPropertyID,
                        principalTable: "TextProperties",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_DesignProductImageRecepies_DesignProductImages",
                        column: x => x.DesignProductImageID,
                        principalTable: "DesignProductImages",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "Addresses",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AddressTypeID = table.Column<int>(type: "int", nullable: false),
                    AddressLabelName = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: true),
                    AddressPersonName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    AddressLine1 = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: true),
                    AddressLine2 = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: true),
                    CityID = table.Column<int>(type: "int", nullable: true),
                    StateID = table.Column<int>(type: "int", nullable: true),
                    CountryID = table.Column<int>(type: "int", nullable: true),
                    ZipCode = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    IsDefault = table.Column<bool>(type: "bit", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((1))"),
                    IsDelete = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))"),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Addresses", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Addresses_AddressTypes",
                        column: x => x.AddressTypeID,
                        principalTable: "AddressTypes",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Addresses_Cities",
                        column: x => x.CityID,
                        principalTable: "Cities",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Addresses_Countries",
                        column: x => x.CountryID,
                        principalTable: "Countries",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Addresses_States",
                        column: x => x.StateID,
                        principalTable: "States",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "ShipmentOffers",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    OfferName = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    CountryID = table.Column<int>(type: "int", nullable: true),
                    StateID = table.Column<int>(type: "int", nullable: true),
                    MetrocityID = table.Column<int>(type: "int", nullable: true),
                    CityID = table.Column<int>(type: "int", nullable: true),
                    StartDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    EndDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: true),
                    IsDelete = table.Column<bool>(type: "bit", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShipmentOffers", x => x.ID);
                    table.ForeignKey(
                        name: "FK_ShipmentOffers_Cities",
                        column: x => x.CityID,
                        principalTable: "Cities",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_ShipmentOffers_Countries",
                        column: x => x.CountryID,
                        principalTable: "Countries",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_ShipmentOffers_MetroCities",
                        column: x => x.MetrocityID,
                        principalTable: "MetroCities",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_ShipmentOffers_States",
                        column: x => x.StateID,
                        principalTable: "States",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "ProductAssociationProductVariations",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProductAssociationID = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ProductVariationID = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((1))"),
                    IsDelete = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))"),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductAssociationProductVariations", x => x.ID);
                    table.ForeignKey(
                        name: "FK_ProductAssociationProductVariations_ProductAssociations",
                        column: x => x.ProductAssociationID,
                        principalTable: "ProductAssociations",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_ProductAssociationProductVariations_ProductVariations",
                        column: x => x.ProductVariationID,
                        principalTable: "ProductVariations",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "ProductDiscounts",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DiscountID = table.Column<int>(type: "int", nullable: true),
                    CategoryID = table.Column<int>(type: "int", nullable: true),
                    BrandID = table.Column<int>(type: "int", nullable: true),
                    ProductID = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ProductVariationID = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DiscountTypeID = table.Column<byte>(type: "tinyint", nullable: true),
                    DiscountOptionID = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((1))"),
                    IsDelete = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))"),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductDiscounts", x => x.ID);
                    table.ForeignKey(
                        name: "FK_ProductDiscounts_Brands",
                        column: x => x.BrandID,
                        principalTable: "Brands",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_ProductDiscounts_Categories",
                        column: x => x.CategoryID,
                        principalTable: "Categories",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_ProductDiscounts_DiscountOptioins",
                        column: x => x.DiscountOptionID,
                        principalTable: "DiscountOptioins",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_ProductDiscounts_Discounts",
                        column: x => x.DiscountID,
                        principalTable: "Discounts",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_ProductDiscounts_DiscountTypes",
                        column: x => x.DiscountTypeID,
                        principalTable: "DiscountTypes",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_ProductDiscounts_Products",
                        column: x => x.ProductID,
                        principalTable: "Products",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_ProductDiscounts_ProductVariations",
                        column: x => x.ProductVariationID,
                        principalTable: "ProductVariations",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_ProductDiscounts_UserDetails",
                        column: x => x.UserId,
                        principalTable: "UserDetails",
                        principalColumn: "UserId");
                });

            migrationBuilder.CreateTable(
                name: "ProductReviews",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProductID = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ProductVariationID = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    Rating = table.Column<byte>(type: "tinyint", nullable: true),
                    ReviewTitle = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: true),
                    ReviewDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsVarified = table.Column<bool>(type: "bit", nullable: true),
                    IsEvaluate = table.Column<bool>(type: "bit", nullable: true),
                    IsHelpfulCount = table.Column<int>(type: "int", nullable: true),
                    IsNotHelpfulCount = table.Column<int>(type: "int", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((1))"),
                    IsDelete = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))"),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    VarifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductReviews", x => x.ID);
                    table.ForeignKey(
                        name: "FK_ProductReviews_Products",
                        column: x => x.ProductID,
                        principalTable: "Products",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_ProductReviews_ProductVariations",
                        column: x => x.ProductVariationID,
                        principalTable: "ProductVariations",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_ProductReviews_UserDetails",
                        column: x => x.UserId,
                        principalTable: "UserDetails",
                        principalColumn: "UserId");
                    table.ForeignKey(
                        name: "FK_ProductReviews_UserDetails1",
                        column: x => x.VarifiedBy,
                        principalTable: "UserDetails",
                        principalColumn: "UserId");
                });

            migrationBuilder.CreateTable(
                name: "ProductStatitics",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ViewerCount = table.Column<int>(type: "int", nullable: true),
                    LikeCount = table.Column<int>(type: "int", nullable: true),
                    PaidPramotion = table.Column<int>(type: "int", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: true),
                    IsDelete = table.Column<bool>(type: "bit", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductStatitics", x => x.ID);
                    table.ForeignKey(
                        name: "FK_ProductStatitics_ProductVariations",
                        column: x => x.ID,
                        principalTable: "ProductVariations",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "ProductStocks",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProductVariationID = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Quantity = table.Column<int>(type: "int", nullable: true),
                    UnitID = table.Column<short>(type: "smallint", nullable: true),
                    LocationID = table.Column<int>(type: "int", nullable: true),
                    TransactionTypeID = table.Column<short>(type: "smallint", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductStocks", x => x.ID);
                    table.ForeignKey(
                        name: "FK_ProductStocks_ProductVariations",
                        column: x => x.ProductVariationID,
                        principalTable: "ProductVariations",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_ProductStocks_TransactionTypes",
                        column: x => x.TransactionTypeID,
                        principalTable: "TransactionTypes",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_ProductStocks_Units",
                        column: x => x.UnitID,
                        principalTable: "Units",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "ProductVariationImages",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProductVariationID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ImageID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ImageOrderNo = table.Column<int>(type: "int", nullable: true),
                    IsDefault = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductVariationImages", x => x.ID);
                    table.ForeignKey(
                        name: "FK_ProductVariationImages_Images",
                        column: x => x.ImageID,
                        principalTable: "Images",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_ProductVariationImages_ProductVariations1",
                        column: x => x.ProductVariationID,
                        principalTable: "ProductVariations",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "ProductVariationPrices",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProductVariationID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PriceID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Barcode = table.Column<string>(type: "nvarchar(32)", maxLength: 32, nullable: true),
                    IsBasePrice = table.Column<bool>(type: "bit", nullable: true),
                    IsDefaultPrice = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductVariationPrices", x => x.ID);
                    table.ForeignKey(
                        name: "FK_ProductVariationPrices_ProductPrices",
                        column: x => x.PriceID,
                        principalTable: "Prices",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_ProductVariationPrices_ProductVariations",
                        column: x => x.ProductVariationID,
                        principalTable: "ProductVariations",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "PurchaseOrderDetails",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    PurchaseOrderID = table.Column<long>(type: "bigint", nullable: true),
                    SrNo = table.Column<byte>(type: "tinyint", nullable: true),
                    ProductVariationID = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    PriceID = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Quantity = table.Column<int>(type: "int", nullable: true),
                    UnitID = table.Column<short>(type: "smallint", nullable: true),
                    Rate = table.Column<decimal>(type: "decimal(15,3)", nullable: true),
                    Amount = table.Column<decimal>(type: "decimal(15,3)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: true),
                    IsDelete = table.Column<bool>(type: "bit", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.ForeignKey(
                        name: "FK_PurchaseOrderDetails_ProductVariations",
                        column: x => x.ProductVariationID,
                        principalTable: "ProductVariations",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_PurchaseOrderDetails_PurchaseOrders",
                        column: x => x.PurchaseOrderID,
                        principalTable: "PurchaseOrders",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_PurchaseOrderDetails_Units",
                        column: x => x.UnitID,
                        principalTable: "Units",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "InquiryMessages",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    InquiryID = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Message = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserAgent = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    ImageID = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IPAddress = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    IsReplay = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((1))"),
                    IsDelete = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))"),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InquiryMessages", x => x.ID);
                    table.ForeignKey(
                        name: "FK_InquiryMessages_Inquiries",
                        column: x => x.ImageID,
                        principalTable: "Images",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_InquiryMessages_Inquiries1",
                        column: x => x.InquiryID,
                        principalTable: "Inquiries",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "PersonAccounts",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Code = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    EntityType = table.Column<bool>(type: "bit", nullable: true),
                    CompanyName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    CompanyRegistrationNo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    PersonName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    DisplayName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    Address1ID = table.Column<int>(type: "int", nullable: true),
                    Address2ID = table.Column<int>(type: "int", nullable: true),
                    Website = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    Telephone = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    PAN = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    TINNumber = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ServiceTaxNumber = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    FAX = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    IsSupplier = table.Column<bool>(type: "bit", nullable: true),
                    IsCustomer = table.Column<bool>(type: "bit", nullable: true),
                    BankAccountID = table.Column<int>(type: "int", nullable: true),
                    DebitLimit = table.Column<decimal>(type: "decimal(15,3)", nullable: true),
                    CreditLimit = table.Column<decimal>(type: "decimal(15,3)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: true),
                    IsDelete = table.Column<bool>(type: "bit", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonAccounts", x => x.ID);
                    table.ForeignKey(
                        name: "FK_PersonAccounts_Addresses",
                        column: x => x.Address1ID,
                        principalTable: "Addresses",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_PersonAccounts_Addresses1",
                        column: x => x.Address2ID,
                        principalTable: "Addresses",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_PersonAccounts_UserDetails",
                        column: x => x.UserId,
                        principalTable: "UserDetails",
                        principalColumn: "UserId");
                });

            migrationBuilder.CreateTable(
                name: "ShipmentAgents",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AddressID = table.Column<int>(type: "int", nullable: true),
                    ShipAgentTypeID = table.Column<short>(type: "smallint", nullable: true),
                    CompanyName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    Website = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    TrackingURL = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    ContactPersonName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    PersonContactNo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Priority = table.Column<short>(type: "smallint", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((1))"),
                    IsDelete = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))"),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShipmentAgents", x => x.ID);
                    table.ForeignKey(
                        name: "FK_ShipmentAgents_Addresses",
                        column: x => x.AddressID,
                        principalTable: "Addresses",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_ShipmentAgents_ShipmentAgentTypes",
                        column: x => x.ShipAgentTypeID,
                        principalTable: "ShipmentAgentTypes",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "UserAddresses",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    AddressID = table.Column<int>(type: "int", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((1))"),
                    IsDelete = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))"),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserAddresses", x => x.ID);
                    table.ForeignKey(
                        name: "FK_UserAddresses_UserAddresses",
                        column: x => x.AddressID,
                        principalTable: "Addresses",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_UserAddresses_UserDetails",
                        column: x => x.UserId,
                        principalTable: "UserDetails",
                        principalColumn: "UserId");
                });

            migrationBuilder.CreateTable(
                name: "ShipmentOfferConditions",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ShipmentOfferID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Caption = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MinOrderPrice = table.Column<decimal>(type: "decimal(15,3)", nullable: true),
                    MaxOrderPrice = table.Column<decimal>(type: "decimal(15,3)", nullable: true),
                    UnitID = table.Column<short>(type: "smallint", nullable: true),
                    MinOrderWeight = table.Column<decimal>(type: "decimal(15,3)", nullable: true),
                    MaxOrderWeight = table.Column<decimal>(type: "decimal(15,3)", nullable: true),
                    FixShipmentAmount = table.Column<decimal>(type: "decimal(15,3)", nullable: true),
                    ShipmentDiscountPercent = table.Column<decimal>(type: "decimal(15,3)", nullable: true),
                    FixShipmentDiscountAmount = table.Column<decimal>(type: "decimal(15,3)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: true),
                    IsDelete = table.Column<bool>(type: "bit", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShipmentOfferConditions", x => x.ID);
                    table.ForeignKey(
                        name: "FK_ShipmentOfferConditions_ShipmentOffers",
                        column: x => x.ShipmentOfferID,
                        principalTable: "ShipmentOffers",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_ShipmentOfferConditions_Units",
                        column: x => x.UnitID,
                        principalTable: "Units",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "Carts",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserID = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ProductVariationID = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Quantity = table.Column<double>(type: "float", nullable: true),
                    UnitID = table.Column<short>(type: "smallint", nullable: true),
                    PriceID = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Remark = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: true),
                    ProductDiscountID = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsWishList = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))"),
                    IsOrdered = table.Column<bool>(type: "bit", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((1))"),
                    IsDelete = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))"),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Carts", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Carts_Carts",
                        column: x => x.UnitID,
                        principalTable: "Units",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Carts_Prices",
                        column: x => x.PriceID,
                        principalTable: "Prices",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Carts_ProductDiscounts",
                        column: x => x.ProductDiscountID,
                        principalTable: "ProductDiscounts",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Carts_ProductVariations",
                        column: x => x.ProductVariationID,
                        principalTable: "ProductVariations",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Carts_UserDetails",
                        column: x => x.UserID,
                        principalTable: "UserDetails",
                        principalColumn: "UserId");
                });

            migrationBuilder.CreateTable(
                name: "HelpfulProductReviews",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductReviewID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsHelpful = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HelpfulProductReviews", x => x.ID);
                    table.ForeignKey(
                        name: "FK_HelpfulProductReviews_ProductReviews",
                        column: x => x.ProductReviewID,
                        principalTable: "ProductReviews",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_HelpfulProductReviews_UserDetails",
                        column: x => x.UserID,
                        principalTable: "UserDetails",
                        principalColumn: "UserId");
                });

            migrationBuilder.CreateTable(
                name: "ProductShipments",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProductVariatioinPriceID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsFreeShipment = table.Column<bool>(type: "bit", nullable: true),
                    ShipmentCharges = table.Column<decimal>(type: "decimal(15,3)", nullable: true),
                    UnitID = table.Column<short>(type: "smallint", nullable: true),
                    Weight = table.Column<decimal>(type: "decimal(15,3)", nullable: true),
                    Dimension = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductShipments", x => x.ID);
                    table.ForeignKey(
                        name: "FK_ProductShipments_ProductVariationPrices",
                        column: x => x.ProductVariatioinPriceID,
                        principalTable: "ProductVariationPrices",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_ProductShipments_Units",
                        column: x => x.UnitID,
                        principalTable: "Units",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "Purchases",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PurchaseBillNo = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    TransactionCode = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    PurchaseOrderNo = table.Column<int>(type: "int", nullable: true),
                    ExternalBillNo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    PersonAccountID = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CurrencyID = table.Column<int>(type: "int", nullable: true),
                    CurrencyValue = table.Column<decimal>(type: "decimal(5,3)", nullable: true),
                    IsGeneralPurchase = table.Column<bool>(type: "bit", nullable: true),
                    TotalQuantity = table.Column<int>(type: "int", nullable: true),
                    TotalAmount = table.Column<decimal>(type: "decimal(15,3)", nullable: true),
                    TotalDiscount = table.Column<decimal>(type: "decimal(15,3)", nullable: true),
                    TotalShipmentCharges = table.Column<decimal>(type: "decimal(15,3)", nullable: true),
                    OtherAdditions = table.Column<decimal>(type: "decimal(15,3)", nullable: true),
                    OtherDeductions = table.Column<decimal>(type: "decimal(15,3)", nullable: true),
                    NetPayable = table.Column<decimal>(type: "decimal(15,3)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: true),
                    PurchaseStatusID = table.Column<short>(type: "smallint", nullable: true),
                    TransactionDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: true),
                    IsDelete = table.Column<bool>(type: "bit", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Purchases", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Purchases_Currencies",
                        column: x => x.CurrencyID,
                        principalTable: "Currencies",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Purchases_PersonAccounts",
                        column: x => x.PersonAccountID,
                        principalTable: "PersonAccounts",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "SalesOrders",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SaleBillNo = table.Column<long>(type: "bigint", nullable: true),
                    PersonAccountID = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Series = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CurrencyID = table.Column<int>(type: "int", nullable: true),
                    CurrencyValue = table.Column<decimal>(type: "decimal(5,3)", nullable: true),
                    TotalQuantity = table.Column<int>(type: "int", nullable: true),
                    TotalAmount = table.Column<decimal>(type: "decimal(15,3)", nullable: true),
                    TotalDiscount = table.Column<decimal>(type: "decimal(15,3)", nullable: true),
                    TotalShipmentCharge = table.Column<decimal>(type: "decimal(15,3)", nullable: true),
                    OtherAdditions = table.Column<decimal>(type: "decimal(15,3)", nullable: true),
                    OtherDeductions = table.Column<decimal>(type: "decimal(15,3)", nullable: true),
                    NetPayable = table.Column<decimal>(type: "decimal(15,3)", nullable: true),
                    OrderStatusID = table.Column<byte>(type: "tinyint", nullable: true),
                    PaymentMethodID = table.Column<short>(type: "smallint", nullable: true),
                    BillingAddressID = table.Column<int>(type: "int", nullable: true),
                    ShippingAddressID = table.Column<int>(type: "int", nullable: true),
                    ShippingID = table.Column<long>(type: "bigint", nullable: true),
                    ShippingAgentID = table.Column<int>(type: "int", nullable: true),
                    ShippingAgentTokenID = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    IsDispatched = table.Column<bool>(type: "bit", nullable: true),
                    PaymentReceiveDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ShippmentDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    DeliveredDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    IsDelliver = table.Column<bool>(type: "bit", nullable: true),
                    IsPaymentMade = table.Column<bool>(type: "bit", nullable: true),
                    Descriptions = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((1))"),
                    IsDelete = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))"),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SalesOrders", x => x.ID);
                    table.ForeignKey(
                        name: "FK_SalesOrders_Currencies",
                        column: x => x.CurrencyID,
                        principalTable: "Currencies",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_SalesOrders_PersonAccounts",
                        column: x => x.PersonAccountID,
                        principalTable: "PersonAccounts",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "ShipmentAgentCourierServiceProviders",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ShipmentAgentID = table.Column<int>(type: "int", nullable: false),
                    CourierServiceProviderID = table.Column<int>(type: "int", nullable: false),
                    IsDefault = table.Column<bool>(type: "bit", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((1))"),
                    IsDelete = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))"),
                    CreatedDat = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShipmentAgentCourierServiceProviders", x => x.ID);
                    table.ForeignKey(
                        name: "FK_ShipmentAgentCourierServiceProviders_ShipmentAgentCourierServiceProviders",
                        column: x => x.CourierServiceProviderID,
                        principalTable: "ShipmentAgents",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_ShipmentAgentCourierServiceProviders_ShipmentAgents",
                        column: x => x.ShipmentAgentID,
                        principalTable: "ShipmentAgents",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "ShipmentAgentRegions",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ShipmentAgentID = table.Column<int>(type: "int", nullable: true),
                    CountryID = table.Column<int>(type: "int", nullable: true),
                    StateID = table.Column<int>(type: "int", nullable: true),
                    CityID = table.Column<int>(type: "int", nullable: true),
                    ShippingCharges = table.Column<decimal>(type: "decimal(15,3)", nullable: true),
                    MinDeliveryDay = table.Column<int>(type: "int", nullable: true),
                    MaxDeliveryDay = table.Column<int>(type: "int", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((1))"),
                    IsDelete = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))"),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShipmentAgentRegions", x => x.ID);
                    table.ForeignKey(
                        name: "FK_ShipmentAgentRegions_Cities",
                        column: x => x.CityID,
                        principalTable: "Cities",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_ShipmentAgentRegions_Countries",
                        column: x => x.CountryID,
                        principalTable: "Countries",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_ShipmentAgentRegions_ShipmentAgentRegions",
                        column: x => x.ShipmentAgentID,
                        principalTable: "ShipmentAgents",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_ShipmentAgentRegions_States",
                        column: x => x.StateID,
                        principalTable: "States",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "PurchaseDetails",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PurchaseID = table.Column<long>(type: "bigint", nullable: true),
                    SrNo = table.Column<short>(type: "smallint", nullable: true),
                    ProductVariationID = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    PriceID = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ProductDiscountID = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Quantity = table.Column<int>(type: "int", nullable: true),
                    UnitID = table.Column<short>(type: "smallint", nullable: true),
                    Rate = table.Column<decimal>(type: "decimal(15,3)", nullable: true),
                    Amount = table.Column<decimal>(type: "decimal(15,3)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: true),
                    IsDelete = table.Column<bool>(type: "bit", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PurchaseDetails", x => x.ID);
                    table.ForeignKey(
                        name: "FK_PurchaseDetails_Prices",
                        column: x => x.PriceID,
                        principalTable: "Prices",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_PurchaseDetails_ProductVariations",
                        column: x => x.ProductVariationID,
                        principalTable: "ProductVariations",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_PurchaseDetails_Purchases",
                        column: x => x.PurchaseID,
                        principalTable: "Purchases",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_PurchaseDetails_Units",
                        column: x => x.UnitID,
                        principalTable: "Units",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "Sales",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SaleBillNo = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    TransactionTypeCode = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    SalesOrderID = table.Column<long>(type: "bigint", nullable: true),
                    SalesTypeID = table.Column<short>(type: "smallint", nullable: true),
                    PersonAccountID = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CurrencyID = table.Column<int>(type: "int", nullable: true),
                    CurrencyValue = table.Column<decimal>(type: "decimal(5,3)", nullable: true),
                    CurrencyFormat = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    TotalQuantity = table.Column<decimal>(type: "decimal(15,3)", nullable: true),
                    TotalAmount = table.Column<decimal>(type: "decimal(15,3)", nullable: true),
                    TotalDiscount = table.Column<decimal>(type: "decimal(15,3)", nullable: true),
                    TotalTax = table.Column<decimal>(type: "decimal(15,3)", nullable: true),
                    OtherAdditions = table.Column<decimal>(type: "decimal(15,3)", nullable: true),
                    OtherDeductions = table.Column<decimal>(type: "decimal(15,3)", nullable: true),
                    NetPayable = table.Column<decimal>(type: "decimal(15,3)", nullable: true),
                    SalesStatusID = table.Column<short>(type: "smallint", nullable: true),
                    PaymentMethodID = table.Column<short>(type: "smallint", nullable: true),
                    PaymentReceiveDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    TotalShipmentCharge = table.Column<decimal>(type: "decimal(15,3)", nullable: true),
                    ShippingAddressID = table.Column<int>(type: "int", nullable: true),
                    BillingAddressID = table.Column<int>(type: "int", nullable: true),
                    ShippingAddressJSON = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BillingAddressJSON = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ShippingID = table.Column<long>(type: "bigint", nullable: true),
                    ShippingAgentID = table.Column<int>(type: "int", nullable: true),
                    ShippingAgentTokenID = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ShippingTrackingURL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDispatched = table.Column<bool>(type: "bit", nullable: true),
                    DeliveredDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    IsDelivered = table.Column<bool>(type: "bit", nullable: true),
                    IsPaymentMade = table.Column<bool>(type: "bit", nullable: true),
                    DueDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ContactNumber = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Res_PaymentTransactionNo = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    Res_IsTransactionSuccessFul = table.Column<bool>(type: "bit", nullable: true),
                    Res_Message = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    Res_CurrecnyCode = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: true),
                    Res_NetReceivedAmount = table.Column<decimal>(type: "decimal(15,3)", nullable: true),
                    Res_Vault = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: true),
                    Res_Card_Name = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    Res_Bank_Ref_No = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    Res_Offer_Type = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    Res_Offer_Code = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    Res_Discount_Value = table.Column<decimal>(type: "decimal(15,3)", nullable: true),
                    Res_CoRelationID = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    Res_TimeStamp = table.Column<DateTime>(type: "datetime", nullable: true),
                    Res_JSON = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TransactionDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    Descriptions = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((1))"),
                    IsDelete = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))"),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sales", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Sales_Addresses",
                        column: x => x.ShippingAddressID,
                        principalTable: "Addresses",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Sales_Addresses1",
                        column: x => x.BillingAddressID,
                        principalTable: "Addresses",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Sales_Currencies",
                        column: x => x.CurrencyID,
                        principalTable: "Currencies",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Sales_PaymentMethods",
                        column: x => x.PaymentMethodID,
                        principalTable: "PaymentMethods",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Sales_PersonAccounts",
                        column: x => x.PersonAccountID,
                        principalTable: "PersonAccounts",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Sales_SalesOrders",
                        column: x => x.SalesOrderID,
                        principalTable: "SalesOrders",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Sales_SalesStatus",
                        column: x => x.SalesStatusID,
                        principalTable: "SalesStatus",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Sales_SalesTypes",
                        column: x => x.SalesTypeID,
                        principalTable: "SalesTypes",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "ShipmentAgentRegionRates",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "(newid())"),
                    ShipmentAgentRegionID = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    MinWeight = table.Column<decimal>(type: "decimal(15,3)", nullable: true),
                    MaxWeight = table.Column<decimal>(type: "decimal(15,3)", nullable: true),
                    ExtraPackingWeight = table.Column<decimal>(type: "decimal(15,3)", nullable: true),
                    UnitID = table.Column<short>(type: "smallint", nullable: true),
                    Rate = table.Column<decimal>(type: "decimal(15,3)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((1))"),
                    IsDelete = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))"),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShipmentAgentRegionRates", x => x.ID);
                    table.ForeignKey(
                        name: "FK_ShipmentRates_ShipmentRates2",
                        column: x => x.ShipmentAgentRegionID,
                        principalTable: "ShipmentAgentRegions",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "SalesDetails",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SrNo = table.Column<byte>(type: "tinyint", nullable: true),
                    SalesID = table.Column<long>(type: "bigint", nullable: true),
                    ProductVariationID = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ProductName = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    ProductCode = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ProductDetailJSON = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PriceID = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ProductDiscountID1 = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ProductDiscountID2 = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ProductDiscountID3 = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    UnitID = table.Column<short>(type: "smallint", nullable: true),
                    Quantity = table.Column<decimal>(type: "decimal(15,3)", nullable: true),
                    Price = table.Column<decimal>(type: "decimal(15,3)", nullable: true),
                    Amount = table.Column<decimal>(type: "decimal(15,3)", nullable: true),
                    DiscountAmount = table.Column<decimal>(type: "decimal(15,3)", nullable: true),
                    ProductTaxID = table.Column<long>(type: "bigint", nullable: true),
                    TaxID = table.Column<long>(type: "bigint", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: true),
                    IsDelete = table.Column<bool>(type: "bit", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SalesDetails", x => x.ID);
                    table.ForeignKey(
                        name: "FK_SalesDetails_Prices",
                        column: x => x.PriceID,
                        principalTable: "Prices",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_SalesDetails_ProductVariations",
                        column: x => x.ProductVariationID,
                        principalTable: "ProductVariations",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_SalesDetails_Sales",
                        column: x => x.SalesID,
                        principalTable: "Sales",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Addresses",
                table: "Addresses",
                column: "CityID");

            migrationBuilder.CreateIndex(
                name: "IX_Addresses_1",
                table: "Addresses",
                column: "StateID");

            migrationBuilder.CreateIndex(
                name: "IX_Addresses_2",
                table: "Addresses",
                column: "CountryID");

            migrationBuilder.CreateIndex(
                name: "IX_Addresses_3",
                table: "Addresses",
                columns: new[] { "StateID", "CityID", "CountryID" });

            migrationBuilder.CreateIndex(
                name: "IX_Addresses_4",
                table: "Addresses",
                column: "AddressTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_AdminMenus",
                table: "AdminMenus",
                column: "PageID");

            migrationBuilder.CreateIndex(
                name: "IX_AdminMenus_1",
                table: "AdminMenus",
                column: "ParentMenuID");

            migrationBuilder.CreateIndex(
                name: "IX_AdminMenus_2",
                table: "AdminMenus",
                column: "ID");

            migrationBuilder.CreateIndex(
                name: "IX_ArtCategories_ParentArtCategoryID",
                table: "ArtCategories",
                column: "ParentArtCategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_ArtProperties_ArtID",
                table: "ArtProperties",
                column: "ArtID");

            migrationBuilder.CreateIndex(
                name: "IX_Arts_ArtCategoryID",
                table: "Arts",
                column: "ArtCategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_BrandImages_BrandID",
                table: "BrandImages",
                column: "BrandID");

            migrationBuilder.CreateIndex(
                name: "IX_BrandImages_ImageID",
                table: "BrandImages",
                column: "ImageID");

            migrationBuilder.CreateIndex(
                name: "IX_Carts",
                table: "Carts",
                column: "PriceID");

            migrationBuilder.CreateIndex(
                name: "IX_Carts_1",
                table: "Carts",
                column: "ProductDiscountID");

            migrationBuilder.CreateIndex(
                name: "IX_Carts_2",
                table: "Carts",
                column: "ProductVariationID");

            migrationBuilder.CreateIndex(
                name: "IX_Carts_3",
                table: "Carts",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_Carts_4",
                table: "Carts",
                column: "ID");

            migrationBuilder.CreateIndex(
                name: "IX_Carts_UnitID",
                table: "Carts",
                column: "UnitID");

            migrationBuilder.CreateIndex(
                name: "IX_Categories_ParentCategoryID",
                table: "Categories",
                column: "ParentCategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_CategoryFilters",
                table: "CategoryFilters",
                column: "CategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_CategoryFilters_1",
                table: "CategoryFilters",
                column: "FilterID");

            migrationBuilder.CreateIndex(
                name: "IX_CategoryFilters_2",
                table: "CategoryFilters",
                columns: new[] { "FilterID", "CategoryID" });

            migrationBuilder.CreateIndex(
                name: "IX_CategoryImages",
                table: "CategoryImages",
                column: "ImageID");

            migrationBuilder.CreateIndex(
                name: "IX_CategoryImages_CategoryID",
                table: "CategoryImages",
                column: "CategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_CategorySpecificationGroupsSpecifications",
                table: "CategorySpecificationGroupsSpecifications",
                column: "SpecificationGroupID");

            migrationBuilder.CreateIndex(
                name: "IX_CategorySpecificationGroupsSpecifications_1",
                table: "CategorySpecificationGroupsSpecifications",
                column: "SpecificationID");

            migrationBuilder.CreateIndex(
                name: "IX_CategorySpecificationGroupsSpecifications_2",
                table: "CategorySpecificationGroupsSpecifications",
                column: "CategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_CategorySpecificationGroupsSpecifications_3",
                table: "CategorySpecificationGroupsSpecifications",
                columns: new[] { "SpecificationID", "CategoryID", "SpecificationGroupID" });

            migrationBuilder.CreateIndex(
                name: "IX_CategoryUsageTypes_CategoryID",
                table: "CategoryUsageTypes",
                column: "CategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_CategoryUsageTypes_UsageTypeID",
                table: "CategoryUsageTypes",
                column: "UsageTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_Cities",
                table: "Cities",
                column: "CountryID");

            migrationBuilder.CreateIndex(
                name: "IX_Cities_1",
                table: "Cities",
                column: "MetrocityID");

            migrationBuilder.CreateIndex(
                name: "IX_Cities_2",
                table: "Cities",
                column: "StateID");

            migrationBuilder.CreateIndex(
                name: "IX_Cities_3",
                table: "Cities",
                columns: new[] { "MetrocityID", "CountryID", "StateID" });

            migrationBuilder.CreateIndex(
                name: "IX_CMSPageContents_CMSPageID",
                table: "CMSPageContents",
                column: "CMSPageID");

            migrationBuilder.CreateIndex(
                name: "IX_CMSPageContents_ContentID",
                table: "CMSPageContents",
                column: "ContentID");

            migrationBuilder.CreateIndex(
                name: "IX_Contents",
                table: "Contents",
                column: "ImageID");

            migrationBuilder.CreateIndex(
                name: "IX_Contents_1",
                table: "Contents",
                column: "ID");

            migrationBuilder.CreateIndex(
                name: "IX_DesignProductImageRecepies_ArtPropertyID",
                table: "DesignProductImageRecepies",
                column: "ArtPropertyID");

            migrationBuilder.CreateIndex(
                name: "IX_DesignProductImageRecepies_DesignProductImageID",
                table: "DesignProductImageRecepies",
                column: "DesignProductImageID");

            migrationBuilder.CreateIndex(
                name: "IX_DesignProductImageRecepies_TextPropertyID",
                table: "DesignProductImageRecepies",
                column: "TextPropertyID");

            migrationBuilder.CreateIndex(
                name: "IX_DesignProductImages_CanvasTypeID",
                table: "DesignProductImages",
                column: "CanvasTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_DesignProductImages_DesignProductID",
                table: "DesignProductImages",
                column: "DesignProductID");

            migrationBuilder.CreateIndex(
                name: "IX_DesignProductOrders_DesignProductID",
                table: "DesignProductOrders",
                column: "DesignProductID");

            migrationBuilder.CreateIndex(
                name: "IX_DesignProductOrders_TextPropertyID1",
                table: "DesignProductOrders",
                column: "TextPropertyID1");

            migrationBuilder.CreateIndex(
                name: "IX_DesignProductOrders_TextPropertyID2",
                table: "DesignProductOrders",
                column: "TextPropertyID2");

            migrationBuilder.CreateIndex(
                name: "IX_DesignProductOrders_TextPropertyID3",
                table: "DesignProductOrders",
                column: "TextPropertyID3");

            migrationBuilder.CreateIndex(
                name: "IX_DesignProductOrders_TextPropertyID4",
                table: "DesignProductOrders",
                column: "TextPropertyID4");

            migrationBuilder.CreateIndex(
                name: "IX_DiscountOptioins",
                table: "DiscountOptioins",
                column: "DiscountID");

            migrationBuilder.CreateIndex(
                name: "IX_DiscountOptioins_1",
                table: "DiscountOptioins",
                column: "DiscountValueTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_DiscountOptioins_2",
                table: "DiscountOptioins",
                column: "ID");

            migrationBuilder.CreateIndex(
                name: "IX_Discounts",
                table: "Discounts",
                column: "ImageID");

            migrationBuilder.CreateIndex(
                name: "IX_Discounts_1",
                table: "Discounts",
                columns: new[] { "StartDate", "EndDate" });

            migrationBuilder.CreateIndex(
                name: "IX_Discounts_2",
                table: "Discounts",
                column: "StartDate");

            migrationBuilder.CreateIndex(
                name: "IX_Discounts_3",
                table: "Discounts",
                column: "EndDate");

            migrationBuilder.CreateIndex(
                name: "IX_Feedbacks_ActionBy",
                table: "Feedbacks",
                column: "ActionBy");

            migrationBuilder.CreateIndex(
                name: "IX_Feedbacks_ActionID",
                table: "Feedbacks",
                column: "ActionID");

            migrationBuilder.CreateIndex(
                name: "IX_Feedbacks_FeedbackCategoryID",
                table: "Feedbacks",
                column: "FeedbackCategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_FlagGroups",
                table: "FlagGroups",
                column: "ParentFlagGroupID");

            migrationBuilder.CreateIndex(
                name: "IX_FooterSectionLinks",
                table: "FooterSectionLinks",
                column: "FooterSectionID");

            migrationBuilder.CreateIndex(
                name: "IX_HelpfulProductReviews_ProductReviewID",
                table: "HelpfulProductReviews",
                column: "ProductReviewID");

            migrationBuilder.CreateIndex(
                name: "IX_HelpfulProductReviews_UserID",
                table: "HelpfulProductReviews",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_Inquiries_InquiryCategoryID",
                table: "Inquiries",
                column: "InquiryCategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_Inquiries_ResponderUserId",
                table: "Inquiries",
                column: "ResponderUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Inquiries_UserId",
                table: "Inquiries",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_InquiryMessages_ImageID",
                table: "InquiryMessages",
                column: "ImageID");

            migrationBuilder.CreateIndex(
                name: "IX_InquiryMessages_InquiryID",
                table: "InquiryMessages",
                column: "InquiryID");

            migrationBuilder.CreateIndex(
                name: "IX_MailAttachments_DocumentID",
                table: "MailAttachments",
                column: "DocumentID");

            migrationBuilder.CreateIndex(
                name: "IX_MailAttachments_MailID",
                table: "MailAttachments",
                column: "MailID");

            migrationBuilder.CreateIndex(
                name: "IX_MailQueues_MailID",
                table: "MailQueues",
                column: "MailID");

            migrationBuilder.CreateIndex(
                name: "IX_MailResources_ImageID",
                table: "MailResources",
                column: "ImageID");

            migrationBuilder.CreateIndex(
                name: "IX_MailResources_MailID",
                table: "MailResources",
                column: "MailID");

            migrationBuilder.CreateIndex(
                name: "IX_Memberships_ApplicationId",
                table: "Memberships",
                column: "ApplicationId");

            migrationBuilder.CreateIndex(
                name: "IX_MetroCities",
                table: "MetroCities",
                column: "CountryID");

            migrationBuilder.CreateIndex(
                name: "IX_MetroCities_1",
                table: "MetroCities",
                column: "StateID");

            migrationBuilder.CreateIndex(
                name: "IX_Notifications_NotificationTypeID",
                table: "Notifications",
                column: "NotificationTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_Pages",
                table: "Pages",
                column: "ID");

            migrationBuilder.CreateIndex(
                name: "IX_Pages_1",
                table: "Pages",
                column: "PageRelativeName");

            migrationBuilder.CreateIndex(
                name: "IX_PaymentMethods",
                table: "PaymentMethods",
                column: "PaymentPluginID");

            migrationBuilder.CreateIndex(
                name: "IX_PaymentMethods_1",
                table: "PaymentMethods",
                column: "PaymentMethodTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_PersonAccounts",
                table: "PersonAccounts",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_PersonAccounts_Address1ID",
                table: "PersonAccounts",
                column: "Address1ID");

            migrationBuilder.CreateIndex(
                name: "IX_PersonAccounts_Address2ID",
                table: "PersonAccounts",
                column: "Address2ID");

            migrationBuilder.CreateIndex(
                name: "IX_Prices",
                table: "Prices",
                column: "UnitID");

            migrationBuilder.CreateIndex(
                name: "IX_ProductAssociationProductVariations",
                table: "ProductAssociationProductVariations",
                column: "ProductAssociationID");

            migrationBuilder.CreateIndex(
                name: "IX_ProductAssociationProductVariations_1",
                table: "ProductAssociationProductVariations",
                column: "ProductVariationID");

            migrationBuilder.CreateIndex(
                name: "IX_ProductDiscounts",
                table: "ProductDiscounts",
                column: "BrandID");

            migrationBuilder.CreateIndex(
                name: "IX_ProductDiscounts_1",
                table: "ProductDiscounts",
                column: "DiscountID");

            migrationBuilder.CreateIndex(
                name: "IX_ProductDiscounts_2",
                table: "ProductDiscounts",
                column: "ProductID");

            migrationBuilder.CreateIndex(
                name: "IX_ProductDiscounts_3",
                table: "ProductDiscounts",
                column: "ProductVariationID");

            migrationBuilder.CreateIndex(
                name: "IX_ProductDiscounts_4",
                table: "ProductDiscounts",
                columns: new[] { "ProductVariationID", "DiscountID", "ProductID" });

            migrationBuilder.CreateIndex(
                name: "IX_ProductDiscounts_5",
                table: "ProductDiscounts",
                column: "DiscountTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_ProductDiscounts_6",
                table: "ProductDiscounts",
                column: "ID");

            migrationBuilder.CreateIndex(
                name: "IX_ProductDiscounts_CategoryID",
                table: "ProductDiscounts",
                column: "CategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_ProductDiscounts_DiscountOptionID",
                table: "ProductDiscounts",
                column: "DiscountOptionID");

            migrationBuilder.CreateIndex(
                name: "IX_ProductDiscounts_UserId",
                table: "ProductDiscounts",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductReviews",
                table: "ProductReviews",
                column: "ProductID");

            migrationBuilder.CreateIndex(
                name: "IX_ProductReviews_1",
                table: "ProductReviews",
                column: "ProductVariationID");

            migrationBuilder.CreateIndex(
                name: "IX_ProductReviews_2",
                table: "ProductReviews",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductReviews_VarifiedBy",
                table: "ProductReviews",
                column: "VarifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Products",
                table: "Products",
                columns: new[] { "BrandID", "CategoryID" });

            migrationBuilder.CreateIndex(
                name: "IX_Products_1",
                table: "Products",
                column: "BrandID");

            migrationBuilder.CreateIndex(
                name: "IX_Products_2",
                table: "Products",
                column: "CategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_Products_3",
                table: "Products",
                column: "ProductTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_Products_4",
                table: "Products",
                column: "UsageTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_Products_ProductSetID",
                table: "Products",
                column: "ProductSetID");

            migrationBuilder.CreateIndex(
                name: "IX_Products_SKUID",
                table: "Products",
                column: "SKUID");

            migrationBuilder.CreateIndex(
                name: "IX_Products_StockTypeID",
                table: "Products",
                column: "StockTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_Products_UnitID",
                table: "Products",
                column: "UnitID");

            migrationBuilder.CreateIndex(
                name: "IX_ProductSetProducts",
                table: "ProductSetProducts",
                columns: new[] { "ProductID", "ProductSetID" });

            migrationBuilder.CreateIndex(
                name: "IX_ProductSetProducts_ProductSetID",
                table: "ProductSetProducts",
                column: "ProductSetID");

            migrationBuilder.CreateIndex(
                name: "IX_ProductShipments_ProductVariatioinPriceID",
                table: "ProductShipments",
                column: "ProductVariatioinPriceID");

            migrationBuilder.CreateIndex(
                name: "IX_ProductShipments_UnitID",
                table: "ProductShipments",
                column: "UnitID");

            migrationBuilder.CreateIndex(
                name: "IX_ProductSpecifications_1",
                table: "ProductSpecifications",
                column: "ProductID");

            migrationBuilder.CreateIndex(
                name: "IX_ProductSpecifications_2",
                table: "ProductSpecifications",
                column: "SpecificationGroupID");

            migrationBuilder.CreateIndex(
                name: "IX_ProductSpecifications_3",
                table: "ProductSpecifications",
                column: "SpecificationID");

            migrationBuilder.CreateIndex(
                name: "IX_ProductStocks",
                table: "ProductStocks",
                column: "ProductVariationID");

            migrationBuilder.CreateIndex(
                name: "IX_ProductStocks_TransactionTypeID",
                table: "ProductStocks",
                column: "TransactionTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_ProductStocks_UnitID",
                table: "ProductStocks",
                column: "UnitID");

            migrationBuilder.CreateIndex(
                name: "IX_ProductTaxs_ProductID",
                table: "ProductTaxs",
                column: "ProductID");

            migrationBuilder.CreateIndex(
                name: "IX_ProductTaxs_TaxID",
                table: "ProductTaxs",
                column: "TaxID");

            migrationBuilder.CreateIndex(
                name: "IX_ProductVariationImages",
                table: "ProductVariationImages",
                column: "ImageID");

            migrationBuilder.CreateIndex(
                name: "IX_ProductVariationImages_1",
                table: "ProductVariationImages",
                column: "ImageID");

            migrationBuilder.CreateIndex(
                name: "IX_ProductVariationImages_2",
                table: "ProductVariationImages",
                columns: new[] { "ImageID", "ProductVariationID" });

            migrationBuilder.CreateIndex(
                name: "IX_ProductVariationImages_3",
                table: "ProductVariationImages",
                columns: new[] { "ImageID", "ImageOrderNo", "ProductVariationID" });

            migrationBuilder.CreateIndex(
                name: "IX_ProductVariationImages_ProductVariationID",
                table: "ProductVariationImages",
                column: "ProductVariationID");

            migrationBuilder.CreateIndex(
                name: "IX_ProductVariationPrices",
                table: "ProductVariationPrices",
                column: "Barcode");

            migrationBuilder.CreateIndex(
                name: "IX_ProductVariationPrices_1",
                table: "ProductVariationPrices",
                column: "PriceID");

            migrationBuilder.CreateIndex(
                name: "IX_ProductVariationPrices_2",
                table: "ProductVariationPrices",
                column: "ProductVariationID");

            migrationBuilder.CreateIndex(
                name: "IX_ProductVariationPrices_3",
                table: "ProductVariationPrices",
                columns: new[] { "PriceID", "ProductVariationID" });

            migrationBuilder.CreateIndex(
                name: "IX_ProductVariations",
                table: "ProductVariations",
                column: "ProductID");

            migrationBuilder.CreateIndex(
                name: "IX_ProductVariations_1",
                table: "ProductVariations",
                column: "ProductAssociationID");

            migrationBuilder.CreateIndex(
                name: "IX_ProductVariationValues",
                table: "ProductVariationValues",
                columns: new[] { "ProductID", "VariationID" });

            migrationBuilder.CreateIndex(
                name: "IX_ProductVariationValues_1",
                table: "ProductVariationValues",
                column: "ProductID");

            migrationBuilder.CreateIndex(
                name: "IX_ProductVariationValues_2",
                table: "ProductVariationValues",
                column: "VariationID");

            migrationBuilder.CreateIndex(
                name: "IX_PurchaseDetails_PriceID",
                table: "PurchaseDetails",
                column: "PriceID");

            migrationBuilder.CreateIndex(
                name: "IX_PurchaseDetails_ProductVariationID",
                table: "PurchaseDetails",
                column: "ProductVariationID");

            migrationBuilder.CreateIndex(
                name: "IX_PurchaseDetails_PurchaseID",
                table: "PurchaseDetails",
                column: "PurchaseID");

            migrationBuilder.CreateIndex(
                name: "IX_PurchaseDetails_UnitID",
                table: "PurchaseDetails",
                column: "UnitID");

            migrationBuilder.CreateIndex(
                name: "IX_PurchaseOrderDetails_ProductVariationID",
                table: "PurchaseOrderDetails",
                column: "ProductVariationID");

            migrationBuilder.CreateIndex(
                name: "IX_PurchaseOrderDetails_PurchaseOrderID",
                table: "PurchaseOrderDetails",
                column: "PurchaseOrderID");

            migrationBuilder.CreateIndex(
                name: "IX_PurchaseOrderDetails_UnitID",
                table: "PurchaseOrderDetails",
                column: "UnitID");

            migrationBuilder.CreateIndex(
                name: "IX_Purchases_CurrencyID",
                table: "Purchases",
                column: "CurrencyID");

            migrationBuilder.CreateIndex(
                name: "IX_Purchases_PersonAccountID",
                table: "Purchases",
                column: "PersonAccountID");

            migrationBuilder.CreateIndex(
                name: "IX_RolePages",
                table: "RolePages",
                columns: new[] { "PageID", "RoleID" });

            migrationBuilder.CreateIndex(
                name: "IX_RolePages_RoleID",
                table: "RolePages",
                column: "RoleID");

            migrationBuilder.CreateIndex(
                name: "IX_Roles_ApplicationId",
                table: "Roles",
                column: "ApplicationId");

            migrationBuilder.CreateIndex(
                name: "IX_Sales",
                table: "Sales",
                column: "PaymentMethodID");

            migrationBuilder.CreateIndex(
                name: "IX_Sales_1",
                table: "Sales",
                column: "PersonAccountID");

            migrationBuilder.CreateIndex(
                name: "IX_Sales_2",
                table: "Sales",
                column: "SalesOrderID");

            migrationBuilder.CreateIndex(
                name: "IX_Sales_3",
                table: "Sales",
                column: "ShippingAddressID");

            migrationBuilder.CreateIndex(
                name: "IX_Sales_4",
                table: "Sales",
                column: "BillingAddressID");

            migrationBuilder.CreateIndex(
                name: "IX_Sales_5",
                table: "Sales",
                column: "SalesStatusID");

            migrationBuilder.CreateIndex(
                name: "IX_Sales_6",
                table: "Sales",
                column: "ID");

            migrationBuilder.CreateIndex(
                name: "IX_Sales_CurrencyID",
                table: "Sales",
                column: "CurrencyID");

            migrationBuilder.CreateIndex(
                name: "IX_Sales_SalesTypeID",
                table: "Sales",
                column: "SalesTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_SalesDetails",
                table: "SalesDetails",
                column: "PriceID");

            migrationBuilder.CreateIndex(
                name: "IX_SalesDetails_1",
                table: "SalesDetails",
                column: "ProductVariationID");

            migrationBuilder.CreateIndex(
                name: "IX_SalesDetails_2",
                table: "SalesDetails",
                column: "SalesID");

            migrationBuilder.CreateIndex(
                name: "IX_SalesDetails_3",
                table: "SalesDetails",
                column: "ProductDiscountID1");

            migrationBuilder.CreateIndex(
                name: "IX_SalesHistoryTransactions_SalesStausID",
                table: "SalesHistoryTransactions",
                column: "SalesStausID");

            migrationBuilder.CreateIndex(
                name: "IX_SalesOrders_CurrencyID",
                table: "SalesOrders",
                column: "CurrencyID");

            migrationBuilder.CreateIndex(
                name: "IX_SalesOrders_PersonAccountID",
                table: "SalesOrders",
                column: "PersonAccountID");

            migrationBuilder.CreateIndex(
                name: "IX_SEOContents_1",
                table: "SEOContents",
                column: "ID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_SEOContents_BrandID",
                table: "SEOContents",
                column: "BrandID");

            migrationBuilder.CreateIndex(
                name: "IX_SEOContents_CategoryID",
                table: "SEOContents",
                column: "CategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_SEOContents_ProductID",
                table: "SEOContents",
                column: "ProductID");

            migrationBuilder.CreateIndex(
                name: "IX_ShipmentAgentCourierServiceProviders",
                table: "ShipmentAgentCourierServiceProviders",
                column: "ShipmentAgentID");

            migrationBuilder.CreateIndex(
                name: "IX_ShipmentAgentCourierServiceProviders_1",
                table: "ShipmentAgentCourierServiceProviders",
                column: "CourierServiceProviderID");

            migrationBuilder.CreateIndex(
                name: "IX_ShipmentAgentRegionRates",
                table: "ShipmentAgentRegionRates",
                column: "ShipmentAgentRegionID");

            migrationBuilder.CreateIndex(
                name: "IX_ShipmentAgentRegionRates_1",
                table: "ShipmentAgentRegionRates",
                column: "UnitID");

            migrationBuilder.CreateIndex(
                name: "IX_ShipmentAgentRegionRates_2",
                table: "ShipmentAgentRegionRates",
                columns: new[] { "MaxWeight", "MinWeight", "UnitID" });

            migrationBuilder.CreateIndex(
                name: "IX_ShipmentAgentRegions",
                table: "ShipmentAgentRegions",
                column: "ShipmentAgentID");

            migrationBuilder.CreateIndex(
                name: "IX_ShipmentAgentRegions_1",
                table: "ShipmentAgentRegions",
                column: "StateID");

            migrationBuilder.CreateIndex(
                name: "IX_ShipmentAgentRegions_2",
                table: "ShipmentAgentRegions",
                column: "CountryID");

            migrationBuilder.CreateIndex(
                name: "IX_ShipmentAgentRegions_3",
                table: "ShipmentAgentRegions",
                column: "CityID");

            migrationBuilder.CreateIndex(
                name: "IX_ShipmentAgents",
                table: "ShipmentAgents",
                column: "ID");

            migrationBuilder.CreateIndex(
                name: "IX_ShipmentAgents_AddressID",
                table: "ShipmentAgents",
                column: "AddressID");

            migrationBuilder.CreateIndex(
                name: "IX_ShipmentAgents_ShipAgentTypeID",
                table: "ShipmentAgents",
                column: "ShipAgentTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_ShipmentOfferConditions",
                table: "ShipmentOfferConditions",
                column: "ShipmentOfferID");

            migrationBuilder.CreateIndex(
                name: "IX_ShipmentOfferConditions_UnitID",
                table: "ShipmentOfferConditions",
                column: "UnitID");

            migrationBuilder.CreateIndex(
                name: "IX_ShipmentOffers",
                table: "ShipmentOffers",
                columns: new[] { "MetrocityID", "CountryID", "StateID", "CityID" });

            migrationBuilder.CreateIndex(
                name: "IX_ShipmentOffers_1",
                table: "ShipmentOffers",
                column: "StartDate");

            migrationBuilder.CreateIndex(
                name: "IX_ShipmentOffers_2",
                table: "ShipmentOffers",
                column: "EndDate");

            migrationBuilder.CreateIndex(
                name: "IX_ShipmentOffers_CityID",
                table: "ShipmentOffers",
                column: "CityID");

            migrationBuilder.CreateIndex(
                name: "IX_ShipmentOffers_CountryID",
                table: "ShipmentOffers",
                column: "CountryID");

            migrationBuilder.CreateIndex(
                name: "IX_ShipmentOffers_StateID",
                table: "ShipmentOffers",
                column: "StateID");

            migrationBuilder.CreateIndex(
                name: "IX_SMSQueues_SMSID",
                table: "SMSQueues",
                column: "SMSID");

            migrationBuilder.CreateIndex(
                name: "IX_SMSQueues_UserId",
                table: "SMSQueues",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_SMSTopics_SMSID",
                table: "SMSTopics",
                column: "SMSID");

            migrationBuilder.CreateIndex(
                name: "IX_SMSTopics_TopicID",
                table: "SMSTopics",
                column: "TopicID");

            migrationBuilder.CreateIndex(
                name: "IX_SpecificatonGroupSpecifications",
                table: "SpecificatonGroupSpecifications",
                columns: new[] { "SpecificationGroupID", "SpecificationID" });

            migrationBuilder.CreateIndex(
                name: "IX_SpecificatonGroupSpecifications_SpecificationID",
                table: "SpecificatonGroupSpecifications",
                column: "SpecificationID");

            migrationBuilder.CreateIndex(
                name: "IX_States",
                table: "States",
                column: "CountryID");

            migrationBuilder.CreateIndex(
                name: "IX_SystemFlags",
                table: "SystemFlags",
                column: "FlagGroupID");

            migrationBuilder.CreateIndex(
                name: "IX_SystemFlags_1",
                table: "SystemFlags",
                column: "SystemFlagName");

            migrationBuilder.CreateIndex(
                name: "IX_SystemFlags_ModifiedByUserId",
                table: "SystemFlags",
                column: "ModifiedByUserId");

            migrationBuilder.CreateIndex(
                name: "IX_SystemFlags_ValueTypeID",
                table: "SystemFlags",
                column: "ValueTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_Tokens_UserId",
                table: "Tokens",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_TopicMails_BrandID",
                table: "TopicMails",
                column: "BrandID");

            migrationBuilder.CreateIndex(
                name: "IX_TopicMails_CategoryID",
                table: "TopicMails",
                column: "CategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_TopicMails_MailID",
                table: "TopicMails",
                column: "MailID");

            migrationBuilder.CreateIndex(
                name: "IX_TopicMails_ProductID",
                table: "TopicMails",
                column: "ProductID");

            migrationBuilder.CreateIndex(
                name: "IX_TopicMails_TopicID",
                table: "TopicMails",
                column: "TopicID");

            migrationBuilder.CreateIndex(
                name: "IX_Topics_ParentTopicID",
                table: "Topics",
                column: "ParentTopicID");

            migrationBuilder.CreateIndex(
                name: "IX_UserAddresses_AddressID",
                table: "UserAddresses",
                column: "AddressID");

            migrationBuilder.CreateIndex(
                name: "IX_UserAddresses_UserId",
                table: "UserAddresses",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserContacts_ContactTypeID",
                table: "UserContacts",
                column: "ContactTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_UserContacts_UserId",
                table: "UserContacts",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserDetails_ProofTypeID",
                table: "UserDetails",
                column: "ProofTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_UserDetails_UserTypeID",
                table: "UserDetails",
                column: "UserTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_UserFlags_FlagGroupID",
                table: "UserFlags",
                column: "FlagGroupID");

            migrationBuilder.CreateIndex(
                name: "IX_UserFlags_ValueTypeID",
                table: "UserFlags",
                column: "ValueTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_UserFlagValues_UserFlagID",
                table: "UserFlagValues",
                column: "UserFlagID");

            migrationBuilder.CreateIndex(
                name: "IX_UserFlagValues_UserId",
                table: "UserFlagValues",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserLogs_ActivityTypeID",
                table: "UserLogs",
                column: "ActivityTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_UserLogs_UserId",
                table: "UserLogs",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserPropertyValues_UserId",
                table: "UserPropertyValues",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserPropertyValues_UserPropertyID",
                table: "UserPropertyValues",
                column: "UserPropertyID");

            migrationBuilder.CreateIndex(
                name: "IX_Users_ApplicationId",
                table: "Users",
                column: "ApplicationId");

            migrationBuilder.CreateIndex(
                name: "IX_UsersInRoles_RoleId",
                table: "UsersInRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_UsersOAuthAccounts_OAuthProviderID",
                table: "UsersOAuthAccounts",
                column: "OAuthProviderID");

            migrationBuilder.CreateIndex(
                name: "IX_UsersOAuthAccounts_UserId",
                table: "UsersOAuthAccounts",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserSubscriptions_BrandID",
                table: "UserSubscriptions",
                column: "BrandID");

            migrationBuilder.CreateIndex(
                name: "IX_UserSubscriptions_CategoryID",
                table: "UserSubscriptions",
                column: "CategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_UserSubscriptions_ProductID",
                table: "UserSubscriptions",
                column: "ProductID");

            migrationBuilder.CreateIndex(
                name: "IX_UserSubscriptions_TopicID",
                table: "UserSubscriptions",
                column: "TopicID");

            migrationBuilder.CreateIndex(
                name: "IX_UserSubscriptions_UserID",
                table: "UserSubscriptions",
                column: "UserID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AdminMenus");

            migrationBuilder.DropTable(
                name: "Advertiesments");

            migrationBuilder.DropTable(
                name: "BrandImages");

            migrationBuilder.DropTable(
                name: "Carts");

            migrationBuilder.DropTable(
                name: "CategoryFilters");

            migrationBuilder.DropTable(
                name: "CategoryImages");

            migrationBuilder.DropTable(
                name: "CategorySpecificationGroupsSpecifications");

            migrationBuilder.DropTable(
                name: "CategoryUsageTypes");

            migrationBuilder.DropTable(
                name: "CMSPageContents");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "DayWiseSales");

            migrationBuilder.DropTable(
                name: "DesignProductImageRecepies");

            migrationBuilder.DropTable(
                name: "DesignProductOrders");

            migrationBuilder.DropTable(
                name: "Feedbacks");

            migrationBuilder.DropTable(
                name: "FooterSectionLinks");

            migrationBuilder.DropTable(
                name: "HelpfulProductReviews");

            migrationBuilder.DropTable(
                name: "InquiryMessages");

            migrationBuilder.DropTable(
                name: "Keywords");

            migrationBuilder.DropTable(
                name: "MailAttachments");

            migrationBuilder.DropTable(
                name: "MailQueues");

            migrationBuilder.DropTable(
                name: "MailResources");

            migrationBuilder.DropTable(
                name: "Memberships");

            migrationBuilder.DropTable(
                name: "Menus");

            migrationBuilder.DropTable(
                name: "Notifications");

            migrationBuilder.DropTable(
                name: "OrderStatus");

            migrationBuilder.DropTable(
                name: "ProductAssociationProductVariations");

            migrationBuilder.DropTable(
                name: "ProductPopulationFactors");

            migrationBuilder.DropTable(
                name: "ProductSetProducts");

            migrationBuilder.DropTable(
                name: "ProductShipments");

            migrationBuilder.DropTable(
                name: "ProductSpecifications");

            migrationBuilder.DropTable(
                name: "ProductStatitics");

            migrationBuilder.DropTable(
                name: "ProductStocks");

            migrationBuilder.DropTable(
                name: "ProductTaxs");

            migrationBuilder.DropTable(
                name: "ProductVariationImages");

            migrationBuilder.DropTable(
                name: "ProductVariationValues");

            migrationBuilder.DropTable(
                name: "Profiles");

            migrationBuilder.DropTable(
                name: "PurchaseDetails");

            migrationBuilder.DropTable(
                name: "PurchaseOrderDetails");

            migrationBuilder.DropTable(
                name: "RolePages");

            migrationBuilder.DropTable(
                name: "SalesDetails");

            migrationBuilder.DropTable(
                name: "SalesHistoryTransactions");

            migrationBuilder.DropTable(
                name: "SalesOrderDetails");

            migrationBuilder.DropTable(
                name: "SEOContents");

            migrationBuilder.DropTable(
                name: "ShipmentAgentCourierServiceProviders");

            migrationBuilder.DropTable(
                name: "ShipmentAgentRegionRates");

            migrationBuilder.DropTable(
                name: "ShipmentOfferConditions");

            migrationBuilder.DropTable(
                name: "SMSQueues");

            migrationBuilder.DropTable(
                name: "SMSTopics");

            migrationBuilder.DropTable(
                name: "SpecificatonGroupSpecifications");

            migrationBuilder.DropTable(
                name: "SystemFlags");

            migrationBuilder.DropTable(
                name: "Tokens");

            migrationBuilder.DropTable(
                name: "TopicMails");

            migrationBuilder.DropTable(
                name: "UserAddresses");

            migrationBuilder.DropTable(
                name: "UserContacts");

            migrationBuilder.DropTable(
                name: "UserFlagValues");

            migrationBuilder.DropTable(
                name: "UserLogs");

            migrationBuilder.DropTable(
                name: "UserPropertyValues");

            migrationBuilder.DropTable(
                name: "UsersInRoles");

            migrationBuilder.DropTable(
                name: "UsersOAuthAccounts");

            migrationBuilder.DropTable(
                name: "UsersOAuthData");

            migrationBuilder.DropTable(
                name: "UserSubscriptions");

            migrationBuilder.DropTable(
                name: "Warehouses");

            migrationBuilder.DropTable(
                name: "ProductDiscounts");

            migrationBuilder.DropTable(
                name: "Filters");

            migrationBuilder.DropTable(
                name: "CMSPages");

            migrationBuilder.DropTable(
                name: "Contents");

            migrationBuilder.DropTable(
                name: "ArtProperties");

            migrationBuilder.DropTable(
                name: "DesignProductImages");

            migrationBuilder.DropTable(
                name: "TextProperties");

            migrationBuilder.DropTable(
                name: "FeedbackActions");

            migrationBuilder.DropTable(
                name: "FooterSections");

            migrationBuilder.DropTable(
                name: "ProductReviews");

            migrationBuilder.DropTable(
                name: "Inquiries");

            migrationBuilder.DropTable(
                name: "Documents");

            migrationBuilder.DropTable(
                name: "NotificationTypes");

            migrationBuilder.DropTable(
                name: "ProductVariationPrices");

            migrationBuilder.DropTable(
                name: "TransactionTypes");

            migrationBuilder.DropTable(
                name: "Taxs");

            migrationBuilder.DropTable(
                name: "Variations");

            migrationBuilder.DropTable(
                name: "Purchases");

            migrationBuilder.DropTable(
                name: "PurchaseOrders");

            migrationBuilder.DropTable(
                name: "Pages");

            migrationBuilder.DropTable(
                name: "Sales");

            migrationBuilder.DropTable(
                name: "ShipmentAgentRegions");

            migrationBuilder.DropTable(
                name: "ShipmentOffers");

            migrationBuilder.DropTable(
                name: "SMS");

            migrationBuilder.DropTable(
                name: "Specifications");

            migrationBuilder.DropTable(
                name: "SpecificationGroups");

            migrationBuilder.DropTable(
                name: "Mails");

            migrationBuilder.DropTable(
                name: "ContactTypes");

            migrationBuilder.DropTable(
                name: "UserFlags");

            migrationBuilder.DropTable(
                name: "ActivityTypes");

            migrationBuilder.DropTable(
                name: "UserProperties");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "OAuthProviders");

            migrationBuilder.DropTable(
                name: "Topics");

            migrationBuilder.DropTable(
                name: "DiscountOptioins");

            migrationBuilder.DropTable(
                name: "DiscountTypes");

            migrationBuilder.DropTable(
                name: "Arts");

            migrationBuilder.DropTable(
                name: "CanvasTypes");

            migrationBuilder.DropTable(
                name: "DesignProducts");

            migrationBuilder.DropTable(
                name: "FeedbackInquiryCategories");

            migrationBuilder.DropTable(
                name: "Prices");

            migrationBuilder.DropTable(
                name: "ProductVariations");

            migrationBuilder.DropTable(
                name: "PaymentMethods");

            migrationBuilder.DropTable(
                name: "SalesOrders");

            migrationBuilder.DropTable(
                name: "SalesStatus");

            migrationBuilder.DropTable(
                name: "SalesTypes");

            migrationBuilder.DropTable(
                name: "ShipmentAgents");

            migrationBuilder.DropTable(
                name: "FlagGroups");

            migrationBuilder.DropTable(
                name: "ValueTypes");

            migrationBuilder.DropTable(
                name: "Discounts");

            migrationBuilder.DropTable(
                name: "DiscountValueTypes");

            migrationBuilder.DropTable(
                name: "ArtCategories");

            migrationBuilder.DropTable(
                name: "ProductAssociations");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "PaymentMethodTypes");

            migrationBuilder.DropTable(
                name: "PaymentPlugins");

            migrationBuilder.DropTable(
                name: "Currencies");

            migrationBuilder.DropTable(
                name: "PersonAccounts");

            migrationBuilder.DropTable(
                name: "ShipmentAgentTypes");

            migrationBuilder.DropTable(
                name: "Images");

            migrationBuilder.DropTable(
                name: "Brands");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "ProductSets");

            migrationBuilder.DropTable(
                name: "ProductTypes");

            migrationBuilder.DropTable(
                name: "StockTypes");

            migrationBuilder.DropTable(
                name: "Units");

            migrationBuilder.DropTable(
                name: "UsageTypes");

            migrationBuilder.DropTable(
                name: "Addresses");

            migrationBuilder.DropTable(
                name: "UserDetails");

            migrationBuilder.DropTable(
                name: "AddressTypes");

            migrationBuilder.DropTable(
                name: "Cities");

            migrationBuilder.DropTable(
                name: "ProofTypes");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "UserTypes");

            migrationBuilder.DropTable(
                name: "MetroCities");

            migrationBuilder.DropTable(
                name: "States");

            migrationBuilder.DropTable(
                name: "Applications");

            migrationBuilder.DropTable(
                name: "Countries");
        }
    }
}
