namespace MinimalApiTest.Domain.Models
{
    public partial class CreditCardStatementLine
    {
        public long CreditCardStatementLineId { get; set; }
        public long? CreditCardStatementId { get; set; }
        public long? UserId { get; set; }
        public long? CreditCardId { get; set; }
        public decimal? TransactionValue { get; set; }
        public DateTime? TransactionDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string? UpdatedUser { get; set; }
        public bool? Deleted { get; set; }
    }
}
