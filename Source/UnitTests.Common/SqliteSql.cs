using System;

namespace UnitTests.Common
{
    public static class SqliteSql
    {
        public static readonly string Sql = @"
        select
            od.[Id] as OrderDetailId,      
            od.[Discount] as OrderDetailDiscount,      
            od.[OrderId] as OrderDetailOrderId,      
            od.[Quantity] as OrderDetailQuantity,      
            od.[UnitPrice] as OrderDetailUnitPrice,      
            od.[ProductId] as OrderDetailProductId,
            o.[Id] as OrderId, 
            o.[CustomerId] as OrderCustomerId,      
            o.[EmployeeId] as OrderEmployeeId,      
            o.[Freight] as OrderFreight,      
            o.[OrderDate] as OrderOrderDate,      
            o.[RequiredDate] as OrderRequiredDate,      
            o.[ShipAddress] as OrderShipAddress,      
            o.[ShipCity] as OrderShipCity,      
            o.[ShipCountry] as OrderShipCountry,      
            o.[ShipName] as OrderShipName,      
            o.[ShippedDate] as OrderShippedDate,      
            o.[ShipPostalCode] as OrderShipPostalCode,      
            o.[ShipRegion] as OrderShipRegion,      
            o.[ShipVia] as OrderShipVia,  
            c.[Id] as CustomerId,  
            c.[Address] as CustomerAddress,      
            c.[City] as CustomerCity,      
            c.[CompanyName] as CustomerCompanyName,      
            c.[ContactName] as CustomerContactName,      
            c.[ContactTitle] as CustomerContactTitle,      
            c.[Country] as CustomerCountry,      
            c.[Fax] as CustomerFax,      
            c.[Phone] as CustomerPhone,      
            c.[PostalCode] as CustomerPostalCode,      
            c.[Region] as CustomerRegion,
            e.[Id] as EmployeeId, 
            e.[Address] as EmployeeAddress,      
            e.[BirthDate] as EmployeeBirthDate,      
            e.[City] as EmployeeCity,      
            e.[Country] as EmployeeCountry,      
            e.[Extension] as EmployeeExtension,      
            e.[FirstName] as EmployeeFirstName,      
            e.[HireDate] as EmployeeHireDate,      
            e.[HomePhone] as EmployeeHomePhone,      
            e.[LastName] as EmployeeLastName,      
            e.[Notes] as EmployeeNotes,      
            e.[Photo] as EmployeePhoto,      
            e.[PhotoPath] as EmployeePhotoPath,      
            e.[PostalCode] as EmployeePostalCode,      
            e.[Region] as EmployeeRegion,      
            e.[ReportsTo] as EmployeeReportsTo,      
            e.[Title] as EmployeeTitle,      
            e.[TitleOfCourtesy] as EmployeeTitleOfCourtesy,
            p.[CategoryId] as ProductCategoryId,
            p.[Discontinued] as ProductDiscontinued,
            p.[Id] as ProductId,
            p.[ProductName] as ProductProductName,
            p.[QuantityPerUnit] as ProductQuantityPerUnit,
            p.[ReorderLevel] as ProductReorderLevel,
            p.[SupplierId] as ProductSupplierId,
            p.[UnitPrice] as ProductUnitPrice,
            p.[UnitsInStock] as ProductUnitsInStock,
            p.[UnitsOnOrder] as ProductUnitsOnOrder,
            s.[Address] as SupplierAddress,
            s.[City] as SupplierCity,
            s.[CompanyName] as SupplierCompanyName,
            s.[ContactName] as SupplierContactName,
            s.[ContactTitle] as SupplierContactTitle,
            s.[Country] as SupplierCountry,
            s.[Fax] as SupplierFax,
            s.[HomePage] as SupplierHomePage,
            s.[Id] as SupplierId,
            s.[Phone] as SupplierPhone,
            s.[PostalCode] as SupplierPostalCode,
            s.[Region] as SupplierRegion
        from main.[OrderDetail] od
            left join main.[Order] o on o.[Id] = od.[OrderId]     
            left join main.[Product] p on p.[Id] = od.[ProductId]
            left join main.[Customer] c on c.[Id] = o.[CustomerId]
            left join main.[Employee] e on e.[Id] = o.[EmployeeId]
            left join main.[Supplier] s on s.[Id] = p.[SupplierId]";

        public static readonly string SqlLimitOne = Sql + " limit 1";
    }

