using System;
using AdventureWorks.Model.Person;

namespace AdventureWorks.Model.Sales
{
    public class Sales_SalesTaxRate
    {
        public int SalesTaxRateId { get; set; } // SalesTaxRateID (Primary key)
        public int StateProvinceId { get; set; } // StateProvinceID
        public byte TaxType { get; set; } // TaxType
        public decimal TaxRate { get; set; } // TaxRate
        public string Name { get; set; } // Name
        public Guid Rowguid { get; set; } // rowguid
        public DateTime ModifiedDate { get; set; } // ModifiedDate

        // Foreign keys
        public virtual Person_StateProvince Person_StateProvince { get; set; } //  StateProvinceId - FK_SalesTaxRate_StateProvince_StateProvinceID

        public Sales_SalesTaxRate()
        {
            TaxRate = 0.00m;
            Rowguid = Guid.NewGuid();
            ModifiedDate = DateTime.Now;
        }
    }
}