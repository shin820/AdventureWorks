

// This file was automatically generated.
// Do not make changes directly to this file - edit the template instead.
// 
// The following connection settings were used to generate this file
// 
//     Connection String Name: "AdventureWorks"
//     Connection String:      "Data Source=YHWY-PC;Initial Catalog=AdventureWorks;Trusted_Connection=true"

// ReSharper disable RedundantUsingDirective
// ReSharper disable DoNotCallOverridableMethodsInConstructor
// ReSharper disable InconsistentNaming

using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using AdventureWorks.Model.Production;
using AdventureWorks.Model.Purchasing;
using AdventureWorks.Model.Sales;

//using DatabaseGeneratedOption = System.ComponentModel.DataAnnotations.DatabaseGeneratedOption;

namespace AdventureWorks.IntegrationTest
{
    // ************************************************************************
    // Database context

    // ************************************************************************
    // POCO classes

    // AWBuildVersion

    // DatabaseLog

    // ErrorLog

    // Department

    // Employee

    // EmployeeAddress

    // EmployeeDepartmentHistory

    // EmployeePayHistory

    // JobCandidate

    // Shift

    // Address

    // AddressType

    // Contact

    // ContactType

    // CountryRegion

    // StateProvince

    // BillOfMaterials

    // Culture

    // Document

    // Illustration

    // Location

    // Product

    // ProductCategory

    // ProductCostHistory

    // ProductDescription

    // ProductDocument

    // ProductInventory

    // ProductListPriceHistory

    // ProductModel

    // ProductModelIllustration

    // ProductModelProductDescriptionCulture

    // ProductPhoto

    // ProductProductPhoto

    // ProductReview

    // ProductSubcategory

    // ScrapReason

    // TransactionHistory

    // TransactionHistoryArchive

    // UnitMeasure

    // WorkOrder

    // WorkOrderRouting

    // ProductVendor

    // PurchaseOrderDetail

    // PurchaseOrderHeader

    // ShipMethod

    // Vendor

    // VendorAddress

    // VendorContact

    // ContactCreditCard

    // CountryRegionCurrency

    // CreditCard

    // Currency

    // CurrencyRate

    // Customer

    // CustomerAddress

    // Individual

    // SalesOrderDetail

    // SalesOrderHeader

    // SalesOrderHeaderSalesReason

    // SalesPerson

    // SalesPersonQuotaHistory

    // SalesReason

    // SalesTaxRate

    // SalesTerritory

    // SalesTerritoryHistory

    // ShoppingCartItem

    // SpecialOffer

    // SpecialOfferProduct

    // Store

    // StoreContact

    // WebSiteHits


    // ************************************************************************
    // POCO Configuration

    // AWBuildVersion

    // DatabaseLog

    // ErrorLog

    // Department

    // Employee

    // EmployeeAddress

    // EmployeeDepartmentHistory

    // EmployeePayHistory

    // JobCandidate

    // Shift

    // Address

    // AddressType

    // Contact

    // ContactType

    // CountryRegion

    // StateProvince

    // BillOfMaterials

    // Culture

    // Document
    internal class Production_DocumentConfiguration : EntityTypeConfiguration<Production_Document>
    {
        public Production_DocumentConfiguration()
        {
            ToTable("Production.Document");
            HasKey(x => x.DocumentId);

            Property(x => x.DocumentId).HasColumnName("DocumentID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.Title).HasColumnName("Title").IsRequired().HasMaxLength(50);
            Property(x => x.FileName).HasColumnName("FileName").IsRequired().HasMaxLength(400);
            Property(x => x.FileExtension).HasColumnName("FileExtension").IsRequired().HasMaxLength(8);
            Property(x => x.Revision).HasColumnName("Revision").IsRequired().HasMaxLength(5);
            Property(x => x.ChangeNumber).HasColumnName("ChangeNumber").IsRequired();
            Property(x => x.Status).HasColumnName("Status").IsRequired();
            Property(x => x.DocumentSummary).HasColumnName("DocumentSummary").IsOptional();
            Property(x => x.Document).HasColumnName("Document").IsOptional();
            Property(x => x.ModifiedDate).HasColumnName("ModifiedDate").IsRequired();
        }
    }

    // Illustration
    internal class Production_IllustrationConfiguration : EntityTypeConfiguration<Production_Illustration>
    {
        public Production_IllustrationConfiguration()
        {
            ToTable("Production.Illustration");
            HasKey(x => x.IllustrationId);

            Property(x => x.IllustrationId).HasColumnName("IllustrationID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.Diagram).HasColumnName("Diagram").IsOptional();
            Property(x => x.ModifiedDate).HasColumnName("ModifiedDate").IsRequired();
        }
    }

    // Location
    internal class Production_LocationConfiguration : EntityTypeConfiguration<Production_Location>
    {
        public Production_LocationConfiguration()
        {
            ToTable("Production.Location");
            HasKey(x => x.LocationId);

            Property(x => x.LocationId).HasColumnName("LocationID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.Name).HasColumnName("Name").IsRequired().HasMaxLength(50);
            Property(x => x.CostRate).HasColumnName("CostRate").IsRequired().HasPrecision(10,4);
            Property(x => x.Availability).HasColumnName("Availability").IsRequired().HasPrecision(8,2);
            Property(x => x.ModifiedDate).HasColumnName("ModifiedDate").IsRequired();
        }
    }

    // Product
    internal class Production_ProductConfiguration : EntityTypeConfiguration<Production_Product>
    {
        public Production_ProductConfiguration()
        {
            ToTable("Production.Product");
            HasKey(x => x.ProductId);

            Property(x => x.ProductId).HasColumnName("ProductID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.Name).HasColumnName("Name").IsRequired().HasMaxLength(50);
            Property(x => x.ProductNumber).HasColumnName("ProductNumber").IsRequired().HasMaxLength(25);
            Property(x => x.MakeFlag).HasColumnName("MakeFlag").IsRequired();
            Property(x => x.FinishedGoodsFlag).HasColumnName("FinishedGoodsFlag").IsRequired();
            Property(x => x.Color).HasColumnName("Color").IsOptional().HasMaxLength(15);
            Property(x => x.SafetyStockLevel).HasColumnName("SafetyStockLevel").IsRequired();
            Property(x => x.ReorderPoint).HasColumnName("ReorderPoint").IsRequired();
            Property(x => x.StandardCost).HasColumnName("StandardCost").IsRequired().HasPrecision(19,4);
            Property(x => x.ListPrice).HasColumnName("ListPrice").IsRequired().HasPrecision(19,4);
            Property(x => x.Size).HasColumnName("Size").IsOptional().HasMaxLength(5);
            Property(x => x.SizeUnitMeasureCode).HasColumnName("SizeUnitMeasureCode").IsOptional().HasMaxLength(3);
            Property(x => x.WeightUnitMeasureCode).HasColumnName("WeightUnitMeasureCode").IsOptional().HasMaxLength(3);
            Property(x => x.Weight).HasColumnName("Weight").IsOptional().HasPrecision(8,2);
            Property(x => x.DaysToManufacture).HasColumnName("DaysToManufacture").IsRequired();
            Property(x => x.ProductLine).HasColumnName("ProductLine").IsOptional().HasMaxLength(2);
            Property(x => x.Class).HasColumnName("Class").IsOptional().HasMaxLength(2);
            Property(x => x.Style).HasColumnName("Style").IsOptional().HasMaxLength(2);
            Property(x => x.ProductSubcategoryId).HasColumnName("ProductSubcategoryID").IsOptional();
            Property(x => x.ProductModelId).HasColumnName("ProductModelID").IsOptional();
            Property(x => x.SellStartDate).HasColumnName("SellStartDate").IsRequired();
            Property(x => x.SellEndDate).HasColumnName("SellEndDate").IsOptional();
            Property(x => x.DiscontinuedDate).HasColumnName("DiscontinuedDate").IsOptional();
            Property(x => x.Rowguid).HasColumnName("rowguid").IsRequired();
            Property(x => x.ModifiedDate).HasColumnName("ModifiedDate").IsRequired();

            // Foreign keys
            HasOptional(a => a.Production_UnitMeasure).WithMany(b => b.Production_Product).HasForeignKey(c => c.SizeUnitMeasureCode); // FK_Product_UnitMeasure_SizeUnitMeasureCode
            HasOptional(a => a.Production_UnitMeasure1).WithMany(b => b.Production_Product1).HasForeignKey(c => c.WeightUnitMeasureCode); // FK_Product_UnitMeasure_WeightUnitMeasureCode
            HasOptional(a => a.Production_ProductSubcategory).WithMany(b => b.Production_Product).HasForeignKey(c => c.ProductSubcategoryId); // FK_Product_ProductSubcategory_ProductSubcategoryID
            HasOptional(a => a.Production_ProductModel).WithMany(b => b.Production_Product).HasForeignKey(c => c.ProductModelId); // FK_Product_ProductModel_ProductModelID
        }
    }