    public class MultipleFieldClass
    {
        public string OrderDetailId { get; set; }
        public int OrderDetailOrderId { get; set; }
        public int OrderDetailProductId { get; set; }
        public decimal OrderDetailUnitPrice { get; set; }
        public int OrderDetailQuantity { get; set; }
        public double OrderDetailDiscount { get; set; }

        public int OrderId { get; set; }
        public string OrderCustomerId { get; set; }
        public int OrderEmployeeId { get; set; }
        public DateTime OrderOrderDate { get; set; }
        public DateTime OrderRequiredDate { get; set; }
        public DateTime OrderShippedDate { get; set; }
        public int OrderShipVia { get; set; }
        public decimal OrderFreight { get; set; }
        public string OrderShipName { get; set; }
        public string OrderShipAddress { get; set; }
        public string OrderShipCity { get; set; }
        public string OrderShipRegion { get; set; }
        public string OrderShipPostalCode { get; set; }
        public string OrderShipCountry { get; set; }

        public string CustomerId { get; set; }
        public string CustomerCompanyName { get; set; }
        public string CustomerContactName { get; set; }
        public string CustomerContactTitle { get; set; }
        public string CustomerAddress { get; set; }
        public string CustomerCity { get; set; }
        public string CustomerRegion { get; set; }
        public string CustomerPostalCode { get; set; }
        public string CustomerPhone { get; set; }
        public string CustomerCountry { get; set; }
        public string CustomerFax { get; set; }

        public int EmployeeId { get; set; }
        public string EmployeeLastName { get; set; }
        public string EmployeeFirstName { get; set; }
        public string EmployeeTitle { get; set; }
        public string EmployeeTitleOfCourtesy { get; set; }
        public DateTime EmployeeBirthDate { get; set; }
        public DateTime EmployeeHireDate { get; set; }
        public string EmployeeAddress { get; set; }
        public string EmployeeCity { get; set; }
        public string EmployeeRegion { get; set; }
        public string EmployeePostalCode { get; set; }
        public string EmployeeCountry { get; set; }
        public string EmployeeHomePhone { get; set; }
        public string EmployeeExtension { get; set; }
        public byte[] EmployeePhoto { get; set; }
        public string EmployeeNotes { get; set; }
        public int EmployeeReportsTo { get; set; }
        public string EmployeePhotoPath { get; set; }

        public int ProductId { get; set; }
        public string ProductProductName { get; set; }
        public int ProductSupplierId { get; set; }
        public int ProductCategoryId { get; set; }
        public string ProductQuantityPerUnit { get; set; }
        public decimal ProductUnitPrice { get; set; }
        public int ProductUnitsInStock { get; set; }
        public int ProductUnitsOnOrder { get; set; }
        public int ProductReorderLevel { get; set; }
        public int ProductDiscontinued { get; set; }

        public int SupplierId { get; set; }
        public string SupplierCompanyName { get; set; }
        public string SupplierContactName { get; set; }
        public string SupplierContactTitle { get; set; }
        public string SupplierAddress { get; set; }
        public string SupplierCity { get; set; }
        public string SupplierRegion { get; set; }
        public string SupplierPostalCode { get; set; }
        public string SupplierCountry { get; set; }
        public string SupplierPhone { get; set; }
        public string SupplierFax { get; set; }
        public string SupplierHomePage { get; set; }
    }

    public class MultipleFieldClassConvert
    {
        public string OrderDetailId { get; set; }
        public decimal OrderDetailOrderId { get; set; }
        public decimal OrderDetailProductId { get; set; }
        public decimal OrderDetailUnitPrice { get; set; }
        public decimal OrderDetailQuantity { get; set; }
        public decimal OrderDetailDiscount { get; set; }

        public decimal OrderId { get; set; }
        public string OrderCustomerId { get; set; }
        public decimal OrderEmployeeId { get; set; }
        public DateTime OrderOrderDate { get; set; }
        public DateTime OrderRequiredDate { get; set; }
        public DateTime OrderShippedDate { get; set; }
        public decimal OrderShipVia { get; set; }
        public decimal OrderFreight { get; set; }
        public string OrderShipName { get; set; }
        public string OrderShipAddress { get; set; }
        public string OrderShipCity { get; set; }
        public string OrderShipRegion { get; set; }
        public string OrderShipPostalCode { get; set; }
        public string OrderShipCountry { get; set; }

