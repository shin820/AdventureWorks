using System;
using System.Collections.Generic;
using AdventureWorks.Model.HumanResources;
using AdventureWorks.Model.Purchasing;
using AdventureWorks.Model.Sales;

namespace AdventureWorks.Model.Person
{
    public class Person_Contact
    {
        public int ContactId { get; set; } // ContactID (Primary key)
        public bool NameStyle { get; set; } // NameStyle
        public string Title { get; set; } // Title
        public string FirstName { get; set; } // FirstName
        public string MiddleName { get; set; } // MiddleName
        public string LastName { get; set; } // LastName
        public string Suffix { get; set; } // Suffix
        public string EmailAddress { get; set; } // EmailAddress
        public int EmailPromotion { get; set; } // EmailPromotion
        public string Phone { get; set; } // Phone
        public string PasswordHash { get; set; } // PasswordHash
        public string PasswordSalt { get; set; } // PasswordSalt
        public string AdditionalContactInfo { get; set; } // AdditionalContactInfo
        public Guid Rowguid { get; set; } // rowguid
        public DateTime ModifiedDate { get; set; } // ModifiedDate

        // Reverse navigation
        public virtual ICollection<Sales_ContactCreditCard> Sales_ContactCreditCard { get; set; } // ContactCreditCard.FK_ContactCreditCard_Contact_ContactID;
        public virtual ICollection<HumanResources_Employee> HumanResources_Employee { get; set; } // Employee.FK_Employee_Contact_ContactID;
        public virtual ICollection<Sales_Individual> Sales_Individual { get; set; } // Individual.FK_Individual_Contact_ContactID;
        public virtual ICollection<Sales_SalesOrderHeader> Sales_SalesOrderHeader { get; set; } // SalesOrderHeader.FK_SalesOrderHeader_Contact_ContactID;
        public virtual ICollection<Sales_StoreContact> Sales_StoreContact { get; set; } // StoreContact.FK_StoreContact_Contact_ContactID;
        public virtual ICollection<Purchasing_VendorContact> Purchasing_VendorContact { get; set; } // VendorContact.FK_VendorContact_Contact_ContactID;

        public Person_Contact()
        {
            NameStyle = false;
            EmailPromotion = 0;
            Rowguid = Guid.NewGuid();
            ModifiedDate = DateTime.Now;
            Sales_ContactCreditCard = new List<Sales_ContactCreditCard>();
            HumanResources_Employee = new List<HumanResources_Employee>();
            Sales_Individual = new List<Sales_Individual>();
            Sales_SalesOrderHeader = new List<Sales_SalesOrderHeader>();
            Sales_StoreContact = new List<Sales_StoreContact>();
            Purchasing_VendorContact = new List<Purchasing_VendorContact>();
        }
    }
}