    // ProductCategory
    internal class Production_ProductCategoryConfiguration : EntityTypeConfiguration<Production_ProductCategory>
    {
        public Production_ProductCategoryConfiguration()
        {
            ToTable("Production.ProductCategory");
            HasKey(x => x.ProductCategoryId);

            Property(x => x.ProductCategoryId).HasColumnName("ProductCategoryID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.Name).HasColumnName("Name").IsRequired().HasMaxLength(50);
            Property(x => x.Rowguid).HasColumnName("rowguid").IsRequired();
            Property(x => x.ModifiedDate).HasColumnName("ModifiedDate").IsRequired();
        }
    }

    // ProductCostHistory
    internal class Production_ProductCostHistoryConfiguration : EntityTypeConfiguration<Production_ProductCostHistory>
    {
        public Production_ProductCostHistoryConfiguration()
        {
            ToTable("Production.ProductCostHistory");
            HasKey(x => new { x.ProductId, x.StartDate });

            Property(x => x.ProductId).HasColumnName("ProductID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.StartDate).HasColumnName("StartDate").IsRequired();
            Property(x => x.EndDate).HasColumnName("EndDate").IsOptional();
            Property(x => x.StandardCost).HasColumnName("StandardCost").IsRequired().HasPrecision(19,4);
            Property(x => x.ModifiedDate).HasColumnName("ModifiedDate").IsRequired();

            // Foreign keys
            HasRequired(a => a.Production_Product).WithMany(b => b.Production_ProductCostHistory).HasForeignKey(c => c.ProductId); // FK_ProductCostHistory_Product_ProductID
        }
    }

    // ProductDescription
    internal class Production_ProductDescriptionConfiguration : EntityTypeConfiguration<Production_ProductDescription>
    {
        public Production_ProductDescriptionConfiguration()
        {
            ToTable("Production.ProductDescription");
            HasKey(x => x.ProductDescriptionId);

            Property(x => x.ProductDescriptionId).HasColumnName("ProductDescriptionID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.Description).HasColumnName("Description").IsRequired().HasMaxLength(400);
            Property(x => x.Rowguid).HasColumnName("rowguid").IsRequired();
            Property(x => x.ModifiedDate).HasColumnName("ModifiedDate").IsRequired();
        }
    }

    // ProductDocument
    internal class Production_ProductDocumentConfiguration : EntityTypeConfiguration<Production_ProductDocument>
    {
        public Production_ProductDocumentConfiguration()
        {
            ToTable("Production.ProductDocument");
            HasKey(x => new { x.DocumentId, x.ProductId });

            Property(x => x.ProductId).HasColumnName("ProductID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.DocumentId).HasColumnName("DocumentID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.ModifiedDate).HasColumnName("ModifiedDate").IsRequired();

            // Foreign keys
            HasRequired(a => a.Production_Product).WithMany(b => b.Production_ProductDocument).HasForeignKey(c => c.ProductId); // FK_ProductDocument_Product_ProductID
            HasRequired(a => a.Production_Document).WithMany(b => b.Production_ProductDocument).HasForeignKey(c => c.DocumentId); // FK_ProductDocument_Document_DocumentID
        }
    }

    // ProductInventory
    internal class Production_ProductInventoryConfiguration : EntityTypeConfiguration<Production_ProductInventory>
    {
        public Production_ProductInventoryConfiguration()
        {
            ToTable("Production.ProductInventory");
            HasKey(x => new { x.LocationId, x.ProductId });

            Property(x => x.ProductId).HasColumnName("ProductID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.LocationId).HasColumnName("LocationID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.Shelf).HasColumnName("Shelf").IsRequired().HasMaxLength(10);
            Property(x => x.Bin).HasColumnName("Bin").IsRequired();
            Property(x => x.Quantity).HasColumnName("Quantity").IsRequired();
            Property(x => x.Rowguid).HasColumnName("rowguid").IsRequired();
            Property(x => x.ModifiedDate).HasColumnName("ModifiedDate").IsRequired();

            // Foreign keys
            HasRequired(a => a.Production_Product).WithMany(b => b.Production_ProductInventory).HasForeignKey(c => c.ProductId); // FK_ProductInventory_Product_ProductID
            HasRequired(a => a.Production_Location).WithMany(b => b.Production_ProductInventory).HasForeignKey(c => c.LocationId); // FK_ProductInventory_Location_LocationID
        }
    }

    // ProductListPriceHistory
    internal class Production_ProductListPriceHistoryConfiguration : EntityTypeConfiguration<Production_ProductListPriceHistory>
    {
        public Production_ProductListPriceHistoryConfiguration()
        {
            ToTable("Production.ProductListPriceHistory");
            HasKey(x => new { x.ProductId, x.StartDate });

            Property(x => x.ProductId).HasColumnName("ProductID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.StartDate).HasColumnName("StartDate").IsRequired();
            Property(x => x.EndDate).HasColumnName("EndDate").IsOptional();
            Property(x => x.ListPrice).HasColumnName("ListPrice").IsRequired().HasPrecision(19,4);
            Property(x => x.ModifiedDate).HasColumnName("ModifiedDate").IsRequired();

            // Foreign keys
            HasRequired(a => a.Production_Product).WithMany(b => b.Production_ProductListPriceHistory).HasForeignKey(c => c.ProductId); // FK_ProductListPriceHistory_Product_ProductID
        }
    }

    // ProductModel
    internal class Production_ProductModelConfiguration : EntityTypeConfiguration<Production_ProductModel>
    {
        public Production_ProductModelConfiguration()
        {
            ToTable("Production.ProductModel");
            HasKey(x => x.ProductModelId);

            Property(x => x.ProductModelId).HasColumnName("ProductModelID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.Name).HasColumnName("Name").IsRequired().HasMaxLength(50);
            Property(x => x.CatalogDescription).HasColumnName("CatalogDescription").IsOptional();
            Property(x => x.Instructions).HasColumnName("Instructions").IsOptional();
            Property(x => x.Rowguid).HasColumnName("rowguid").IsRequired();
            Property(x => x.ModifiedDate).HasColumnName("ModifiedDate").IsRequired();
        }
    }

    // ProductModelIllustration
    internal class Production_ProductModelIllustrationConfiguration : EntityTypeConfiguration<Production_ProductModelIllustration>
    {
        public Production_ProductModelIllustrationConfiguration()
        {
            ToTable("Production.ProductModelIllustration");
            HasKey(x => new { x.IllustrationId, x.ProductModelId });

            Property(x => x.ProductModelId).HasColumnName("ProductModelID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.IllustrationId).HasColumnName("IllustrationID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.ModifiedDate).HasColumnName("ModifiedDate").IsRequired();

            // Foreign keys
            HasRequired(a => a.Production_ProductModel).WithMany(b => b.Production_ProductModelIllustration).HasForeignKey(c => c.ProductModelId); // FK_ProductModelIllustration_ProductModel_ProductModelID
            HasRequired(a => a.Production_Illustration).WithMany(b => b.Production_ProductModelIllustration).HasForeignKey(c => c.IllustrationId); // FK_ProductModelIllustration_Illustration_IllustrationID
        }
    }

    // ProductModelProductDescriptionCulture
    internal class Production_ProductModelProductDescriptionCultureConfiguration : EntityTypeConfiguration<Production_ProductModelProductDescriptionCulture>
    {
        public Production_ProductModelProductDescriptionCultureConfiguration()
        {
            ToTable("Production.ProductModelProductDescriptionCulture");
            HasKey(x => new { x.CultureId, x.ProductDescriptionId, x.ProductModelId });

            Property(x => x.ProductModelId).HasColumnName("ProductModelID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.ProductDescriptionId).HasColumnName("ProductDescriptionID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.CultureId).HasColumnName("CultureID").IsRequired().HasMaxLength(6);
            Property(x => x.ModifiedDate).HasColumnName("ModifiedDate").IsRequired();

            // Foreign keys
            HasRequired(a => a.Production_ProductModel).WithMany(b => b.Production_ProductModelProductDescriptionCulture).HasForeignKey(c => c.ProductModelId); // FK_ProductModelProductDescriptionCulture_ProductModel_ProductModelID
            HasRequired(a => a.Production_ProductDescription).WithMany(b => b.Production_ProductModelProductDescriptionCulture).HasForeignKey(c => c.ProductDescriptionId); // FK_ProductModelProductDescriptionCulture_ProductDescription_ProductDescriptionID
            HasRequired(a => a.Production_Culture).WithMany(b => b.Production_ProductModelProductDescriptionCulture).HasForeignKey(c => c.CultureId); // FK_ProductModelProductDescriptionCulture_Culture_CultureID
        }
    }

