namespace MinimalApiTest.Domain.Models
{
    public partial class Sage50ProjectStatus
    {
        public long Sage50ProjectStatusId { get; set; }
        public long? StatusId { get; set; }
        public string? Reference { get; set; }
        public string? Name { get; set; }
        public bool? IsDefault { get; set; }
        public bool? AllowPosting { get; set; }
        public bool? AllowDelete { get; set; }
        public DateTime? RecordCreateDate { get; set; }
        public DateTime? RecordModifyDate { get; set; }
        public bool? RecordDeleted { get; set; }
        public long? SageDatabaseId { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string? UpdatedUser { get; set; }
    }
}
