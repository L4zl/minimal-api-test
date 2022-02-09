namespace MinimalApiTest.Domain.Models
{
    public partial class SalesOrderReport
    {
        public long SalesOrderReportId { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? Report { get; set; }
        public bool? Deleted { get; set; }
        public int? ReportType { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string? UpdatedUser { get; set; }
        public byte[]? LayoutData { get; set; }
        public int? SecurityLevel { get; set; }
    }
}
