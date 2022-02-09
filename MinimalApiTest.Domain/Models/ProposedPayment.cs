namespace MinimalApiTest.Domain.Models
{
    public partial class ProposedPayment
    {
        public long ProposedPaymentId { get; set; }
        public long? PlproposedPaymentId { get; set; }
        public decimal? BankChequeValue { get; set; }
        public decimal? BankChequeDiscountValue { get; set; }
        public bool? MaxChequeValueExceeded { get; set; }
        public long? PlsupplierAccountId { get; set; }
        public string? SupplierReference { get; set; }
        public string? SupplierName { get; set; }
        public bool? PaidFlag { get; set; }
        public DateTime? DateTimeCreated { get; set; }
        public DateTime? DateTimeUpdated { get; set; }
        public DateTime? DocumentDate { get; set; }
        public DateTime? FullyApprovedDate { get; set; }
        public DateTime? SubmittedDate { get; set; }
        public long? SageDatabaseId { get; set; }
        public string? DocumentStatus { get; set; }
        public string? UpdateStatus { get; set; }
        public string? ErrorMessage { get; set; }
        public bool? Deleted { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string? UpdatedUser { get; set; }
    }
}
