namespace MinimalApiTest.Domain.Models
{
    public partial class CreditCardStatement
    {
        public long CreditCardStatementId { get; set; }
        public string? Filename { get; set; }
        public string? Description { get; set; }
        public DateTime? StatementDate { get; set; }
        public DateTime? StatementImportDate { get; set; }
        public decimal? TotalValue { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string? UpdatedUser { get; set; }
        public long? ImportedByUserId { get; set; }
        public bool? Deleted { get; set; }
    }
}
