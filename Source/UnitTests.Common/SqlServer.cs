using System;

namespace UnitTests.Common
{
    public abstract class SqlServer
    {
        #region Field Members
        protected static readonly string _sql = @"
        select
	        soh.AccountNumber as sohAccountNumber,
	        soh.BillToAddressID as sohBillToAddressID,
	        soh.Comment as sohComment,
	        soh.CreditCardApprovalCode as sohCreditCardApprovalCode,
	        soh.CustomerID as sohCustomerID,
	        soh.DueDate as sohDueDate,
	        soh.Freight as sohFreight,
	        soh.ModifiedDate as sohModifiedDate,
	        soh.OnlineOrderFlag as sohOnlineOrderFlag,
	        soh.OrderDate as sohOrderDate,
	        soh.PurchaseOrderNumber as sohPurchaseOrderNumber,
	        soh.RevisionNumber as sohRevisionNumber,
	        soh.rowguid as sohRowGuid,
	        soh.SalesOrderID as sohSalesOrderID,
	        soh.SalesOrderNumber as sohSalesOrderNumber,
	        soh.ShipDate as sohShipDate,
	        soh.ShipMethod as sohShipMethod,
	        soh.ShipToAddressID as sohShipToAddressID,
	        soh.Status as sohStatus,
	        soh.SubTotal as sohSubTotal,
	        soh.TaxAmt as sohTaxAmt,
	        soh.TotalDue as sohTotalDue,
	        sod.LineTotal as sodLineTotal,
	        sod.ModifiedDate as sodModifiedDate,
	        sod.OrderQty as sodOrderQty,
	        sod.ProductID as sodProductID,
	        sod.rowguid as sodRowGuid,
	        sod.SalesOrderDetailID as sodSalesOrderDetailID,
	        sod.SalesOrderID as sodSalesOrderID,
	        sod.UnitPrice as sodUnitPrice,
	        sod.UnitPriceDiscount as sodUnitPriceDiscount,

	        shipTo.AddressID as shipToAddressID,
	        shipTo.AddressLine1 as shipToAddressLine1,
            shipTo.AddressLine2 as shipToAddressLine2,
	        shipTo.City as shipToCity,
	        shipTo.CountryRegion as shipToCountryRegion,
	        shipTo.ModifiedDate as shipToModifiedDate,
	        shipTo.PostalCode as shipToPostalCode,
	        shipTo.rowguid as shipToRowGuid,
	        shipTo.StateProvince as shipToStateProvince,

	        billTo.AddressID as billToAddressID,
	        billTo.AddressLine1 as billToAddressLine1,
            billTo.AddressLine2 as billToAddressLine2,
	        billTo.City as billToCity,
	        billTo.CountryRegion as billToCountryRegion,
	        billTo.ModifiedDate as billToModifiedDate,
	        billTo.PostalCode as billToPostalCode,
	        billTo.rowguid as billToRowGuid,
	        billTo.StateProvince as billToStateProvince,

	        cus.CompanyName as cusCompanyName,
	        cus.CustomerID as cusCustomerID,
	        cus.EmailAddress as cusEmailAddress,
	        cus.FirstName as cusFirstName,
	        cus.LastName as cusLastName,
	        cus.MiddleName as cusMiddleName,
	        cus.ModifiedDate as cusModifiedDate,
	        cus.NameStyle as cusNameStyle,
	        cus.PasswordHash as cusPasswordHash,
	        cus.PasswordSalt as cusPasswordSalt,
	        cus.Phone as cusPhone,
	        cus.rowguid as cusRowGuid,
	        cus.SalesPerson as cusSalesPerson,
	        cus.Suffix as cusSuffix,
	        cus.Title as cusTitle,

	        pro.Color as proColor,
	        pro.DiscontinuedDate as proDiscontinuedDate,
	        pro.ListPrice as proListPrice,
	        pro.ModifiedDate as proModifiedDate,
	        pro.Name as proName,
	        pro.ProductCategoryID as proProductCategoryID,
	        pro.ProductID as proProductID,
	        pro.ProductModelID as proProductModelID,
	        pro.ProductNumber as proProductNumber,
	        pro.rowguid as proRowGuid,
	        pro.SellEndDate as proSellEndDate,
	        pro.SellStartDate as proSellStartDate,
	        pro.Size as proSize,
	        pro.StandardCost as proStandardCost,
	        pro.ThumbNailPhoto as proThumbNailPhoto,
	        pro.ThumbnailPhotoFileName as proThumbnailPhotoFileName,
	        pro.Weight as proWeight,

	        pm.CatalogDescription as pmCatalogDescription,
	        pm.ModifiedDate as pmModifiedDate,
	        pm.Name as pmName,
	        pm.ProductModelID as pmProductModelID,
	        pm.rowguid as pmRowGuid,

	        pc.ModifiedDate as pcModifiedDate,
	        pc.Name as pcName,
	        pc.ParentProductCategoryID as pcParentProductCategoryID,
	        pc.ProductCategoryID as pcProductCategoryID,
	        pc.rowguid as pcRowGuid