    // ProductPhoto
    internal class Production_ProductPhotoConfiguration : EntityTypeConfiguration<Production_ProductPhoto>
    {
        public Production_ProductPhotoConfiguration()
        {
            ToTable("Production.ProductPhoto");
            HasKey(x => x.ProductPhotoId);

            Property(x => x.ProductPhotoId).HasColumnName("ProductPhotoID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.ThumbNailPhoto).HasColumnName("ThumbNailPhoto").IsOptional();
            Property(x => x.ThumbnailPhotoFileName).HasColumnName("ThumbnailPhotoFileName").IsOptional().HasMaxLength(50);
            Property(x => x.LargePhoto).HasColumnName("LargePhoto").IsOptional();
            Property(x => x.LargePhotoFileName).HasColumnName("LargePhotoFileName").IsOptional().HasMaxLength(50);
            Property(x => x.ModifiedDate).HasColumnName("ModifiedDate").IsRequired();
        }
    }

    // ProductProductPhoto
    internal class Production_ProductProductPhotoConfiguration : EntityTypeConfiguration<Production_ProductProductPhoto>
    {
        public Production_ProductProductPhotoConfiguration()
        {
            ToTable("Production.ProductProductPhoto");
            HasKey(x => new { x.ProductId, x.ProductPhotoId });

            Property(x => x.ProductId).HasColumnName("ProductID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.ProductPhotoId).HasColumnName("ProductPhotoID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.Primary).HasColumnName("Primary").IsRequired();
            Property(x => x.ModifiedDate).HasColumnName("ModifiedDate").IsRequired();

            // Foreign keys
            HasRequired(a => a.Production_Product).WithMany(b => b.Production_ProductProductPhoto).HasForeignKey(c => c.ProductId); // FK_ProductProductPhoto_Product_ProductID
            HasRequired(a => a.Production_ProductPhoto).WithMany(b => b.Production_ProductProductPhoto).HasForeignKey(c => c.ProductPhotoId); // FK_ProductProductPhoto_ProductPhoto_ProductPhotoID
        }
    }

    // ProductReview
    internal class Production_ProductReviewConfiguration : EntityTypeConfiguration<Production_ProductReview>
    {
        public Production_ProductReviewConfiguration()
        {
            ToTable("Production.ProductReview");
            HasKey(x => x.ProductReviewId);

            Property(x => x.ProductReviewId).HasColumnName("ProductReviewID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.ProductId).HasColumnName("ProductID").IsRequired();
            Property(x => x.ReviewerName).HasColumnName("ReviewerName").IsRequired().HasMaxLength(50);
            Property(x => x.ReviewDate).HasColumnName("ReviewDate").IsRequired();
            Property(x => x.EmailAddress).HasColumnName("EmailAddress").IsRequired().HasMaxLength(50);
            Property(x => x.Rating).HasColumnName("Rating").IsRequired();
            Property(x => x.Comments).HasColumnName("Comments").IsOptional().HasMaxLength(3850);
            Property(x => x.ModifiedDate).HasColumnName("ModifiedDate").IsRequired();

            // Foreign keys
            HasRequired(a => a.Production_Product).WithMany(b => b.Production_ProductReview).HasForeignKey(c => c.ProductId); // FK_ProductReview_Product_ProductID
        }
    }

    // ProductSubcategory
    internal class Production_ProductSubcategoryConfiguration : EntityTypeConfiguration<Production_ProductSubcategory>
    {
        public Production_ProductSubcategoryConfiguration()
        {
            ToTable("Production.ProductSubcategory");
            HasKey(x => x.ProductSubcategoryId);

            Property(x => x.ProductSubcategoryId).HasColumnName("ProductSubcategoryID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.ProductCategoryId).HasColumnName("ProductCategoryID").IsRequired();
            Property(x => x.Name).HasColumnName("Name").IsRequired().HasMaxLength(50);
            Property(x => x.Rowguid).HasColumnName("rowguid").IsRequired();
            Property(x => x.ModifiedDate).HasColumnName("ModifiedDate").IsRequired();

            // Foreign keys
            HasRequired(a => a.Production_ProductCategory).WithMany(b => b.Production_ProductSubcategory).HasForeignKey(c => c.ProductCategoryId); // FK_ProductSubcategory_ProductCategory_ProductCategoryID
        }
    }

    // ScrapReason
    internal class Production_ScrapReasonConfiguration : EntityTypeConfiguration<Production_ScrapReason>
    {
        public Production_ScrapReasonConfiguration()
        {
            ToTable("Production.ScrapReason");
            HasKey(x => x.ScrapReasonId);

            Property(x => x.ScrapReasonId).HasColumnName("ScrapReasonID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.Name).HasColumnName("Name").IsRequired().HasMaxLength(50);
            Property(x => x.ModifiedDate).HasColumnName("ModifiedDate").IsRequired();
        }
    }

    // TransactionHistory
    internal class Production_TransactionHistoryConfiguration : EntityTypeConfiguration<Production_TransactionHistory>
    {
        public Production_TransactionHistoryConfiguration()
        {
            ToTable("Production.TransactionHistory");
            HasKey(x => x.TransactionId);

            Property(x => x.TransactionId).HasColumnName("TransactionID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.ProductId).HasColumnName("ProductID").IsRequired();
            Property(x => x.ReferenceOrderId).HasColumnName("ReferenceOrderID").IsRequired();
            Property(x => x.ReferenceOrderLineId).HasColumnName("ReferenceOrderLineID").IsRequired();
            Property(x => x.TransactionDate).HasColumnName("TransactionDate").IsRequired();
            Property(x => x.TransactionType).HasColumnName("TransactionType").IsRequired().HasMaxLength(1);
            Property(x => x.Quantity).HasColumnName("Quantity").IsRequired();
            Property(x => x.ActualCost).HasColumnName("ActualCost").IsRequired().HasPrecision(19,4);
            Property(x => x.ModifiedDate).HasColumnName("ModifiedDate").IsRequired();

            // Foreign keys
            HasRequired(a => a.Production_Product).WithMany(b => b.Production_TransactionHistory).HasForeignKey(c => c.ProductId); // FK_TransactionHistory_Product_ProductID
        }
    }

    // TransactionHistoryArchive
    internal class Production_TransactionHistoryArchiveConfiguration : EntityTypeConfiguration<Production_TransactionHistoryArchive>
    {
        public Production_TransactionHistoryArchiveConfiguration()
        {
            ToTable("Production.TransactionHistoryArchive");
            HasKey(x => x.TransactionId);

            Property(x => x.TransactionId).HasColumnName("TransactionID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.ProductId).HasColumnName("ProductID").IsRequired();
            Property(x => x.ReferenceOrderId).HasColumnName("ReferenceOrderID").IsRequired();
            Property(x => x.ReferenceOrderLineId).HasColumnName("ReferenceOrderLineID").IsRequired();
            Property(x => x.TransactionDate).HasColumnName("TransactionDate").IsRequired();
            Property(x => x.TransactionType).HasColumnName("TransactionType").IsRequired().HasMaxLength(1);
            Property(x => x.Quantity).HasColumnName("Quantity").IsRequired();
            Property(x => x.ActualCost).HasColumnName("ActualCost").IsRequired().HasPrecision(19,4);
            Property(x => x.ModifiedDate).HasColumnName("ModifiedDate").IsRequired();
        }
    }

    // UnitMeasure
    internal class Production_UnitMeasureConfiguration : EntityTypeConfiguration<Production_UnitMeasure>
    {
        public Production_UnitMeasureConfiguration()
        {
            ToTable("Production.UnitMeasure");
            HasKey(x => x.UnitMeasureCode);

            Property(x => x.UnitMeasureCode).HasColumnName("UnitMeasureCode").IsRequired().HasMaxLength(3);
            Property(x => x.Name).HasColumnName("Name").IsRequired().HasMaxLength(50);
            Property(x => x.ModifiedDate).HasColumnName("ModifiedDate").IsRequired();
        }
    }

