namespace MinimalApiTest.Domain.Models
{
    public partial class HrdocumentLog
    {
        public long HrdocumentLogId { get; set; }
        public long? HrdocumentId { get; set; }
        public string? DocumentType { get; set; }
        public long? UserId { get; set; }
        public DateTime? DateNotificationAdded { get; set; }
        public DateTime? DateEmailed { get; set; }
        public DateTime? DateReadConfirmed { get; set; }
        public DateTime? DateNotificationCleared { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string? UpdatedUser { get; set; }
    }
}
