using System;
using global::Jerrycurl.Data.Metadata.Annotations;
using global::Jerrycurl.Mvc.Metadata.Annotations;

namespace JC.MVC.Database
{
    [Table("Sales", "CreditCard")]
    public class CreditCard
    {
        [Id, Key("PK_CreditCard_CreditCardID", 1)]
        public int CreditCardID { get; set; }
        public string CardType { get; set; }
        public string CardNumber { get; set; }
        public byte ExpMonth { get; set; }
        public short ExpYear { get; set; }
        public DateTime ModifiedDate { get; set; }
    }

    [Table("Sales", "Customer")]
    public class Customer
    {
        [Id, Key("PK_Customer_CustomerID", 1)]
        public int CustomerID { get; set; }
        [Ref("PK_Person_BusinessEntityID", 1, "FK_Customer_Person_PersonID")]
        public int? PersonID { get; set; }
        [Ref("PK_Store_BusinessEntityID", 1, "FK_Customer_Store_StoreID")]
        public int? StoreID { get; set; }
        [Ref("PK_SalesTerritory_TerritoryID", 1, "FK_Customer_SalesTerritory_TerritoryID")]
        public int? TerritoryID { get; set; }
        public string AccountNumber { get; set; }
        public Guid rowguid { get; set; }
        public DateTime ModifiedDate { get; set; }
    }


    [Table("Sales", "SalesOrderHeader")]
    public class SalesOrderHeader
    {
        [Id, Key("PK_SalesOrderHeader_SalesOrderID", 1)]
        public int SalesOrderID { get; set; }
        public byte RevisionNumber { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime DueDate { get; set; }
        public DateTime? ShipDate { get; set; }
        public byte Status { get; set; }
        public bool OnlineOrderFlag { get; set; }
        public string SalesOrderNumber { get; set; }
        public string PurchaseOrderNumber { get; set; }
        public string AccountNumber { get; set; }
        [Ref("PK_Customer_CustomerID", 1, "FK_SalesOrderHeader_Customer_CustomerID")]
        public int CustomerID { get; set; }
        [Ref("PK_SalesPerson_BusinessEntityID", 1, "FK_SalesOrderHeader_SalesPerson_SalesPersonID")]
        public int? SalesPersonID { get; set; }
        [Ref("PK_SalesTerritory_TerritoryID", 1, "FK_SalesOrderHeader_SalesTerritory_TerritoryID")]
        public int? TerritoryID { get; set; }
        [Ref("PK_Address_AddressID", 1, "FK_SalesOrderHeader_Address_BillToAddressID")]
        public int BillToAddressID { get; set; }
        [Ref("PK_Address_AddressID", 1, "FK_SalesOrderHeader_Address_ShipToAddressID")]
        public int ShipToAddressID { get; set; }
        [Ref("PK_ShipMethod_ShipMethodID", 1, "FK_SalesOrderHeader_ShipMethod_ShipMethodID")]
        public int ShipMethodID { get; set; }
        [Ref("PK_CreditCard_CreditCardID", 1, "FK_SalesOrderHeader_CreditCard_CreditCardID")]
        public int? CreditCardID { get; set; }
        public string CreditCardApprovalCode { get; set; }
        [Ref("PK_CurrencyRate_CurrencyRateID", 1, "FK_SalesOrderHeader_CurrencyRate_CurrencyRateID")]
        public int? CurrencyRateID { get; set; }
        public decimal SubTotal { get; set; }
        public decimal TaxAmt { get; set; }
        public decimal Freight { get; set; }
        public decimal TotalDue { get; set; }
        public string Comment { get; set; }
        public Guid rowguid { get; set; }
        public DateTime ModifiedDate { get; set; }
    }

    [Table("Sales", "SalesOrderDetail")]
    public class SalesOrderDetail
    {
        [Key("PK_SalesOrderDetail_SalesOrderID_SalesOrderDetailID", 1), Ref("PK_SalesOrderHeader_SalesOrderID", 1, "FK_SalesOrderDetail_SalesOrderHeader_SalesOrderID")]
        public int SalesOrderID { get; set; }
        [Id, Key("PK_SalesOrderDetail_SalesOrderID_SalesOrderDetailID", 2)]
        public int SalesOrderDetailID { get; set; }
        public string CarrierTrackingNumber { get; set; }
        public short OrderQty { get; set; }
        [Ref("PK_SpecialOfferProduct_SpecialOfferID_ProductID", 2, "FK_SalesOrderDetail_SpecialOfferProduct_SpecialOfferIDProductID")]
        public int ProductID { get; set; }
        [Ref("PK_SpecialOfferProduct_SpecialOfferID_ProductID", 1, "FK_SalesOrderDetail_SpecialOfferProduct_SpecialOfferIDProductID")]
        public int SpecialOfferID { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal UnitPriceDiscount { get; set; }
        public decimal LineTotal { get; set; }
        public Guid rowguid { get; set; }
        public DateTime ModifiedDate { get; set; }
    }
}