    // WorkOrder
    internal class Production_WorkOrderConfiguration : EntityTypeConfiguration<Production_WorkOrder>
    {
        public Production_WorkOrderConfiguration()
        {
            ToTable("Production.WorkOrder");
            HasKey(x => x.WorkOrderId);

            Property(x => x.WorkOrderId).HasColumnName("WorkOrderID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.ProductId).HasColumnName("ProductID").IsRequired();
            Property(x => x.OrderQty).HasColumnName("OrderQty").IsRequired();
            Property(x => x.StockedQty).HasColumnName("StockedQty").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Computed);
            Property(x => x.ScrappedQty).HasColumnName("ScrappedQty").IsRequired();
            Property(x => x.StartDate).HasColumnName("StartDate").IsRequired();
            Property(x => x.EndDate).HasColumnName("EndDate").IsOptional();
            Property(x => x.DueDate).HasColumnName("DueDate").IsRequired();
            Property(x => x.ScrapReasonId).HasColumnName("ScrapReasonID").IsOptional();
            Property(x => x.ModifiedDate).HasColumnName("ModifiedDate").IsRequired();

            // Foreign keys
            HasRequired(a => a.Production_Product).WithMany(b => b.Production_WorkOrder).HasForeignKey(c => c.ProductId); // FK_WorkOrder_Product_ProductID
            HasOptional(a => a.Production_ScrapReason).WithMany(b => b.Production_WorkOrder).HasForeignKey(c => c.ScrapReasonId); // FK_WorkOrder_ScrapReason_ScrapReasonID
        }
    }

    // WorkOrderRouting
    internal class Production_WorkOrderRoutingConfiguration : EntityTypeConfiguration<Production_WorkOrderRouting>
    {
        public Production_WorkOrderRoutingConfiguration()
        {
            ToTable("Production.WorkOrderRouting");
            HasKey(x => new { x.OperationSequence, x.ProductId, x.WorkOrderId });

            Property(x => x.WorkOrderId).HasColumnName("WorkOrderID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.ProductId).HasColumnName("ProductID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.OperationSequence).HasColumnName("OperationSequence").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.LocationId).HasColumnName("LocationID").IsRequired();
            Property(x => x.ScheduledStartDate).HasColumnName("ScheduledStartDate").IsRequired();
            Property(x => x.ScheduledEndDate).HasColumnName("ScheduledEndDate").IsRequired();
            Property(x => x.ActualStartDate).HasColumnName("ActualStartDate").IsOptional();
            Property(x => x.ActualEndDate).HasColumnName("ActualEndDate").IsOptional();
            Property(x => x.ActualResourceHrs).HasColumnName("ActualResourceHrs").IsOptional().HasPrecision(9,4);
            Property(x => x.PlannedCost).HasColumnName("PlannedCost").IsRequired().HasPrecision(19,4);
            Property(x => x.ActualCost).HasColumnName("ActualCost").IsOptional().HasPrecision(19,4);
            Property(x => x.ModifiedDate).HasColumnName("ModifiedDate").IsRequired();

            // Foreign keys
            HasRequired(a => a.Production_WorkOrder).WithMany(b => b.Production_WorkOrderRouting).HasForeignKey(c => c.WorkOrderId); // FK_WorkOrderRouting_WorkOrder_WorkOrderID
            HasRequired(a => a.Production_Location).WithMany(b => b.Production_WorkOrderRouting).HasForeignKey(c => c.LocationId); // FK_WorkOrderRouting_Location_LocationID
        }
    }

    // ProductVendor
    internal class Purchasing_ProductVendorConfiguration : EntityTypeConfiguration<Purchasing_ProductVendor>
    {
        public Purchasing_ProductVendorConfiguration()
        {
            ToTable("Purchasing.ProductVendor");
            HasKey(x => new { x.ProductId, x.VendorId });

            Property(x => x.ProductId).HasColumnName("ProductID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.VendorId).HasColumnName("VendorID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.AverageLeadTime).HasColumnName("AverageLeadTime").IsRequired();
            Property(x => x.StandardPrice).HasColumnName("StandardPrice").IsRequired().HasPrecision(19,4);
            Property(x => x.LastReceiptCost).HasColumnName("LastReceiptCost").IsOptional().HasPrecision(19,4);
            Property(x => x.LastReceiptDate).HasColumnName("LastReceiptDate").IsOptional();
            Property(x => x.MinOrderQty).HasColumnName("MinOrderQty").IsRequired();
            Property(x => x.MaxOrderQty).HasColumnName("MaxOrderQty").IsRequired();
            Property(x => x.OnOrderQty).HasColumnName("OnOrderQty").IsOptional();
            Property(x => x.UnitMeasureCode).HasColumnName("UnitMeasureCode").IsRequired().HasMaxLength(3);
            Property(x => x.ModifiedDate).HasColumnName("ModifiedDate").IsRequired();

            // Foreign keys
            HasRequired(a => a.Production_Product).WithMany(b => b.Purchasing_ProductVendor).HasForeignKey(c => c.ProductId); // FK_ProductVendor_Product_ProductID
            HasRequired(a => a.Purchasing_Vendor).WithMany(b => b.Purchasing_ProductVendor).HasForeignKey(c => c.VendorId); // FK_ProductVendor_Vendor_VendorID
            HasRequired(a => a.Production_UnitMeasure).WithMany(b => b.Purchasing_ProductVendor).HasForeignKey(c => c.UnitMeasureCode); // FK_ProductVendor_UnitMeasure_UnitMeasureCode
        }
    }

    // PurchaseOrderDetail
    internal class Purchasing_PurchaseOrderDetailConfiguration : EntityTypeConfiguration<Purchasing_PurchaseOrderDetail>
    {
        public Purchasing_PurchaseOrderDetailConfiguration()
        {
            ToTable("Purchasing.PurchaseOrderDetail");
            HasKey(x => new { x.PurchaseOrderDetailId, x.PurchaseOrderId });

            Property(x => x.PurchaseOrderId).HasColumnName("PurchaseOrderID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.PurchaseOrderDetailId).HasColumnName("PurchaseOrderDetailID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.DueDate).HasColumnName("DueDate").IsRequired();
            Property(x => x.OrderQty).HasColumnName("OrderQty").IsRequired();
            Property(x => x.ProductId).HasColumnName("ProductID").IsRequired();
            Property(x => x.UnitPrice).HasColumnName("UnitPrice").IsRequired().HasPrecision(19,4);
            Property(x => x.LineTotal).HasColumnName("LineTotal").IsRequired().HasPrecision(19,4).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Computed);
            Property(x => x.ReceivedQty).HasColumnName("ReceivedQty").IsRequired().HasPrecision(8,2);
            Property(x => x.RejectedQty).HasColumnName("RejectedQty").IsRequired().HasPrecision(8,2);
            Property(x => x.StockedQty).HasColumnName("StockedQty").IsRequired().HasPrecision(9,2).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Computed);
            Property(x => x.ModifiedDate).HasColumnName("ModifiedDate").IsRequired();

            // Foreign keys
            HasRequired(a => a.Purchasing_PurchaseOrderHeader).WithMany(b => b.Purchasing_PurchaseOrderDetail).HasForeignKey(c => c.PurchaseOrderId); // FK_PurchaseOrderDetail_PurchaseOrderHeader_PurchaseOrderID
            HasRequired(a => a.Production_Product).WithMany(b => b.Purchasing_PurchaseOrderDetail).HasForeignKey(c => c.ProductId); // FK_PurchaseOrderDetail_Product_ProductID
        }
    }

    // PurchaseOrderHeader
    internal class Purchasing_PurchaseOrderHeaderConfiguration : EntityTypeConfiguration<Purchasing_PurchaseOrderHeader>
    {
        public Purchasing_PurchaseOrderHeaderConfiguration()
        {
            ToTable("Purchasing.PurchaseOrderHeader");
            HasKey(x => x.PurchaseOrderId);

            Property(x => x.PurchaseOrderId).HasColumnName("PurchaseOrderID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.RevisionNumber).HasColumnName("RevisionNumber").IsRequired();
            Property(x => x.Status).HasColumnName("Status").IsRequired();
            Property(x => x.EmployeeId).HasColumnName("EmployeeID").IsRequired();
            Property(x => x.VendorId).HasColumnName("VendorID").IsRequired();
            Property(x => x.ShipMethodId).HasColumnName("ShipMethodID").IsRequired();
            Property(x => x.OrderDate).HasColumnName("OrderDate").IsRequired();
            Property(x => x.ShipDate).HasColumnName("ShipDate").IsOptional();
            Property(x => x.SubTotal).HasColumnName("SubTotal").IsRequired().HasPrecision(19,4);
            Property(x => x.TaxAmt).HasColumnName("TaxAmt").IsRequired().HasPrecision(19,4);
            Property(x => x.Freight).HasColumnName("Freight").IsRequired().HasPrecision(19,4);
            Property(x => x.TotalDue).HasColumnName("TotalDue").IsRequired().HasPrecision(19,4).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Computed);
            Property(x => x.ModifiedDate).HasColumnName("ModifiedDate").IsRequired();

            // Foreign keys
            HasRequired(a => a.HumanResources_Employee).WithMany(b => b.Purchasing_PurchaseOrderHeader).HasForeignKey(c => c.EmployeeId); // FK_PurchaseOrderHeader_Employee_EmployeeID
            HasRequired(a => a.Purchasing_Vendor).WithMany(b => b.Purchasing_PurchaseOrderHeader).HasForeignKey(c => c.VendorId); // FK_PurchaseOrderHeader_Vendor_VendorID
            HasRequired(a => a.Purchasing_ShipMethod).WithMany(b => b.Purchasing_PurchaseOrderHeader).HasForeignKey(c => c.ShipMethodId); // FK_PurchaseOrderHeader_ShipMethod_ShipMethodID
        }
    }

