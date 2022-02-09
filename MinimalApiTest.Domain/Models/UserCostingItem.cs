namespace MinimalApiTest.Domain.Models
{
    public partial class UserCostingItem
    {
        public long UserCostingItemId { get; set; }
        public long? UserId { get; set; }
        public long CostingHeaderId { get; set; }
        public long? CostingItemId { get; set; }
        public long? SageDatabaseId { get; set; }
        public decimal? ApprovalValue { get; set; }
        public decimal? ItemValue { get; set; }
        public bool? Requisition { get; set; }
        public bool? Invoice { get; set; }
        public bool? Expense { get; set; }
        public bool? Timesheet { get; set; }
        public bool? HolidayRequest { get; set; }
        public bool? SalesOrder { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string? UpdatedUser { get; set; }
    }
}
