using System;
using AdventureWorks.Model.Person;

namespace AdventureWorks.Model.HumanResources
{
    public class HumanResources_EmployeeAddress
    {
        public int EmployeeId { get; set; } // EmployeeID (Primary key)
        public int AddressId { get; set; } // AddressID (Primary key)
        public Guid Rowguid { get; set; } // rowguid
        public DateTime ModifiedDate { get; set; } // ModifiedDate

        // Foreign keys
        public virtual HumanResources_Employee HumanResources_Employee { get; set; } //  EmployeeId - FK_EmployeeAddress_Employee_EmployeeID
        public virtual Person_Address Person_Address { get; set; } //  AddressId - FK_EmployeeAddress_Address_AddressID

        public HumanResources_EmployeeAddress()
        {
            Rowguid = Guid.NewGuid();
            ModifiedDate = DateTime.Now;
        }
    }
}