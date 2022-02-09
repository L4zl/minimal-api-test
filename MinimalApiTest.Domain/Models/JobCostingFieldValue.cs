namespace MinimalApiTest.Domain.Models
{
    public partial class JobCostingFieldValue
    {
        public long JobCostingFieldValueId { get; set; }
        public long? JobCostingJobId { get; set; }
        public string? PropertyName { get; set; }
        public string? Value { get; set; }
        public bool? Deleted { get; set; }
        public bool? SentToSage { get; set; }
        public long? SageDatabaseId { get; set; }
        public string? ErrorMessage { get; set; }
        public string? UpdateStatus { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string? UpdatedUser { get; set; }
    }
}
