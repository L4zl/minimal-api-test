namespace MinimalApiTest.Domain.Models
{
    public partial class MeetingRequest
    {
        public long MeetingRequestId { get; set; }
        public string? Recipient { get; set; }
        public DateTime? DateSent { get; set; }
        public DateTime? StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        public string? Subject { get; set; }
        public string? Location { get; set; }
        public string? Body { get; set; }
        public string? Uid { get; set; }
        public bool? Cancelled { get; set; }
        public string? DocumentType { get; set; }
        public long? DocumentId { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string? UpdatedUser { get; set; }
        public long? UserId { get; set; }
    }
}
