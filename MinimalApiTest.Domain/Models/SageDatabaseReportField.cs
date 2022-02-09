namespace MinimalApiTest.Domain.Models
{
    public partial class SageDatabaseReportField
    {
        public long SageDatabaseReportFieldId { get; set; }
        public long? SageDatabaseId { get; set; }
        public string? ReportType { get; set; }
        public long? ReportId { get; set; }
        public long? DetailedReportId { get; set; }
        public long? InternalReportId { get; set; }
        public string? EmailBodyText { get; set; }
        public string? EmailSubjectText { get; set; }
        public string? SignaturePage { get; set; }
        public string? TermsAndConditionsPage { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string? UpdatedUser { get; set; }
    }
}
