namespace MinimalApiTest.Domain.Models
{
    public partial class CustomerAnalysisValue
    {
        public long CustomerAnalysisValueId { get; set; }
        public long? CustomerId { get; set; }
        public long? SageDatabaseId { get; set; }
        public long? AnalysisCodeId { get; set; }
        public string? AnalysisValue { get; set; }
        public bool? Mandatory { get; set; }
        public bool? Deleted { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string? UpdatedUser { get; set; }
        public string? Type { get; set; }
    }
}
