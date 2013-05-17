using System;
using AdventureWorks.Model.Production;

namespace AdventureWorks.Model.Sales
{
    public class Sales_ShoppingCartItem
    {
        public int ShoppingCartItemId { get; set; } // ShoppingCartItemID (Primary key)
        public string ShoppingCartId { get; set; } // ShoppingCartID
        public int Quantity { get; set; } // Quantity
        public int ProductId { get; set; } // ProductID
        public DateTime DateCreated { get; set; } // DateCreated
        public DateTime ModifiedDate { get; set; } // ModifiedDate

        // Foreign keys
        public virtual Production_Product Production_Product { get; set; } //  ProductId - FK_ShoppingCartItem_Product_ProductID

        public Sales_ShoppingCartItem()
        {
            Quantity = 1;
            DateCreated = DateTime.Now;
            ModifiedDate = DateTime.Now;
        }
    }
}