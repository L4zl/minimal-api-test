namespace MinimalApiTest.Domain.Models
{
    public partial class ApprovalRouteEntryItem
    {
        public long ApprovalRouteEntryItemId { get; set; }
        public long? ApprovalRouteEntryId { get; set; }
        public long? ApproverId { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string? UpdatedUser { get; set; }
    }
}
