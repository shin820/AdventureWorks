using System;
using System.Collections.Generic;
using AdventureWorks.Model.Person;
using AdventureWorks.Model.Purchasing;
using AdventureWorks.Model.Sales;

namespace AdventureWorks.Model.HumanResources
{
    public class Employee : ObjectWithState
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
        public ICollection<Employee> Subordinates { get; set; } // Employee.FK_Employee_Employee_ManagerID;
        public ICollection<EmployeeAddress> EmployeeAddresses { get; set; } // EmployeeAddress.FK_EmployeeAddress_Employee_EmployeeID;
        public ICollection<EmployeeDepartmentHistory> EmployeeDepartmentHistories { get; set; } // EmployeeDepartmentHistory.FK_EmployeeDepartmentHistory_Employee_EmployeeID;
        public ICollection<EmployeePayHistory> EmployeePayHistories { get; set; } // EmployeePayHistory.FK_EmployeePayHistory_Employee_EmployeeID;
        public ICollection<JobCandidate> JobCandidates { get; set; } // JobCandidate.FK_JobCandidate_Employee_EmployeeID;
        public ICollection<Purchasing_PurchaseOrderHeader> Purchasing_PurchaseOrderHeader { get; set; } // PurchaseOrderHeader.FK_PurchaseOrderHeader_Employee_EmployeeID;
        public Sales_SalesPerson Sales_SalesPerson { get; set; } // SalesPerson.FK_SalesPerson_Employee_SalesPersonID;

        // Foreign keys
        public Person_Contact Contact { get; set; } //  ContactId - FK_Employee_Contact_ContactID
        public Employee Manager { get; set; } //  ManagerId - FK_Employee_Employee_ManagerID

        public Employee()
        {
            SalariedFlag = true;
            VacationHours = 0;
            SickLeaveHours = 0;
            CurrentFlag = true;
            Rowguid = Guid.NewGuid();
            ModifiedDate = DateTime.Now;
            Subordinates = new List<Employee>();
            EmployeeAddresses = new List<EmployeeAddress>();
            EmployeeDepartmentHistories = new List<EmployeeDepartmentHistory>();
            EmployeePayHistories = new List<EmployeePayHistory>();
            JobCandidates = new List<JobCandidate>();
            Purchasing_PurchaseOrderHeader = new List<Purchasing_PurchaseOrderHeader>();
        }
    }
}