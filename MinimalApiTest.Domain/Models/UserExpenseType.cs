namespace MinimalApiTest.Domain.Models
{
    public partial class UserExpenseType
    {
        public long UserExpenseTypeId { get; set; }
        public long? UserId { get; set; }
        public long? ExpenseTypeId { get; set; }
        public long? SageDatabaseId { get; set; }
        public long? NlnominalAccountId { get; set; }
        public long? SystaxRateId { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string? UpdatedUser { get; set; }
        public bool? Selectable { get; set; }
        public string? Memo { get; set; }
        public decimal? MaximumClaim { get; set; }
        public long? CostingItemId { get; set; }
        public long? ExpenseMeetingId { get; set; }
    }
}
