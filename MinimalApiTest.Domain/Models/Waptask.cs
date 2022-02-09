namespace MinimalApiTest.Domain.Models
{
    public partial class Waptask
    {
        public long WaptaskId { get; set; }
        public long? UserId { get; set; }
        public string? DocumentType { get; set; }
        public string? DocumentSubType { get; set; }
        public string? DocumentTypeFriendly { get; set; }
        public string? Description { get; set; }
        public DateTime? StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        public long? SageDatabaseId { get; set; }
        public long? ForeignParentId { get; set; }
        public long? ForeignId { get; set; }
        public long? ForeignChildId { get; set; }
        public long? CostHeaderId { get; set; }
        public long? CostItemId { get; set; }
        public long? PhaseId { get; set; }
        public long? StageId { get; set; }
        public long? ActivityId { get; set; }
        public string? Notes { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string? UpdatedUser { get; set; }
        public bool? Deleted { get; set; }
    }
}
