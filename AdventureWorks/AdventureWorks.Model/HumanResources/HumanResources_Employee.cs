using System;
using System.Collections.Generic;
using AdventureWorks.Model.Person;
using AdventureWorks.Model.Purchasing;
using AdventureWorks.Model.Sales;

namespace AdventureWorks.Model.HumanResources
{
    public class HumanResources_Employee
    {
        public int EmployeeId { get; set; } // EmployeeID (Primary key)
        public string NationalIdNumber { get; set; } // NationalIDNumber
        public int ContactId { get; set; } // ContactID
        public string LoginId { get; set; } // LoginID
        public int? ManagerId { get; set; } // ManagerID
        public string Title { get; set; } // Title
        public DateTime BirthDate { get; set; } // BirthDate
        public string MaritalStatus { get; set; } // MaritalStatus
        public string Gender { get; set; } // Gender
        public DateTime HireDate { get; set; } // HireDate
        public bool SalariedFlag { get; set; } // SalariedFlag
        public short VacationHours { get; set; } // VacationHours
        public short SickLeaveHours { get; set; } // SickLeaveHours
        public bool CurrentFlag { get; set; } // CurrentFlag
        public Guid Rowguid { get; set; } // rowguid
        public DateTime ModifiedDate { get; set; } // ModifiedDate

        // Reverse navigation
        public virtual ICollection<HumanResources_Employee> HumanResources_Employee2 { get; set; } // Employee.FK_Employee_Employee_ManagerID;
        public virtual ICollection<HumanResources_EmployeeAddress> HumanResources_EmployeeAddress { get; set; } // EmployeeAddress.FK_EmployeeAddress_Employee_EmployeeID;
        public virtual ICollection<HumanResources_EmployeeDepartmentHistory> HumanResources_EmployeeDepartmentHistory { get; set; } // EmployeeDepartmentHistory.FK_EmployeeDepartmentHistory_Employee_EmployeeID;
        public virtual ICollection<HumanResources_EmployeePayHistory> HumanResources_EmployeePayHistory { get; set; } // EmployeePayHistory.FK_EmployeePayHistory_Employee_EmployeeID;
        public virtual ICollection<HumanResources_JobCandidate> HumanResources_JobCandidate { get; set; } // JobCandidate.FK_JobCandidate_Employee_EmployeeID;
        public virtual ICollection<Purchasing_PurchaseOrderHeader> Purchasing_PurchaseOrderHeader { get; set; } // PurchaseOrderHeader.FK_PurchaseOrderHeader_Employee_EmployeeID;
        public virtual Sales_SalesPerson Sales_SalesPerson { get; set; } // SalesPerson.FK_SalesPerson_Employee_SalesPersonID;

        // Foreign keys
        public virtual Person_Contact Person_Contact { get; set; } //  ContactId - FK_Employee_Contact_ContactID
        public virtual HumanResources_Employee HumanResources_Employee1 { get; set; } //  ManagerId - FK_Employee_Employee_ManagerID

        public HumanResources_Employee()
        {
            SalariedFlag = true;
            VacationHours = 0;
            SickLeaveHours = 0;
            CurrentFlag = true;
            Rowguid = Guid.NewGuid();
            ModifiedDate = DateTime.Now;
            HumanResources_Employee2 = new List<HumanResources_Employee>();
            HumanResources_EmployeeAddress = new List<HumanResources_EmployeeAddress>();
            HumanResources_EmployeeDepartmentHistory = new List<HumanResources_EmployeeDepartmentHistory>();
            HumanResources_EmployeePayHistory = new List<HumanResources_EmployeePayHistory>();
            HumanResources_JobCandidate = new List<HumanResources_JobCandidate>();
            Purchasing_PurchaseOrderHeader = new List<Purchasing_PurchaseOrderHeader>();
        }
    }
}