        public string CustomerId { get; set; }
        public string CustomerCompanyName { get; set; }
        public string CustomerContactName { get; set; }
        public string CustomerContactTitle { get; set; }
        public string CustomerAddress { get; set; }
        public string CustomerCity { get; set; }
        public string CustomerRegion { get; set; }
        public string CustomerPostalCode { get; set; }
        public string CustomerPhone { get; set; }
        public string CustomerCountry { get; set; }
        public string CustomerFax { get; set; }

        public decimal EmployeeId { get; set; }
        public string EmployeeLastName { get; set; }
        public string EmployeeFirstName { get; set; }
        public string EmployeeTitle { get; set; }
        public string EmployeeTitleOfCourtesy { get; set; }
        public DateTime EmployeeBirthDate { get; set; }
        public DateTime EmployeeHireDate { get; set; }
        public string EmployeeAddress { get; set; }
        public string EmployeeCity { get; set; }
        public string EmployeeRegion { get; set; }
        public string EmployeePostalCode { get; set; }
        public string EmployeeCountry { get; set; }
        public string EmployeeHomePhone { get; set; }
        public string EmployeeExtension { get; set; }
        public byte[] EmployeePhoto { get; set; }
        public string EmployeeNotes { get; set; }
        public decimal EmployeeReportsTo { get; set; }
        public string EmployeePhotoPath { get; set; }

        public decimal ProductId { get; set; }
        public string ProductProductName { get; set; }
        public decimal ProductSupplierId { get; set; }
        public decimal ProductCategoryId { get; set; }
        public string ProductQuantityPerUnit { get; set; }
        public decimal ProductUnitPrice { get; set; }
        public decimal ProductUnitsInStock { get; set; }
        public decimal ProductUnitsOnOrder { get; set; }
        public decimal ProductReorderLevel { get; set; }
        public decimal ProductDiscontinued { get; set; }

        public decimal SupplierId { get; set; }
        public string SupplierCompanyName { get; set; }
        public string SupplierContactName { get; set; }
        public string SupplierContactTitle { get; set; }
        public string SupplierAddress { get; set; }
        public string SupplierCity { get; set; }
        public string SupplierRegion { get; set; }
        public string SupplierPostalCode { get; set; }
        public string SupplierCountry { get; set; }
        public string SupplierPhone { get; set; }
        public string SupplierFax { get; set; }
        public string SupplierHomePage { get; set; }
    }

    public struct MultipleFieldStruct
    {
        public string OrderDetailId { get; set; }
        public int OrderDetailOrderId { get; set; }
        public int OrderDetailProductId { get; set; }
        public decimal OrderDetailUnitPrice { get; set; }
        public int OrderDetailQuantity { get; set; }
        public double OrderDetailDiscount { get; set; }

        public int OrderId { get; set; }
        public string OrderCustomerId { get; set; }
        public int OrderEmployeeId { get; set; }
        public DateTime OrderOrderDate { get; set; }
        public DateTime OrderRequiredDate { get; set; }
        public DateTime OrderShippedDate { get; set; }
        public int OrderShipVia { get; set; }
        public decimal OrderFreight { get; set; }
        public string OrderShipName { get; set; }
        public string OrderShipAddress { get; set; }
        public string OrderShipCity { get; set; }
        public string OrderShipRegion { get; set; }
        public string OrderShipPostalCode { get; set; }
        public string OrderShipCountry { get; set; }

        public string CustomerId { get; set; }
        public string CustomerCompanyName { get; set; }
        public string CustomerContactName { get; set; }
        public string CustomerContactTitle { get; set; }
        public string CustomerAddress { get; set; }
        public string CustomerCity { get; set; }
        public string CustomerRegion { get; set; }
        public string CustomerPostalCode { get; set; }
        public string CustomerPhone { get; set; }
        public string CustomerCountry { get; set; }
        public string CustomerFax { get; set; }

        public int EmployeeId { get; set; }
        public string EmployeeLastName { get; set; }
        public string EmployeeFirstName { get; set; }
        public string EmployeeTitle { get; set; }
        public string EmployeeTitleOfCourtesy { get; set; }
        public DateTime EmployeeBirthDate { get; set; }
        public DateTime EmployeeHireDate { get; set; }
        public string EmployeeAddress { get; set; }
        public string EmployeeCity { get; set; }
        public string EmployeeRegion { get; set; }
        public string EmployeePostalCode { get; set; }
        public string EmployeeCountry { get; set; }
        public string EmployeeHomePhone { get; set; }
        public string EmployeeExtension { get; set; }
        public byte[] EmployeePhoto { get; set; }
        public string EmployeeNotes { get; set; }
        public int EmployeeReportsTo { get; set; }
        public string EmployeePhotoPath { get; set; }

