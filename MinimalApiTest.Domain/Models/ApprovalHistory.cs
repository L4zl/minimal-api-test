namespace MinimalApiTest.Domain.Models
{
    public partial class ApprovalHistory
    {
        public long ApprovalHistoryId { get; set; }
        public long? OrderId { get; set; }
        public long? OrderLineId { get; set; }
        public long? ApprovalUserId { get; set; }
        public string? ApprovalText { get; set; }
        public string? ApprovalType { get; set; }
        public DateTime? ApprovalDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string? UpdatedUser { get; set; }
        public string? Source { get; set; }
        public bool? Rejected { get; set; }
        public long? DelegateApprovalUserId { get; set; }
        public long? SageDatabaseId { get; set; }
    }
}
