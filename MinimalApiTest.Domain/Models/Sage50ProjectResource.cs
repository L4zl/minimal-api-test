namespace MinimalApiTest.Domain.Models
{
    public partial class Sage50ProjectResource
    {
        public long Sage50ProjectResourceId { get; set; }
        public long? ResourceId { get; set; }
        public string? Reference { get; set; }
        public string? Name { get; set; }
        public string? Unit { get; set; }
        public long? DefaultCostCodeId { get; set; }
        public decimal? Rate { get; set; }
        public DateTime? RecordCreateDate { get; set; }
        public DateTime? RecordModifyDate { get; set; }
        public bool? RecordDeleted { get; set; }
        public long? SageDatabaseId { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string? UpdatedUser { get; set; }
    }
}
