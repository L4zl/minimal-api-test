namespace MinimalApiTest.Domain.Models
{
    public partial class ApprovalHoldReason
    {
        public long ApprovalHoldReasonId { get; set; }
        public string? DocumentType { get; set; }
        public string? HoldReason { get; set; }
    }
}
