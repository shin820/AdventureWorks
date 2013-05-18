using System.Data.Entity;
using AdventureWorks.DataAccess.Configurations;
using AdventureWorks.DataAccess.Configurations.HumanResources;
using AdventureWorks.DataAccess.Configurations.Person;
using AdventureWorks.DataAccess.Configurations.Production;
using AdventureWorks.DataAccess.Configurations.Purchasing;
using AdventureWorks.DataAccess.Configurations.Sales;
using AdventureWorks.Model;
using AdventureWorks.Model.HumanResources;
using AdventureWorks.Model.Person;
using AdventureWorks.Model.Production;
using AdventureWorks.Model.Purchasing;
using AdventureWorks.Model.Sales;

namespace AdventureWorks.IntegrationTest
{
    public class AdventureWorksContext : DbContext
    {
        public IDbSet<AwBuildVersion> AwBuildVersion { get; set; } // AWBuildVersion
        public IDbSet<DatabaseLog> DatabaseLog { get; set; } // DatabaseLog
        public IDbSet<ErrorLog> ErrorLog { get; set; } // ErrorLog
        public IDbSet<Department> HumanResources_Department { get; set; } // Department
        public IDbSet<Employee> HumanResources_Employee { get; set; } // Employee
        public IDbSet<EmployeeAddress> HumanResources_EmployeeAddress { get; set; } // EmployeeAddress
        public IDbSet<EmployeeDepartmentHistory> HumanResources_EmployeeDepartmentHistory { get; set; } // EmployeeDepartmentHistory
        public IDbSet<EmployeePayHistory> HumanResources_EmployeePayHistory { get; set; } // EmployeePayHistory
        public IDbSet<JobCandidate> HumanResources_JobCandidate { get; set; } // JobCandidate
        public IDbSet<Shift> HumanResources_Shift { get; set; } // Shift
        public IDbSet<Person_Address> Person_Address { get; set; } // Address
        public IDbSet<Person_AddressType> Person_AddressType { get; set; } // AddressType
        public IDbSet<Person_Contact> Person_Contact { get; set; } // Contact
        public IDbSet<Person_ContactType> Person_ContactType { get; set; } // ContactType
        public IDbSet<Person_CountryRegion> Person_CountryRegion { get; set; } // CountryRegion
        public IDbSet<Person_StateProvince> Person_StateProvince { get; set; } // StateProvince
        public IDbSet<Production_BillOfMaterials> Production_BillOfMaterials { get; set; } // BillOfMaterials
        public IDbSet<Production_Culture> Production_Culture { get; set; } // Culture
        public IDbSet<Production_Document> Production_Document { get; set; } // Document
        public IDbSet<Production_Illustration> Production_Illustration { get; set; } // Illustration
        public IDbSet<Production_Location> Production_Location { get; set; } // Location
        public IDbSet<Production_Product> Production_Product { get; set; } // Product
        public IDbSet<Production_ProductCategory> Production_ProductCategory { get; set; } // ProductCategory
        public IDbSet<Production_ProductCostHistory> Production_ProductCostHistory { get; set; } // ProductCostHistory
        public IDbSet<Production_ProductDescription> Production_ProductDescription { get; set; } // ProductDescription
        public IDbSet<Production_ProductDocument> Production_ProductDocument { get; set; } // ProductDocument
        public IDbSet<Production_ProductInventory> Production_ProductInventory { get; set; } // ProductInventory
        public IDbSet<Production_ProductListPriceHistory> Production_ProductListPriceHistory { get; set; } // ProductListPriceHistory
        public IDbSet<Production_ProductModel> Production_ProductModel { get; set; } // ProductModel
        public IDbSet<Production_ProductModelIllustration> Production_ProductModelIllustration { get; set; } // ProductModelIllustration
        public IDbSet<Production_ProductModelProductDescriptionCulture> Production_ProductModelProductDescriptionCulture { get; set; } // ProductModelProductDescriptionCulture
        public IDbSet<Production_ProductPhoto> Production_ProductPhoto { get; set; } // ProductPhoto
        public IDbSet<Production_ProductProductPhoto> Production_ProductProductPhoto { get; set; } // ProductProductPhoto
        public IDbSet<Production_ProductReview> Production_ProductReview { get; set; } // ProductReview
        public IDbSet<Production_ProductSubcategory> Production_ProductSubcategory { get; set; } // ProductSubcategory
        public IDbSet<Production_ScrapReason> Production_ScrapReason { get; set; } // ScrapReason
        public IDbSet<Production_TransactionHistory> Production_TransactionHistory { get; set; } // TransactionHistory
        public IDbSet<Production_TransactionHistoryArchive> Production_TransactionHistoryArchive { get; set; } // TransactionHistoryArchive
        public IDbSet<Production_UnitMeasure> Production_UnitMeasure { get; set; } // UnitMeasure
        public IDbSet<Production_WorkOrder> Production_WorkOrder { get; set; } // WorkOrder
        public IDbSet<Production_WorkOrderRouting> Production_WorkOrderRouting { get; set; } // WorkOrderRouting
        public IDbSet<Purchasing_ProductVendor> Purchasing_ProductVendor { get; set; } // ProductVendor
        public IDbSet<Purchasing_PurchaseOrderDetail> Purchasing_PurchaseOrderDetail { get; set; } // PurchaseOrderDetail
        public IDbSet<Purchasing_PurchaseOrderHeader> Purchasing_PurchaseOrderHeader { get; set; } // PurchaseOrderHeader
        public IDbSet<Purchasing_ShipMethod> Purchasing_ShipMethod { get; set; } // ShipMethod
        public IDbSet<Purchasing_Vendor> Purchasing_Vendor { get; set; } // Vendor
        public IDbSet<Purchasing_VendorAddress> Purchasing_VendorAddress { get; set; } // VendorAddress
        public IDbSet<Purchasing_VendorContact> Purchasing_VendorContact { get; set; } // VendorContact
        public IDbSet<Sales_ContactCreditCard> Sales_ContactCreditCard { get; set; } // ContactCreditCard
        public IDbSet<Sales_CountryRegionCurrency> Sales_CountryRegionCurrency { get; set; } // CountryRegionCurrency
        public IDbSet<Sales_CreditCard> Sales_CreditCard { get; set; } // CreditCard
        public IDbSet<Sales_Currency> Sales_Currency { get; set; } // Currency
        public IDbSet<Sales_CurrencyRate> Sales_CurrencyRate { get; set; } // CurrencyRate
        public IDbSet<Sales_Customer> Sales_Customer { get; set; } // Customer
        public IDbSet<Sales_CustomerAddress> Sales_CustomerAddress { get; set; } // CustomerAddress
        public IDbSet<Sales_Individual> Sales_Individual { get; set; } // Individual
        public IDbSet<Sales_SalesOrderDetail> Sales_SalesOrderDetail { get; set; } // SalesOrderDetail
        public IDbSet<Sales_SalesOrderHeader> Sales_SalesOrderHeader { get; set; } // SalesOrderHeader
        public IDbSet<Sales_SalesOrderHeaderSalesReason> Sales_SalesOrderHeaderSalesReason { get; set; } // SalesOrderHeaderSalesReason
        public IDbSet<Sales_SalesPerson> Sales_SalesPerson { get; set; } // SalesPerson
        public IDbSet<Sales_SalesPersonQuotaHistory> Sales_SalesPersonQuotaHistory { get; set; } // SalesPersonQuotaHistory
        public IDbSet<Sales_SalesReason> Sales_SalesReason { get; set; } // SalesReason
        public IDbSet<Sales_SalesTaxRate> Sales_SalesTaxRate { get; set; } // SalesTaxRate
        public IDbSet<Sales_SalesTerritory> Sales_SalesTerritory { get; set; } // SalesTerritory
        public IDbSet<Sales_SalesTerritoryHistory> Sales_SalesTerritoryHistory { get; set; } // SalesTerritoryHistory
        public IDbSet<Sales_ShoppingCartItem> Sales_ShoppingCartItem { get; set; } // ShoppingCartItem
        public IDbSet<Sales_SpecialOffer> Sales_SpecialOffer { get; set; } // SpecialOffer
        public IDbSet<Sales_SpecialOfferProduct> Sales_SpecialOfferProduct { get; set; } // SpecialOfferProduct
        public IDbSet<Sales_Store> Sales_Store { get; set; } // Store
        public IDbSet<Sales_StoreContact> Sales_StoreContact { get; set; } // StoreContact
        public IDbSet<Sales_WebSiteHits> Sales_WebSiteHits { get; set; } // WebSiteHits