        from SalesLT.SalesOrderHeader soh
	        left join SalesLT.SalesOrderDetail sod on sod.SalesOrderID = soh.SalesOrderID
	        left join SalesLT.Address shipTo on shipTo.AddressID = soh.ShipToAddressID
	        left join SalesLT.Address billTo on billTo.AddressID = soh.BillToAddressID
	        left join SalesLT.Customer cus on cus.CustomerID = soh.CustomerID
	        left join SalesLT.Product pro on pro.ProductID = sod.ProductID
	        left join SalesLT.ProductModel pm on pm.ProductModelID = pro.ProductModelID
	        left join SalesLT.ProductCategory pc on pc.ProductCategoryID = pro.ProductCategoryID";
        #endregion
    }

    public class SqlServerClass
    {
        public string SohAccountNumber { get; set; }
        public int SohBillToAddressID { get; set; }
        public string SohComment { get; set; }
        public string SohCreditCardApprovalCode { get; set; }
        public int SohCustomerID { get; set; }
        public DateTime SohDueDate { get; set; }
        public decimal SohFreight { get; set; }
        public DateTime SohModifiedDate { get; set; }
        public bool SohOnlineOrderFlag { get; set; }
        public DateTime SohOrderDate { get; set; }
        public string SohPurchaseOrderNumber { get; set; }
        public int SohRevisionNumber { get; set; }
        public Guid SohRowGuid { get; set; }
        public int SohSalesOrderID { get; set; }
        public string SohSalesOrderNumber { get; set; }
        public DateTime SohShipDate { get; set; }
        public string SohShipMethod { get; set; }
        public int SohShipToAddressID { get; set; }
        public int SohStatus { get; set; }
        public decimal SohSubTotal { get; set; }
        public decimal SohTaxAmt { get; set; }
        public decimal SohTotalDue { get; set; }

        public decimal SodLineTotal { get; set; }
        public DateTime SodModifiedDate { get; set; }
        public int SodOrderQty { get; set; }
        public int SodProductID { get; set; }
        public Guid SodRowGuid { get; set; }
        public int SodSalesOrderDetailID { get; set; }
        public int SodSalesOrderID { get; set; }
        public decimal SodUnitPrice { get; set; }
        public decimal SodUnitPriceDiscount { get; set; }

        public int ShipToAddressID { get; set; }
        public string ShipToAddressLine1 { get; set; }
        public string ShipToAddressLine2 { get; set; }
        public string ShipToCity { get; set; }
        public string ShipToCountryRegion { get; set; }
        public DateTime ShipToModifiedDate { get; set; }
        public string ShipToPostalCode { get; set; }
        public Guid ShipToRowGuid { get; set; }
        public string ShipToStateProvince { get; set; }

        public int BillToAddressID { get; set; }
        public string BillToAddressLine1 { get; set; }
        public string BillToAddressLine2 { get; set; }
        public string BillToCity { get; set; }
        public string BillToCountryRegion { get; set; }
        public DateTime BillToModifiedDate { get; set; }
        public string BillToPostalCode { get; set; }
        public Guid BillToRowGuid { get; set; }
        public string BillToStateProvince { get; set; }

        public string CusCompanyName { get; set; }
        public int CusCustomerID { get; set; }
        public string CusEmailAddress { get; set; }
        public string CusFirstName { get; set; }
        public string CusLastName { get; set; }
        public string CusMiddleName { get; set; }
        public DateTime CusModifiedDate { get; set; }
        public bool CusNameStyle { get; set; }
        public string CusPasswordHash { get; set; }
        public string CusPasswordSalt { get; set; }
        public string CusPhone { get; set; }
        public Guid CusRowGuid { get; set; }
        public string CusSalesPerson { get; set; }
        public string CusSuffix { get; set; }
        public string CusTitle { get; set; }

        public string ProColor { get; set; }
        public DateTime ProDiscontinuedDate { get; set; }
        public decimal ProListPrice { get; set; }
        public DateTime ProModifiedDate { get; set; }
        public string ProName { get; set; }
        public int ProProductCategoryID { get; set; }
        public int ProProductID { get; set; }
        public int ProProductModelID { get; set; }
        public string ProProductNumber { get; set; }
        public Guid ProRowGuid { get; set; }
        public DateTime ProSellEndDate { get; set; }
        public DateTime ProSellStartDate { get; set; }
        public string ProSize { get; set; }
        public decimal ProStandardCost { get; set; }
        public byte[] ProThumbNailPhoto { get; set; }
        public string ProThumbnailPhotoFileName { get; set; }
        public decimal ProWeight { get; set; }

        public string PmCatalogDescription { get; set; }
        public DateTime PmModifiedDate { get; set; }
        public string PmName { get; set; }
        public int PmProductModelID { get; set; }
        public Guid PmRowGuid { get; set; }

        public DateTime PcModifiedDate { get; set; }
        public string PcName { get; set; }
        public int PcParentProductCategoryID { get; set; }
        public int PcProductCategoryID { get; set; }
        public Guid PcRowGuid { get; set; }
    }
}