    // ShipMethod
    internal class Purchasing_ShipMethodConfiguration : EntityTypeConfiguration<Purchasing_ShipMethod>
    {
        public Purchasing_ShipMethodConfiguration()
        {
            ToTable("Purchasing.ShipMethod");
            HasKey(x => x.ShipMethodId);

            Property(x => x.ShipMethodId).HasColumnName("ShipMethodID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.Name).HasColumnName("Name").IsRequired().HasMaxLength(50);
            Property(x => x.ShipBase).HasColumnName("ShipBase").IsRequired().HasPrecision(19,4);
            Property(x => x.ShipRate).HasColumnName("ShipRate").IsRequired().HasPrecision(19,4);
            Property(x => x.Rowguid).HasColumnName("rowguid").IsRequired();
            Property(x => x.ModifiedDate).HasColumnName("ModifiedDate").IsRequired();
        }
    }

    // Vendor
    internal class Purchasing_VendorConfiguration : EntityTypeConfiguration<Purchasing_Vendor>
    {
        public Purchasing_VendorConfiguration()
        {
            ToTable("Purchasing.Vendor");
            HasKey(x => x.VendorId);

            Property(x => x.VendorId).HasColumnName("VendorID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.AccountNumber).HasColumnName("AccountNumber").IsRequired().HasMaxLength(15);
            Property(x => x.Name).HasColumnName("Name").IsRequired().HasMaxLength(50);
            Property(x => x.CreditRating).HasColumnName("CreditRating").IsRequired();
            Property(x => x.PreferredVendorStatus).HasColumnName("PreferredVendorStatus").IsRequired();
            Property(x => x.ActiveFlag).HasColumnName("ActiveFlag").IsRequired();
            Property(x => x.PurchasingWebServiceUrl).HasColumnName("PurchasingWebServiceURL").IsOptional().HasMaxLength(1024);
            Property(x => x.ModifiedDate).HasColumnName("ModifiedDate").IsRequired();
        }
    }

    // VendorAddress
    internal class Purchasing_VendorAddressConfiguration : EntityTypeConfiguration<Purchasing_VendorAddress>
    {
        public Purchasing_VendorAddressConfiguration()
        {
            ToTable("Purchasing.VendorAddress");
            HasKey(x => new { x.AddressId, x.VendorId });

            Property(x => x.VendorId).HasColumnName("VendorID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.AddressId).HasColumnName("AddressID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.AddressTypeId).HasColumnName("AddressTypeID").IsRequired();
            Property(x => x.ModifiedDate).HasColumnName("ModifiedDate").IsRequired();

            // Foreign keys
            HasRequired(a => a.Purchasing_Vendor).WithMany(b => b.Purchasing_VendorAddress).HasForeignKey(c => c.VendorId); // FK_VendorAddress_Vendor_VendorID
            HasRequired(a => a.Person_Address).WithMany(b => b.Purchasing_VendorAddress).HasForeignKey(c => c.AddressId); // FK_VendorAddress_Address_AddressID
            HasRequired(a => a.Person_AddressType).WithMany(b => b.Purchasing_VendorAddress).HasForeignKey(c => c.AddressTypeId); // FK_VendorAddress_AddressType_AddressTypeID
        }
    }

    // VendorContact
    internal class Purchasing_VendorContactConfiguration : EntityTypeConfiguration<Purchasing_VendorContact>
    {
        public Purchasing_VendorContactConfiguration()
        {
            ToTable("Purchasing.VendorContact");
            HasKey(x => new { x.ContactId, x.VendorId });

            Property(x => x.VendorId).HasColumnName("VendorID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.ContactId).HasColumnName("ContactID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.ContactTypeId).HasColumnName("ContactTypeID").IsRequired();
            Property(x => x.ModifiedDate).HasColumnName("ModifiedDate").IsRequired();

            // Foreign keys
            HasRequired(a => a.Purchasing_Vendor).WithMany(b => b.Purchasing_VendorContact).HasForeignKey(c => c.VendorId); // FK_VendorContact_Vendor_VendorID
            HasRequired(a => a.Person_Contact).WithMany(b => b.Purchasing_VendorContact).HasForeignKey(c => c.ContactId); // FK_VendorContact_Contact_ContactID
            HasRequired(a => a.Person_ContactType).WithMany(b => b.Purchasing_VendorContact).HasForeignKey(c => c.ContactTypeId); // FK_VendorContact_ContactType_ContactTypeID
        }
    }

    // ContactCreditCard
    internal class Sales_ContactCreditCardConfiguration : EntityTypeConfiguration<Sales_ContactCreditCard>
    {
        public Sales_ContactCreditCardConfiguration()
        {
            ToTable("Sales.ContactCreditCard");
            HasKey(x => new { x.ContactId, x.CreditCardId });

            Property(x => x.ContactId).HasColumnName("ContactID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.CreditCardId).HasColumnName("CreditCardID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.ModifiedDate).HasColumnName("ModifiedDate").IsRequired();

            // Foreign keys
            HasRequired(a => a.Person_Contact).WithMany(b => b.Sales_ContactCreditCard).HasForeignKey(c => c.ContactId); // FK_ContactCreditCard_Contact_ContactID
            HasRequired(a => a.Sales_CreditCard).WithMany(b => b.Sales_ContactCreditCard).HasForeignKey(c => c.CreditCardId); // FK_ContactCreditCard_CreditCard_CreditCardID
        }
    }

    // CountryRegionCurrency
    internal class Sales_CountryRegionCurrencyConfiguration : EntityTypeConfiguration<Sales_CountryRegionCurrency>
    {
        public Sales_CountryRegionCurrencyConfiguration()
        {
            ToTable("Sales.CountryRegionCurrency");
            HasKey(x => new { x.CountryRegionCode, x.CurrencyCode });

            Property(x => x.CountryRegionCode).HasColumnName("CountryRegionCode").IsRequired().HasMaxLength(3);
            Property(x => x.CurrencyCode).HasColumnName("CurrencyCode").IsRequired().HasMaxLength(3);
            Property(x => x.ModifiedDate).HasColumnName("ModifiedDate").IsRequired();

            // Foreign keys
            HasRequired(a => a.Person_CountryRegion).WithMany(b => b.Sales_CountryRegionCurrency).HasForeignKey(c => c.CountryRegionCode); // FK_CountryRegionCurrency_CountryRegion_CountryRegionCode
            HasRequired(a => a.Sales_Currency).WithMany(b => b.Sales_CountryRegionCurrency).HasForeignKey(c => c.CurrencyCode); // FK_CountryRegionCurrency_Currency_CurrencyCode
        }
    }

    // CreditCard
    internal class Sales_CreditCardConfiguration : EntityTypeConfiguration<Sales_CreditCard>
    {
        public Sales_CreditCardConfiguration()
        {
            ToTable("Sales.CreditCard");
            HasKey(x => x.CreditCardId);

            Property(x => x.CreditCardId).HasColumnName("CreditCardID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.CardType).HasColumnName("CardType").IsRequired().HasMaxLength(50);
            Property(x => x.CardNumber).HasColumnName("CardNumber").IsRequired().HasMaxLength(25);
            Property(x => x.ExpMonth).HasColumnName("ExpMonth").IsRequired();
            Property(x => x.ExpYear).HasColumnName("ExpYear").IsRequired();
            Property(x => x.ModifiedDate).HasColumnName("ModifiedDate").IsRequired();
        }
    }

    // Currency
    internal class Sales_CurrencyConfiguration : EntityTypeConfiguration<Sales_Currency>
    {
        public Sales_CurrencyConfiguration()
        {
            ToTable("Sales.Currency");
            HasKey(x => x.CurrencyCode);

            Property(x => x.CurrencyCode).HasColumnName("CurrencyCode").IsRequired().HasMaxLength(3);
            Property(x => x.Name).HasColumnName("Name").IsRequired().HasMaxLength(50);
            Property(x => x.ModifiedDate).HasColumnName("ModifiedDate").IsRequired();
        }
    }

