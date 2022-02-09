namespace MinimalApiTest.Domain.Models
{
    public partial class DeliveryAddress
    {
        public long DeliveryAddressId { get; set; }
        public string? Address1 { get; set; }
        public string? Address2 { get; set; }
        public string? Address3 { get; set; }
        public string? Address4 { get; set; }
        public string? PostCode { get; set; }
        public string? ContactName { get; set; }
        public string? DropDownDescription { get; set; }
        public bool? DefaultAddress { get; set; }
        public bool? Deleted { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string? UpdatedUser { get; set; }
        public long? WarehouseId { get; set; }
        public string? Name { get; set; }
        public string? PostalName { get; set; }
        public string? TelephoneNo { get; set; }
        public string? FaxNo { get; set; }
        public string? EmailAddress { get; set; }
        public string? WebAddress { get; set; }
        public long? SageDatabaseId { get; set; }
        public bool? IsSageAddress { get; set; }
        public bool? IsCustomAddress { get; set; }
        public string? SageDatabaseName { get; set; }
        public long? PlsupplierAccountId { get; set; }
        public string? SupplierName { get; set; }
        public bool? DefaultInvoiceAddress { get; set; }
        public bool? IsMainAddress { get; set; }
    }
}
