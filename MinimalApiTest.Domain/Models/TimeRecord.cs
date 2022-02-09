namespace MinimalApiTest.Domain.Models
{
    public partial class TimeRecord
    {
        public long TimeRecordId { get; set; }
        public long? UserId { get; set; }
        public long? ForieignId { get; set; }
        public long? SageDatabaseId { get; set; }
        public string? TaskDescription { get; set; }
        public string? DocumentType { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string? UpdatedUser { get; set; }
        public bool? Deleted { get; set; }
    }
}
