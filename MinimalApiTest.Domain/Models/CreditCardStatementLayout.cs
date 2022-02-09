namespace MinimalApiTest.Domain.Models
{
    public partial class CreditCardStatementLayout
    {
        public long CreditCardStatementLayoutId { get; set; }
        public string? StatementDescription { get; set; }
        public long? TransactionDate { get; set; }
        public long? CreditCardNumber { get; set; }
        public long? TransactionValue { get; set; }
        public long? UserName { get; set; }
        public long? ExpenseType { get; set; }
        public long? TaxRate { get; set; }
        public long? TaxAmount { get; set; }
        public long? NominalAccountReference { get; set; }
        public long? NominalCostCenter { get; set; }
        public long? NominalDepartment { get; set; }
        public long? LineDescription { get; set; }
        public long? AdditionalNotes { get; set; }
        public string? Delimiter { get; set; }
        public string? QouteChar { get; set; }
        public string? EscapeChar { get; set; }
        public string? CommentChar { get; set; }
        public bool? Selectable { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string? UpdatedUser { get; set; }
    }
}
