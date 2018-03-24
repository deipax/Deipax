namespace Benchmarks.DataAccess.BaseClasses
{
    public abstract class BaseSelect
    {
        #region Field Members
        protected static readonly string _sql = @"
        select
              od.[Id] as OrderDetailId,      
              od.[Discount] as Discount,      
              od.[OrderId] as OrderId,      
              od.[Quantity] as Quantity,      
              od.[UnitPrice] as UnitPrice,      
              od.[ProductId] as ProductId,      
              o.[CustomerId] as CustomerId,      
              o.[EmployeeId] as EmployeeId,      
              o.[Freight] as Freight,      
              o.[OrderDate] as OrderDate,      
              o.[RequiredDate] as RequiredDate,      
              o.[ShipAddress] as ShipAddress,      
              o.[ShipCity] as ShipCity,      
              o.[ShipCountry] as ShipCountry,      
              o.[ShipName] as ShipName,      
              o.[ShippedDate] as ShippedDate,      
              o.[ShipPostalCode] as ShipPostalCode,      
              o.[ShipRegion] as ShipRegion,      
              o.[ShipVia] as ShipVia,      
              c.[Address] as  CustomerAddress,      
              c.[City] as CustomerCity,      
              c.[CompanyName] as CustomerCompanyName,      
              c.[ContactName] as CustomerContactName,      
              c.[ContactTitle] as CustomerContactTitle,      
              c.[Country] as CustomerCountry,      
              c.[Fax] as CustomerFax,      
              c.[Phone] as CustomerPhone,      
              c.[PostalCode] as CustomerPostalCode,      
              c.[Region] as CustomerRegion,      
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
              e.[TitleOfCourtesy] as EmployeeTitleOfCourtesy
        from main.[OrderDetail] od
             inner join main.[Order] o on o.[Id] = od.[OrderId]     
             inner join main.[Product] p on p.[Id] = od.[ProductId]
             inner join main.[Customer] c on c.[Id] = o.[CustomerId]
             inner join main.[Employee] e on e.[Id] = o.[EmployeeId]";
        #endregion

        public abstract void AllFieldsAsClass();
        public abstract void AllFieldsAsStruct();
        public abstract void SingleFieldAsClass();
        public abstract void SingleFieldAsStruct();

        #region Helpers
        protected class MultipleFieldClass
        {
            public string OrderDetailId { get; set; }
            public double Discount { get; set; }
            public int OrderId { get; set; }
            public int Quantity { get; set; }
            public decimal UnitPrice { get; set; }
            public int ProductId { get; set; }
            public string CustomerId { get; set; }
            public int EmployeeId { get; set; }
            public decimal Freight { get; set; }
            public string OrderDate { get; set; }
            public string RequiredDate { get; set; }
            public string ShipAddress { get; set; }
            public string ShipCity { get; set; }
            public string ShipCountry { get; set; }
            public string ShipName { get; set; }
            public string ShippedDate { get; set; }
            public string ShipPostalCode { get; set; }
            public string ShipRegion { get; set; }
            public int ShipVia { get; set; }
            public string CustomerAddress { get; set; }
            public string CustomerCity { get; set; }
            public string CustomerCompanyName { get; set; }
            public string CustomerContactName { get; set; }
            public string CustomerContactTitle { get; set; }
            public string CustomerCountry { get; set; }
            public string CustomerFax { get; set; }
            public string CustomerPhone { get; set; }
            public string CustomerPostalCode { get; set; }
            public string CustomerRegion { get; set; }
            public string EmployeeAddress { get; set; }
            public string EmployeeBirthDate { get; set; }
            public string EmployeeCity { get; set; }
            public string EmployeeCountry { get; set; }
            public string EmployeeExtension { get; set; }
            public string EmployeeFirstName { get; set; }
            public string EmployeeHireDate { get; set; }
            public string EmployeeHomePhone { get; set; }
            public string EmployeeLastName { get; set; }
            public string EmployeeNotes { get; set; }
            public byte[] EmployeePhoto { get; set; }
            public string EmployeePhotoPath { get; set; }
            public string EmployeePostalCode { get; set; }
            public string EmployeeRegion { get; set; }
            public int EmployeeReportsTo { get; set; }
            public string EmployeeTitle { get; set; }
            public string EmployeeTitleOfCourtesy { get; set; }
        }

        protected struct MultipleFieldStruct
        {
            public string OrderDetailId { get; set; }
            public double Discount { get; set; }
            public int OrderId { get; set; }
            public int Quantity { get; set; }
            public decimal UnitPrice { get; set; }
            public int ProductId { get; set; }
            public string CustomerId { get; set; }
            public int EmployeeId { get; set; }
            public decimal Freight { get; set; }
            public string OrderDate { get; set; }
            public string RequiredDate { get; set; }
            public string ShipAddress { get; set; }
            public string ShipCity { get; set; }
            public string ShipCountry { get; set; }
            public string ShipName { get; set; }
            public string ShippedDate { get; set; }
            public string ShipPostalCode { get; set; }
            public string ShipRegion { get; set; }
            public int ShipVia { get; set; }
            public string CustomerAddress { get; set; }
            public string CustomerCity { get; set; }
            public string CustomerCompanyName { get; set; }
            public string CustomerContactName { get; set; }
            public string CustomerContactTitle { get; set; }
            public string CustomerCountry { get; set; }
            public string CustomerFax { get; set; }
            public string CustomerPhone { get; set; }
            public string CustomerPostalCode { get; set; }
            public string CustomerRegion { get; set; }
            public string EmployeeAddress { get; set; }
            public string EmployeeBirthDate { get; set; }
            public string EmployeeCity { get; set; }
            public string EmployeeCountry { get; set; }
            public string EmployeeExtension { get; set; }
            public string EmployeeFirstName { get; set; }
            public string EmployeeHireDate { get; set; }
            public string EmployeeHomePhone { get; set; }
            public string EmployeeLastName { get; set; }
            public string EmployeeNotes { get; set; }
            public byte[] EmployeePhoto { get; set; }
            public string EmployeePhotoPath { get; set; }
            public string EmployeePostalCode { get; set; }
            public string EmployeeRegion { get; set; }
            public int EmployeeReportsTo { get; set; }
            public string EmployeeTitle { get; set; }
            public string EmployeeTitleOfCourtesy { get; set; }
        }

        protected class SingleFieldClass
        {
            public string OrderDetailId { get; set; }
        }

        protected struct SingleFieldStruct
        {
            public string OrderDetailId { get; set; }
        }
        #endregion
    }
}