    // CurrencyRate
    internal class Sales_CurrencyRateConfiguration : EntityTypeConfiguration<Sales_CurrencyRate>
    {
        public Sales_CurrencyRateConfiguration()
        {
            ToTable("Sales.CurrencyRate");
            HasKey(x => x.CurrencyRateId);

            Property(x => x.CurrencyRateId).HasColumnName("CurrencyRateID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.CurrencyRateDate).HasColumnName("CurrencyRateDate").IsRequired();
            Property(x => x.FromCurrencyCode).HasColumnName("FromCurrencyCode").IsRequired().HasMaxLength(3);
            Property(x => x.ToCurrencyCode).HasColumnName("ToCurrencyCode").IsRequired().HasMaxLength(3);
            Property(x => x.AverageRate).HasColumnName("AverageRate").IsRequired().HasPrecision(19,4);
            Property(x => x.EndOfDayRate).HasColumnName("EndOfDayRate").IsRequired().HasPrecision(19,4);
            Property(x => x.ModifiedDate).HasColumnName("ModifiedDate").IsRequired();

            // Foreign keys
            HasRequired(a => a.Sales_Currency).WithMany(b => b.Sales_CurrencyRate).HasForeignKey(c => c.FromCurrencyCode); // FK_CurrencyRate_Currency_FromCurrencyCode
            HasRequired(a => a.Sales_Currency1).WithMany(b => b.Sales_CurrencyRate1).HasForeignKey(c => c.ToCurrencyCode); // FK_CurrencyRate_Currency_ToCurrencyCode
        }
    }

    // Customer
    internal class Sales_CustomerConfiguration : EntityTypeConfiguration<Sales_Customer>
    {
        public Sales_CustomerConfiguration()
        {
            ToTable("Sales.Customer");
            HasKey(x => x.CustomerId);

            Property(x => x.CustomerId).HasColumnName("CustomerID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.TerritoryId).HasColumnName("TerritoryID").IsOptional();
            Property(x => x.AccountNumber).HasColumnName("AccountNumber").IsRequired().HasMaxLength(10);
            Property(x => x.CustomerType).HasColumnName("CustomerType").IsRequired().HasMaxLength(1);
            Property(x => x.Rowguid).HasColumnName("rowguid").IsRequired();
            Property(x => x.ModifiedDate).HasColumnName("ModifiedDate").IsRequired();

            // Foreign keys
            HasOptional(a => a.Sales_SalesTerritory).WithMany(b => b.Sales_Customer).HasForeignKey(c => c.TerritoryId); // FK_Customer_SalesTerritory_TerritoryID
        }
    }

    // CustomerAddress
    internal class Sales_CustomerAddressConfiguration : EntityTypeConfiguration<Sales_CustomerAddress>
    {
        public Sales_CustomerAddressConfiguration()
        {
            ToTable("Sales.CustomerAddress");
            HasKey(x => new { x.AddressId, x.CustomerId });

            Property(x => x.CustomerId).HasColumnName("CustomerID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.AddressId).HasColumnName("AddressID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.AddressTypeId).HasColumnName("AddressTypeID").IsRequired();
            Property(x => x.Rowguid).HasColumnName("rowguid").IsRequired();
            Property(x => x.ModifiedDate).HasColumnName("ModifiedDate").IsRequired();

            // Foreign keys
            HasRequired(a => a.Sales_Customer).WithMany(b => b.Sales_CustomerAddress).HasForeignKey(c => c.CustomerId); // FK_CustomerAddress_Customer_CustomerID
            HasRequired(a => a.Person_Address).WithMany(b => b.Sales_CustomerAddress).HasForeignKey(c => c.AddressId); // FK_CustomerAddress_Address_AddressID
            HasRequired(a => a.Person_AddressType).WithMany(b => b.Sales_CustomerAddress).HasForeignKey(c => c.AddressTypeId); // FK_CustomerAddress_AddressType_AddressTypeID
        }
    }

    // Individual
    internal class Sales_IndividualConfiguration : EntityTypeConfiguration<Sales_Individual>
    {
        public Sales_IndividualConfiguration()
        {
            ToTable("Sales.Individual");
            HasKey(x => x.CustomerId);

            Property(x => x.CustomerId).HasColumnName("CustomerID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.ContactId).HasColumnName("ContactID").IsRequired();
            Property(x => x.Demographics).HasColumnName("Demographics").IsOptional();
            Property(x => x.ModifiedDate).HasColumnName("ModifiedDate").IsRequired();

            // Foreign keys
            HasRequired(a => a.Sales_Customer).WithOptional(b => b.Sales_Individual); // FK_Individual_Customer_CustomerID
            HasRequired(a => a.Person_Contact).WithMany(b => b.Sales_Individual).HasForeignKey(c => c.ContactId); // FK_Individual_Contact_ContactID
        }
    }

    // SalesOrderDetail
    internal class Sales_SalesOrderDetailConfiguration : EntityTypeConfiguration<Sales_SalesOrderDetail>
    {
        public Sales_SalesOrderDetailConfiguration()
        {
            ToTable("Sales.SalesOrderDetail");
            HasKey(x => new { x.SalesOrderDetailId, x.SalesOrderId });

            Property(x => x.SalesOrderId).HasColumnName("SalesOrderID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.SalesOrderDetailId).HasColumnName("SalesOrderDetailID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.CarrierTrackingNumber).HasColumnName("CarrierTrackingNumber").IsOptional().HasMaxLength(25);
            Property(x => x.OrderQty).HasColumnName("OrderQty").IsRequired();
            Property(x => x.ProductId).HasColumnName("ProductID").IsRequired();
            Property(x => x.SpecialOfferId).HasColumnName("SpecialOfferID").IsRequired();
            Property(x => x.UnitPrice).HasColumnName("UnitPrice").IsRequired().HasPrecision(19,4);
            Property(x => x.UnitPriceDiscount).HasColumnName("UnitPriceDiscount").IsRequired().HasPrecision(19,4);
            Property(x => x.LineTotal).HasColumnName("LineTotal").IsRequired().HasPrecision(38,6).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Computed);
            Property(x => x.Rowguid).HasColumnName("rowguid").IsRequired();
            Property(x => x.ModifiedDate).HasColumnName("ModifiedDate").IsRequired();

            // Foreign keys
            HasRequired(a => a.Sales_SalesOrderHeader).WithMany(b => b.Sales_SalesOrderDetail).HasForeignKey(c => c.SalesOrderId); // FK_SalesOrderDetail_SalesOrderHeader_SalesOrderID
        }
    }

    // SalesOrderHeader
    internal class Sales_SalesOrderHeaderConfiguration : EntityTypeConfiguration<Sales_SalesOrderHeader>
    {
        public Sales_SalesOrderHeaderConfiguration()
        {
            ToTable("Sales.SalesOrderHeader");
            HasKey(x => x.SalesOrderId);

            Property(x => x.SalesOrderId).HasColumnName("SalesOrderID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.RevisionNumber).HasColumnName("RevisionNumber").IsRequired();
            Property(x => x.OrderDate).HasColumnName("OrderDate").IsRequired();
            Property(x => x.DueDate).HasColumnName("DueDate").IsRequired();
            Property(x => x.ShipDate).HasColumnName("ShipDate").IsOptional();
            Property(x => x.Status).HasColumnName("Status").IsRequired();
            Property(x => x.OnlineOrderFlag).HasColumnName("OnlineOrderFlag").IsRequired();
            Property(x => x.SalesOrderNumber).HasColumnName("SalesOrderNumber").IsRequired().HasMaxLength(25);
            Property(x => x.PurchaseOrderNumber).HasColumnName("PurchaseOrderNumber").IsOptional().HasMaxLength(25);
            Property(x => x.AccountNumber).HasColumnName("AccountNumber").IsOptional().HasMaxLength(15);
            Property(x => x.CustomerId).HasColumnName("CustomerID").IsRequired();
            Property(x => x.ContactId).HasColumnName("ContactID").IsRequired();
            Property(x => x.SalesPersonId).HasColumnName("SalesPersonID").IsOptional();
            Property(x => x.TerritoryId).HasColumnName("TerritoryID").IsOptional();
            Property(x => x.BillToAddressId).HasColumnName("BillToAddressID").IsRequired();
            Property(x => x.ShipToAddressId).HasColumnName("ShipToAddressID").IsRequired();
            Property(x => x.ShipMethodId).HasColumnName("ShipMethodID").IsRequired();
            Property(x => x.CreditCardId).HasColumnName("CreditCardID").IsOptional();
            Property(x => x.CreditCardApprovalCode).HasColumnName("CreditCardApprovalCode").IsOptional().HasMaxLength(15);
            Property(x => x.CurrencyRateId).HasColumnName("CurrencyRateID").IsOptional();
            Property(x => x.SubTotal).HasColumnName("SubTotal").IsRequired().HasPrecision(19,4);
            Property(x => x.TaxAmt).HasColumnName("TaxAmt").IsRequired().HasPrecision(19,4);
            Property(x => x.Freight).HasColumnName("Freight").IsRequired().HasPrecision(19,4);
            Property(x => x.TotalDue).HasColumnName("TotalDue").IsRequired().HasPrecision(19,4).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Computed);
            Property(x => x.Comment).HasColumnName("Comment").IsOptional().HasMaxLength(128);
            Property(x => x.Rowguid).HasColumnName("rowguid").IsRequired();
            Property(x => x.ModifiedDate).HasColumnName("ModifiedDate").IsRequired();

            // Foreign keys
            HasRequired(a => a.Sales_Customer).WithMany(b => b.Sales_SalesOrderHeader).HasForeignKey(c => c.CustomerId); // FK_SalesOrderHeader_Customer_CustomerID
            HasRequired(a => a.Person_Contact).WithMany(b => b.Sales_SalesOrderHeader).HasForeignKey(c => c.ContactId); // FK_SalesOrderHeader_Contact_ContactID
            HasOptional(a => a.Sales_SalesPerson).WithMany(b => b.Sales_SalesOrderHeader).HasForeignKey(c => c.SalesPersonId); // FK_SalesOrderHeader_SalesPerson_SalesPersonID
            HasOptional(a => a.Sales_SalesTerritory).WithMany(b => b.Sales_SalesOrderHeader).HasForeignKey(c => c.TerritoryId); // FK_SalesOrderHeader_SalesTerritory_TerritoryID
            HasRequired(a => a.Person_Address).WithMany(b => b.Sales_SalesOrderHeader).HasForeignKey(c => c.BillToAddressId); // FK_SalesOrderHeader_Address_BillToAddressID
            HasRequired(a => a.Person_Address1).WithMany(b => b.Sales_SalesOrderHeader1).HasForeignKey(c => c.ShipToAddressId); // FK_SalesOrderHeader_Address_ShipToAddressID
            HasRequired(a => a.Purchasing_ShipMethod).WithMany(b => b.Sales_SalesOrderHeader).HasForeignKey(c => c.ShipMethodId); // FK_SalesOrderHeader_ShipMethod_ShipMethodID
            HasOptional(a => a.Sales_CreditCard).WithMany(b => b.Sales_SalesOrderHeader).HasForeignKey(c => c.CreditCardId); // FK_SalesOrderHeader_CreditCard_CreditCardID
            HasOptional(a => a.Sales_CurrencyRate).WithMany(b => b.Sales_SalesOrderHeader).HasForeignKey(c => c.CurrencyRateId); // FK_SalesOrderHeader_CurrencyRate_CurrencyRateID
        }
    }

