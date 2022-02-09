namespace MinimalApiTest.Domain.Models
{
    public partial class UserSageDatabase
    {
        public long UserSageDatabaseId { get; set; }
        public long? UserId { get; set; }
        public long? SageDatabaseId { get; set; }
        public long? PlsupplierAccountId { get; set; }
        public long? MileageNominalAccountId { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string? UpdatedUser { get; set; }
        public bool? DefaultDatabase { get; set; }
        public bool? OverrideNominalAccount { get; set; }
        public bool? OverrideDeliveryAddress { get; set; }
        public long? DefaultNominalAccountId { get; set; }
        public long? DefaultDeliveryAddressId { get; set; }
        public bool? OverrideInvoiceAddress { get; set; }
        public long? DefaultInvoiceAddressId { get; set; }
        public long? TspersonId { get; set; }
        public long? FirstRateMileageExpenseCategoryId { get; set; }
        public long? SecondRateMileageExpenseCategoryId { get; set; }
        public long? CcsStaffId { get; set; }
        public long? CreditCardSupplierAccountId { get; set; }
        public long? FuelCardSupplierAccountId { get; set; }
        public long? PassengerRateMileageExpenseCategoryId { get; set; }
        public long? ComponentWarehouseId { get; set; }
        public bool? TatouchScreenDefault { get; set; }
    }
}
