namespace MinimalApiTest.Domain.Models
{
    public partial class ApprovalRouteReportHeaderView
    {
        public long ApprovalRouteEntryId { get; set; }
        public long? NominalAccountId { get; set; }
        public long? SupplierId { get; set; }
        public long? SageDatabaseId { get; set; }
        public long? RequestingUserId { get; set; }
        public long? ProjectId { get; set; }
        public long? ProjectItemId { get; set; }
        public string? DocumentType { get; set; }
        public long? ValueBandId { get; set; }
        public string? JobManager { get; set; }
    }
}