    // SalesOrderHeaderSalesReason
    internal class Sales_SalesOrderHeaderSalesReasonConfiguration : EntityTypeConfiguration<Sales_SalesOrderHeaderSalesReason>
    {
        public Sales_SalesOrderHeaderSalesReasonConfiguration()
        {
            ToTable("Sales.SalesOrderHeaderSalesReason");
            HasKey(x => new { x.SalesOrderId, x.SalesReasonId });

            Property(x => x.SalesOrderId).HasColumnName("SalesOrderID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.SalesReasonId).HasColumnName("SalesReasonID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.ModifiedDate).HasColumnName("ModifiedDate").IsRequired();

            // Foreign keys
            HasRequired(a => a.Sales_SalesOrderHeader).WithMany(b => b.Sales_SalesOrderHeaderSalesReason).HasForeignKey(c => c.SalesOrderId); // FK_SalesOrderHeaderSalesReason_SalesOrderHeader_SalesOrderID
            HasRequired(a => a.Sales_SalesReason).WithMany(b => b.Sales_SalesOrderHeaderSalesReason).HasForeignKey(c => c.SalesReasonId); // FK_SalesOrderHeaderSalesReason_SalesReason_SalesReasonID
        }
    }

    // SalesPerson
    internal class Sales_SalesPersonConfiguration : EntityTypeConfiguration<Sales_SalesPerson>
    {
        public Sales_SalesPersonConfiguration()
        {
            ToTable("Sales.SalesPerson");
            HasKey(x => x.SalesPersonId);

            Property(x => x.SalesPersonId).HasColumnName("SalesPersonID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.TerritoryId).HasColumnName("TerritoryID").IsOptional();
            Property(x => x.SalesQuota).HasColumnName("SalesQuota").IsOptional().HasPrecision(19,4);
            Property(x => x.Bonus).HasColumnName("Bonus").IsRequired().HasPrecision(19,4);
            Property(x => x.CommissionPct).HasColumnName("CommissionPct").IsRequired().HasPrecision(10,4);
            Property(x => x.SalesYtd).HasColumnName("SalesYTD").IsRequired().HasPrecision(19,4);
            Property(x => x.SalesLastYear).HasColumnName("SalesLastYear").IsRequired().HasPrecision(19,4);
            Property(x => x.Rowguid).HasColumnName("rowguid").IsRequired();
            Property(x => x.ModifiedDate).HasColumnName("ModifiedDate").IsRequired();

            // Foreign keys
            HasRequired(a => a.HumanResources_Employee).WithOptional(b => b.Sales_SalesPerson); // FK_SalesPerson_Employee_SalesPersonID
            HasOptional(a => a.Sales_SalesTerritory).WithMany(b => b.Sales_SalesPerson).HasForeignKey(c => c.TerritoryId); // FK_SalesPerson_SalesTerritory_TerritoryID
        }
    }

    // SalesPersonQuotaHistory
    internal class Sales_SalesPersonQuotaHistoryConfiguration : EntityTypeConfiguration<Sales_SalesPersonQuotaHistory>
    {
        public Sales_SalesPersonQuotaHistoryConfiguration()
        {
            ToTable("Sales.SalesPersonQuotaHistory");
            HasKey(x => new { x.QuotaDate, x.SalesPersonId });

            Property(x => x.SalesPersonId).HasColumnName("SalesPersonID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.QuotaDate).HasColumnName("QuotaDate").IsRequired();
            Property(x => x.SalesQuota).HasColumnName("SalesQuota").IsRequired().HasPrecision(19,4);
            Property(x => x.Rowguid).HasColumnName("rowguid").IsRequired();
            Property(x => x.ModifiedDate).HasColumnName("ModifiedDate").IsRequired();

            // Foreign keys
            HasRequired(a => a.Sales_SalesPerson).WithMany(b => b.Sales_SalesPersonQuotaHistory).HasForeignKey(c => c.SalesPersonId); // FK_SalesPersonQuotaHistory_SalesPerson_SalesPersonID
        }
    }

    // SalesReason
    internal class Sales_SalesReasonConfiguration : EntityTypeConfiguration<Sales_SalesReason>
    {
        public Sales_SalesReasonConfiguration()
        {
            ToTable("Sales.SalesReason");
            HasKey(x => x.SalesReasonId);

            Property(x => x.SalesReasonId).HasColumnName("SalesReasonID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.Name).HasColumnName("Name").IsRequired().HasMaxLength(50);
            Property(x => x.ReasonType).HasColumnName("ReasonType").IsRequired().HasMaxLength(50);
            Property(x => x.ModifiedDate).HasColumnName("ModifiedDate").IsRequired();
        }
    }

    // SalesTaxRate
    internal class Sales_SalesTaxRateConfiguration : EntityTypeConfiguration<Sales_SalesTaxRate>
    {
        public Sales_SalesTaxRateConfiguration()
        {
            ToTable("Sales.SalesTaxRate");
            HasKey(x => x.SalesTaxRateId);

            Property(x => x.SalesTaxRateId).HasColumnName("SalesTaxRateID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.StateProvinceId).HasColumnName("StateProvinceID").IsRequired();
            Property(x => x.TaxType).HasColumnName("TaxType").IsRequired();
            Property(x => x.TaxRate).HasColumnName("TaxRate").IsRequired().HasPrecision(10,4);
            Property(x => x.Name).HasColumnName("Name").IsRequired().HasMaxLength(50);
            Property(x => x.Rowguid).HasColumnName("rowguid").IsRequired();
            Property(x => x.ModifiedDate).HasColumnName("ModifiedDate").IsRequired();

            // Foreign keys
            HasRequired(a => a.Person_StateProvince).WithMany(b => b.Sales_SalesTaxRate).HasForeignKey(c => c.StateProvinceId); // FK_SalesTaxRate_StateProvince_StateProvinceID
        }
    }