        static AdventureWorksContext()
        {
            Database.SetInitializer<AdventureWorksContext>(null);
        }

        public AdventureWorksContext()
            : base("Name=AdventureWorks")
        {
        }

        public AdventureWorksContext(string connectionString) : base(connectionString)
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Configurations.Add(new AwBuildVersionConfiguration());
            modelBuilder.Configurations.Add(new DatabaseLogConfiguration());
            modelBuilder.Configurations.Add(new ErrorLogConfiguration());
            modelBuilder.Configurations.Add(new DepartmentConfiguration());
            modelBuilder.Configurations.Add(new EmployeeConfiguration());
            modelBuilder.Configurations.Add(new EmployeeAddressConfiguration());
            modelBuilder.Configurations.Add(new EmployeeDepartmentHistoryConfiguration());
            modelBuilder.Configurations.Add(new EmployeePayHistoryConfiguration());
            modelBuilder.Configurations.Add(new JobCandidateConfiguration());
            modelBuilder.Configurations.Add(new ShiftConfiguration());
            modelBuilder.Configurations.Add(new Person_AddressConfiguration());
            modelBuilder.Configurations.Add(new Person_AddressTypeConfiguration());
            modelBuilder.Configurations.Add(new Person_ContactConfiguration());
            modelBuilder.Configurations.Add(new Person_ContactTypeConfiguration());
            modelBuilder.Configurations.Add(new Person_CountryRegionConfiguration());
            modelBuilder.Configurations.Add(new Person_StateProvinceConfiguration());
            modelBuilder.Configurations.Add(new Production_BillOfMaterialsConfiguration());
            modelBuilder.Configurations.Add(new Production_CultureConfiguration());
            modelBuilder.Configurations.Add(new Production_DocumentConfiguration());
            modelBuilder.Configurations.Add(new Production_IllustrationConfiguration());
            modelBuilder.Configurations.Add(new Production_LocationConfiguration());
            modelBuilder.Configurations.Add(new Production_ProductConfiguration());
            modelBuilder.Configurations.Add(new Production_ProductCategoryConfiguration());
            modelBuilder.Configurations.Add(new Production_ProductCostHistoryConfiguration());
            modelBuilder.Configurations.Add(new Production_ProductDescriptionConfiguration());
            modelBuilder.Configurations.Add(new Production_ProductDocumentConfiguration());
            modelBuilder.Configurations.Add(new Production_ProductInventoryConfiguration());
            modelBuilder.Configurations.Add(new Production_ProductListPriceHistoryConfiguration());
            modelBuilder.Configurations.Add(new Production_ProductModelConfiguration());
            modelBuilder.Configurations.Add(new Production_ProductModelIllustrationConfiguration());
            modelBuilder.Configurations.Add(new Production_ProductModelProductDescriptionCultureConfiguration());
            modelBuilder.Configurations.Add(new Production_ProductPhotoConfiguration());
            modelBuilder.Configurations.Add(new Production_ProductProductPhotoConfiguration());
            modelBuilder.Configurations.Add(new Production_ProductReviewConfiguration());
            modelBuilder.Configurations.Add(new Production_ProductSubcategoryConfiguration());
            modelBuilder.Configurations.Add(new Production_ScrapReasonConfiguration());
            modelBuilder.Configurations.Add(new Production_TransactionHistoryConfiguration());
            modelBuilder.Configurations.Add(new Production_TransactionHistoryArchiveConfiguration());
            modelBuilder.Configurations.Add(new Production_UnitMeasureConfiguration());
            modelBuilder.Configurations.Add(new Production_WorkOrderConfiguration());
            modelBuilder.Configurations.Add(new Production_WorkOrderRoutingConfiguration());
            modelBuilder.Configurations.Add(new Purchasing_ProductVendorConfiguration());
            modelBuilder.Configurations.Add(new Purchasing_PurchaseOrderDetailConfiguration());
            modelBuilder.Configurations.Add(new Purchasing_PurchaseOrderHeaderConfiguration());
            modelBuilder.Configurations.Add(new Purchasing_ShipMethodConfiguration());
            modelBuilder.Configurations.Add(new Purchasing_VendorConfiguration());
            modelBuilder.Configurations.Add(new Purchasing_VendorAddressConfiguration());
            modelBuilder.Configurations.Add(new Purchasing_VendorContactConfiguration());
            modelBuilder.Configurations.Add(new Sales_ContactCreditCardConfiguration());
            modelBuilder.Configurations.Add(new Sales_CountryRegionCurrencyConfiguration());
            modelBuilder.Configurations.Add(new Sales_CreditCardConfiguration());
            modelBuilder.Configurations.Add(new Sales_CurrencyConfiguration());
            modelBuilder.Configurations.Add(new Sales_CurrencyRateConfiguration());
            modelBuilder.Configurations.Add(new Sales_CustomerConfiguration());
            modelBuilder.Configurations.Add(new Sales_CustomerAddressConfiguration());
            modelBuilder.Configurations.Add(new Sales_IndividualConfiguration());
            modelBuilder.Configurations.Add(new Sales_SalesOrderDetailConfiguration());
            modelBuilder.Configurations.Add(new Sales_SalesOrderHeaderConfiguration());
            modelBuilder.Configurations.Add(new Sales_SalesOrderHeaderSalesReasonConfiguration());
            modelBuilder.Configurations.Add(new Sales_SalesPersonConfiguration());
            modelBuilder.Configurations.Add(new Sales_SalesPersonQuotaHistoryConfiguration());
            modelBuilder.Configurations.Add(new Sales_SalesReasonConfiguration());
            modelBuilder.Configurations.Add(new Sales_SalesTaxRateConfiguration());
            modelBuilder.Configurations.Add(new Sales_SalesTerritoryConfiguration());
            modelBuilder.Configurations.Add(new Sales_SalesTerritoryHistoryConfiguration());
            modelBuilder.Configurations.Add(new Sales_ShoppingCartItemConfiguration());
            modelBuilder.Configurations.Add(new Sales_SpecialOfferConfiguration());
            modelBuilder.Configurations.Add(new Sales_SpecialOfferProductConfiguration());
            modelBuilder.Configurations.Add(new Sales_StoreConfiguration());
            modelBuilder.Configurations.Add(new Sales_StoreContactConfiguration());
            modelBuilder.Configurations.Add(new Sales_WebSiteHitsConfiguration());
        }
    }
}