        public int ProductId { get; set; }
        public string ProductProductName { get; set; }
        public int ProductSupplierId { get; set; }
        public int ProductCategoryId { get; set; }
        public string ProductQuantityPerUnit { get; set; }
        public decimal ProductUnitPrice { get; set; }
        public int ProductUnitsInStock { get; set; }
        public int ProductUnitsOnOrder { get; set; }
        public int ProductReorderLevel { get; set; }
        public int ProductDiscontinued { get; set; }

        public int SupplierId { get; set; }
        public string SupplierCompanyName { get; set; }
        public string SupplierContactName { get; set; }
        public string SupplierContactTitle { get; set; }
        public string SupplierAddress { get; set; }
        public string SupplierCity { get; set; }
        public string SupplierRegion { get; set; }
        public string SupplierPostalCode { get; set; }
        public string SupplierCountry { get; set; }
        public string SupplierPhone { get; set; }
        public string SupplierFax { get; set; }
        public string SupplierHomePage { get; set; }
    }

    public struct MultipleFieldStructConvert
    {
        public string OrderDetailId { get; set; }
        public decimal OrderDetailOrderId { get; set; }
        public decimal OrderDetailProductId { get; set; }
        public decimal OrderDetailUnitPrice { get; set; }
        public decimal OrderDetailQuantity { get; set; }
        public decimal OrderDetailDiscount { get; set; }

        public decimal OrderId { get; set; }
        public string OrderCustomerId { get; set; }
        public decimal OrderEmployeeId { get; set; }
        public DateTime OrderOrderDate { get; set; }
        public DateTime OrderRequiredDate { get; set; }
        public DateTime OrderShippedDate { get; set; }
        public decimal OrderShipVia { get; set; }
        public decimal OrderFreight { get; set; }
        public string OrderShipName { get; set; }
        public string OrderShipAddress { get; set; }
        public string OrderShipCity { get; set; }
        public string OrderShipRegion { get; set; }
        public string OrderShipPostalCode { get; set; }
        public string OrderShipCountry { get; set; }

        public string CustomerId { get; set; }
        public string CustomerCompanyName { get; set; }
        public string CustomerContactName { get; set; }
        public string CustomerContactTitle { get; set; }
        public string CustomerAddress { get; set; }
        public string CustomerCity { get; set; }
        public string CustomerRegion { get; set; }
        public string CustomerPostalCode { get; set; }
        public string CustomerPhone { get; set; }
        public string CustomerCountry { get; set; }
        public string CustomerFax { get; set; }

        public decimal EmployeeId { get; set; }
        public string EmployeeLastName { get; set; }
        public string EmployeeFirstName { get; set; }
        public string EmployeeTitle { get; set; }
        public string EmployeeTitleOfCourtesy { get; set; }
        public DateTime EmployeeBirthDate { get; set; }
        public DateTime EmployeeHireDate { get; set; }
        public string EmployeeAddress { get; set; }
        public string EmployeeCity { get; set; }
        public string EmployeeRegion { get; set; }
        public string EmployeePostalCode { get; set; }
        public string EmployeeCountry { get; set; }
        public string EmployeeHomePhone { get; set; }
        public string EmployeeExtension { get; set; }
        public byte[] EmployeePhoto { get; set; }
        public string EmployeeNotes { get; set; }
        public decimal EmployeeReportsTo { get; set; }
        public string EmployeePhotoPath { get; set; }

        public decimal ProductId { get; set; }
        public string ProductProductName { get; set; }
        public decimal ProductSupplierId { get; set; }
        public decimal ProductCategoryId { get; set; }
        public string ProductQuantityPerUnit { get; set; }
        public decimal ProductUnitPrice { get; set; }
        public decimal ProductUnitsInStock { get; set; }
        public decimal ProductUnitsOnOrder { get; set; }
        public decimal ProductReorderLevel { get; set; }
        public decimal ProductDiscontinued { get; set; }

        public decimal SupplierId { get; set; }
        public string SupplierCompanyName { get; set; }
        public string SupplierContactName { get; set; }
        public string SupplierContactTitle { get; set; }
        public string SupplierAddress { get; set; }
        public string SupplierCity { get; set; }
        public string SupplierRegion { get; set; }
        public string SupplierPostalCode { get; set; }
        public string SupplierCountry { get; set; }
        public string SupplierPhone { get; set; }
        public string SupplierFax { get; set; }
        public string SupplierHomePage { get; set; }
    }
}