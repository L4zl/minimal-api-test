namespace MinimalApiTest.Domain.Models
{
    public partial class CreditCard
    {
        public long CreditCardId { get; set; }
        public string? Description { get; set; }
        public long? CreditCardFieldMappingId { get; set; }
        public string? DebitCreditCardType { get; set; }
        public string? CardSupplier { get; set; }
        public string? Issuer { get; set; }
        public string? CardNumber { get; set; }
        public string? ExpiryDate { get; set; }
        public string? SortCode { get; set; }
        public string? AccountNumber { get; set; }
        public long? SageDatabaseId { get; set; }
        public long? SupplierAccountId { get; set; }
        public bool? Deleted { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string? UpdatedUser { get; set; }
        public bool? Selectable { get; set; }
    }
}
