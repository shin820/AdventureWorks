using System;
using System.Collections.Generic;
using AdventureWorks.Model.Purchasing;
using AdventureWorks.Model.Sales;

namespace AdventureWorks.Model.Production
{
    public class Production_Product
    {
        public int ProductId { get; set; } // ProductID (Primary key)
        public string Name { get; set; } // Name
        public string ProductNumber { get; set; } // ProductNumber
        public bool MakeFlag { get; set; } // MakeFlag
        public bool FinishedGoodsFlag { get; set; } // FinishedGoodsFlag
        public string Color { get; set; } // Color
        public short SafetyStockLevel { get; set; } // SafetyStockLevel
        public short ReorderPoint { get; set; } // ReorderPoint
        public decimal StandardCost { get; set; } // StandardCost
        public decimal ListPrice { get; set; } // ListPrice
        public string Size { get; set; } // Size
        public string SizeUnitMeasureCode { get; set; } // SizeUnitMeasureCode
        public string WeightUnitMeasureCode { get; set; } // WeightUnitMeasureCode
        public decimal? Weight { get; set; } // Weight
        public int DaysToManufacture { get; set; } // DaysToManufacture
        public string ProductLine { get; set; } // ProductLine
        public string Class { get; set; } // Class
        public string Style { get; set; } // Style
        public int? ProductSubcategoryId { get; set; } // ProductSubcategoryID
        public int? ProductModelId { get; set; } // ProductModelID
        public DateTime SellStartDate { get; set; } // SellStartDate
        public DateTime? SellEndDate { get; set; } // SellEndDate
        public DateTime? DiscontinuedDate { get; set; } // DiscontinuedDate
        public Guid Rowguid { get; set; } // rowguid
        public DateTime ModifiedDate { get; set; } // ModifiedDate

        // Reverse navigation
        public virtual ICollection<Production_BillOfMaterials> Production_BillOfMaterials { get; set; } // BillOfMaterials.FK_BillOfMaterials_Product_ComponentID;
        public virtual ICollection<Production_BillOfMaterials> Production_BillOfMaterials1 { get; set; } // BillOfMaterials.FK_BillOfMaterials_Product_ProductAssemblyID;
        public virtual ICollection<Production_ProductCostHistory> Production_ProductCostHistory { get; set; } // ProductCostHistory.FK_ProductCostHistory_Product_ProductID;
        public virtual ICollection<Production_ProductDocument> Production_ProductDocument { get; set; } // ProductDocument.FK_ProductDocument_Product_ProductID;
        public virtual ICollection<Production_ProductInventory> Production_ProductInventory { get; set; } // ProductInventory.FK_ProductInventory_Product_ProductID;
        public virtual ICollection<Production_ProductListPriceHistory> Production_ProductListPriceHistory { get; set; } // ProductListPriceHistory.FK_ProductListPriceHistory_Product_ProductID;
        public virtual ICollection<Production_ProductProductPhoto> Production_ProductProductPhoto { get; set; } // ProductProductPhoto.FK_ProductProductPhoto_Product_ProductID;
        public virtual ICollection<Production_ProductReview> Production_ProductReview { get; set; } // ProductReview.FK_ProductReview_Product_ProductID;
        public virtual ICollection<Purchasing_ProductVendor> Purchasing_ProductVendor { get; set; } // ProductVendor.FK_ProductVendor_Product_ProductID;
        public virtual ICollection<Purchasing_PurchaseOrderDetail> Purchasing_PurchaseOrderDetail { get; set; } // PurchaseOrderDetail.FK_PurchaseOrderDetail_Product_ProductID;
        public virtual ICollection<Sales_ShoppingCartItem> Sales_ShoppingCartItem { get; set; } // ShoppingCartItem.FK_ShoppingCartItem_Product_ProductID;
        public virtual ICollection<Sales_SpecialOfferProduct> Sales_SpecialOfferProduct { get; set; } // SpecialOfferProduct.FK_SpecialOfferProduct_Product_ProductID;
        public virtual ICollection<Production_TransactionHistory> Production_TransactionHistory { get; set; } // TransactionHistory.FK_TransactionHistory_Product_ProductID;
        public virtual ICollection<Production_WorkOrder> Production_WorkOrder { get; set; } // WorkOrder.FK_WorkOrder_Product_ProductID;

        // Foreign keys
        public virtual Production_UnitMeasure Production_UnitMeasure { get; set; } //  SizeUnitMeasureCode - FK_Product_UnitMeasure_SizeUnitMeasureCode
        public virtual Production_UnitMeasure Production_UnitMeasure1 { get; set; } //  WeightUnitMeasureCode - FK_Product_UnitMeasure_WeightUnitMeasureCode
        public virtual Production_ProductSubcategory Production_ProductSubcategory { get; set; } //  ProductSubcategoryId - FK_Product_ProductSubcategory_ProductSubcategoryID
        public virtual Production_ProductModel Production_ProductModel { get; set; } //  ProductModelId - FK_Product_ProductModel_ProductModelID

        public Production_Product()
        {
            MakeFlag = true;
            FinishedGoodsFlag = true;
            Rowguid = Guid.NewGuid();
            ModifiedDate = DateTime.Now;
            Production_BillOfMaterials = new List<Production_BillOfMaterials>();
            Production_BillOfMaterials1 = new List<Production_BillOfMaterials>();
            Production_ProductCostHistory = new List<Production_ProductCostHistory>();
            Production_ProductDocument = new List<Production_ProductDocument>();
            Production_ProductInventory = new List<Production_ProductInventory>();
            Production_ProductListPriceHistory = new List<Production_ProductListPriceHistory>();
            Production_ProductProductPhoto = new List<Production_ProductProductPhoto>();
            Production_ProductReview = new List<Production_ProductReview>();
            Purchasing_ProductVendor = new List<Purchasing_ProductVendor>();
            Purchasing_PurchaseOrderDetail = new List<Purchasing_PurchaseOrderDetail>();
            Sales_ShoppingCartItem = new List<Sales_ShoppingCartItem>();
            Sales_SpecialOfferProduct = new List<Sales_SpecialOfferProduct>();
            Production_TransactionHistory = new List<Production_TransactionHistory>();
            Production_WorkOrder = new List<Production_WorkOrder>();
        }
    }
}