    // SalesTerritory
    internal class Sales_SalesTerritoryConfiguration : EntityTypeConfiguration<Sales_SalesTerritory>
    {
        public Sales_SalesTerritoryConfiguration()
        {
            ToTable("Sales.SalesTerritory");
            HasKey(x => x.TerritoryId);

            Property(x => x.TerritoryId).HasColumnName("TerritoryID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.Name).HasColumnName("Name").IsRequired().HasMaxLength(50);
            Property(x => x.CountryRegionCode).HasColumnName("CountryRegionCode").IsRequired().HasMaxLength(3);
            Property(x => x.Group).HasColumnName("Group").IsRequired().HasMaxLength(50);
            Property(x => x.SalesYtd).HasColumnName("SalesYTD").IsRequired().HasPrecision(19,4);
            Property(x => x.SalesLastYear).HasColumnName("SalesLastYear").IsRequired().HasPrecision(19,4);
            Property(x => x.CostYtd).HasColumnName("CostYTD").IsRequired().HasPrecision(19,4);
            Property(x => x.CostLastYear).HasColumnName("CostLastYear").IsRequired().HasPrecision(19,4);
            Property(x => x.Rowguid).HasColumnName("rowguid").IsRequired();
            Property(x => x.ModifiedDate).HasColumnName("ModifiedDate").IsRequired();
        }
    }

    // SalesTerritoryHistory
    internal class Sales_SalesTerritoryHistoryConfiguration : EntityTypeConfiguration<Sales_SalesTerritoryHistory>
    {
        public Sales_SalesTerritoryHistoryConfiguration()
        {
            ToTable("Sales.SalesTerritoryHistory");
            HasKey(x => new { x.SalesPersonId, x.StartDate, x.TerritoryId });

            Property(x => x.SalesPersonId).HasColumnName("SalesPersonID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.TerritoryId).HasColumnName("TerritoryID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.StartDate).HasColumnName("StartDate").IsRequired();
            Property(x => x.EndDate).HasColumnName("EndDate").IsOptional();
            Property(x => x.Rowguid).HasColumnName("rowguid").IsRequired();
            Property(x => x.ModifiedDate).HasColumnName("ModifiedDate").IsRequired();

            // Foreign keys
            HasRequired(a => a.Sales_SalesPerson).WithMany(b => b.Sales_SalesTerritoryHistory).HasForeignKey(c => c.SalesPersonId); // FK_SalesTerritoryHistory_SalesPerson_SalesPersonID
            HasRequired(a => a.Sales_SalesTerritory).WithMany(b => b.Sales_SalesTerritoryHistory).HasForeignKey(c => c.TerritoryId); // FK_SalesTerritoryHistory_SalesTerritory_TerritoryID
        }
    }

    // ShoppingCartItem
    internal class Sales_ShoppingCartItemConfiguration : EntityTypeConfiguration<Sales_ShoppingCartItem>
    {
        public Sales_ShoppingCartItemConfiguration()
        {
            ToTable("Sales.ShoppingCartItem");
            HasKey(x => x.ShoppingCartItemId);

            Property(x => x.ShoppingCartItemId).HasColumnName("ShoppingCartItemID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.ShoppingCartId).HasColumnName("ShoppingCartID").IsRequired().HasMaxLength(50);
            Property(x => x.Quantity).HasColumnName("Quantity").IsRequired();
            Property(x => x.ProductId).HasColumnName("ProductID").IsRequired();
            Property(x => x.DateCreated).HasColumnName("DateCreated").IsRequired();
            Property(x => x.ModifiedDate).HasColumnName("ModifiedDate").IsRequired();

            // Foreign keys
            HasRequired(a => a.Production_Product).WithMany(b => b.Sales_ShoppingCartItem).HasForeignKey(c => c.ProductId); // FK_ShoppingCartItem_Product_ProductID
        }
    }

    // SpecialOffer
    internal class Sales_SpecialOfferConfiguration : EntityTypeConfiguration<Sales_SpecialOffer>
    {
        public Sales_SpecialOfferConfiguration()
        {
            ToTable("Sales.SpecialOffer");
            HasKey(x => x.SpecialOfferId);

            Property(x => x.SpecialOfferId).HasColumnName("SpecialOfferID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.Description).HasColumnName("Description").IsRequired().HasMaxLength(255);
            Property(x => x.DiscountPct).HasColumnName("DiscountPct").IsRequired().HasPrecision(10,4);
            Property(x => x.Type).HasColumnName("Type").IsRequired().HasMaxLength(50);
            Property(x => x.Category).HasColumnName("Category").IsRequired().HasMaxLength(50);
            Property(x => x.StartDate).HasColumnName("StartDate").IsRequired();
            Property(x => x.EndDate).HasColumnName("EndDate").IsRequired();
            Property(x => x.MinQty).HasColumnName("MinQty").IsRequired();
            Property(x => x.MaxQty).HasColumnName("MaxQty").IsOptional();
            Property(x => x.Rowguid).HasColumnName("rowguid").IsRequired();
            Property(x => x.ModifiedDate).HasColumnName("ModifiedDate").IsRequired();
        }
    }

    // SpecialOfferProduct
    internal class Sales_SpecialOfferProductConfiguration : EntityTypeConfiguration<Sales_SpecialOfferProduct>
    {
        public Sales_SpecialOfferProductConfiguration()
        {
            ToTable("Sales.SpecialOfferProduct");
            HasKey(x => new { x.ProductId, x.SpecialOfferId });

            Property(x => x.SpecialOfferId).HasColumnName("SpecialOfferID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.ProductId).HasColumnName("ProductID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.Rowguid).HasColumnName("rowguid").IsRequired();
            Property(x => x.ModifiedDate).HasColumnName("ModifiedDate").IsRequired();

            // Foreign keys
            HasRequired(a => a.Sales_SpecialOffer).WithMany(b => b.Sales_SpecialOfferProduct).HasForeignKey(c => c.SpecialOfferId); // FK_SpecialOfferProduct_SpecialOffer_SpecialOfferID
            HasRequired(a => a.Production_Product).WithMany(b => b.Sales_SpecialOfferProduct).HasForeignKey(c => c.ProductId); // FK_SpecialOfferProduct_Product_ProductID
        }
    }

    // Store
    internal class Sales_StoreConfiguration : EntityTypeConfiguration<Sales_Store>
    {
        public Sales_StoreConfiguration()
        {
            ToTable("Sales.Store");
            HasKey(x => x.CustomerId);

            Property(x => x.CustomerId).HasColumnName("CustomerID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.Name).HasColumnName("Name").IsRequired().HasMaxLength(50);
            Property(x => x.SalesPersonId).HasColumnName("SalesPersonID").IsOptional();
            Property(x => x.Demographics).HasColumnName("Demographics").IsOptional();
            Property(x => x.Rowguid).HasColumnName("rowguid").IsRequired();
            Property(x => x.ModifiedDate).HasColumnName("ModifiedDate").IsRequired();

            // Foreign keys
            HasRequired(a => a.Sales_Customer).WithOptional(b => b.Sales_Store); // FK_Store_Customer_CustomerID
            HasOptional(a => a.Sales_SalesPerson).WithMany(b => b.Sales_Store).HasForeignKey(c => c.SalesPersonId); // FK_Store_SalesPerson_SalesPersonID
        }
    }

    // StoreContact
    internal class Sales_StoreContactConfiguration : EntityTypeConfiguration<Sales_StoreContact>
    {
        public Sales_StoreContactConfiguration()
        {
            ToTable("Sales.StoreContact");
            HasKey(x => new { x.ContactId, x.CustomerId });

            Property(x => x.CustomerId).HasColumnName("CustomerID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.ContactId).HasColumnName("ContactID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.ContactTypeId).HasColumnName("ContactTypeID").IsRequired();
            Property(x => x.Rowguid).HasColumnName("rowguid").IsRequired();
            Property(x => x.ModifiedDate).HasColumnName("ModifiedDate").IsRequired();

            // Foreign keys
            HasRequired(a => a.Sales_Store).WithMany(b => b.Sales_StoreContact).HasForeignKey(c => c.CustomerId); // FK_StoreContact_Store_CustomerID
            HasRequired(a => a.Person_Contact).WithMany(b => b.Sales_StoreContact).HasForeignKey(c => c.ContactId); // FK_StoreContact_Contact_ContactID
            HasRequired(a => a.Person_ContactType).WithMany(b => b.Sales_StoreContact).HasForeignKey(c => c.ContactTypeId); // FK_StoreContact_ContactType_ContactTypeID
        }
    }

    // WebSiteHits
    internal class Sales_WebSiteHitsConfiguration : EntityTypeConfiguration<Sales_WebSiteHits>
    {
        public Sales_WebSiteHitsConfiguration()
        {
            ToTable("Sales.WebSiteHits");
            HasKey(x => new { x.HitDate, x.WebSiteHitId });

            Property(x => x.WebSiteHitId).HasColumnName("WebSiteHitID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.WebSitePage).HasColumnName("WebSitePage").IsRequired().HasMaxLength(255);
            Property(x => x.HitDate).HasColumnName("HitDate").IsRequired();
        }
    }

}

