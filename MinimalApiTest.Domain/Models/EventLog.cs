namespace MinimalApiTest.Domain.Models
{
    public partial class EventLog
    {
        public long EventLogId { get; set; }
        public string? EventMessage { get; set; }
        public string? EventLogEntryType { get; set; }
        public string? EventSource { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string? UpdatedUser { get; set; }
        public string? DocumentType { get; set; }
        public long? DocumentId { get; set; }
        public long? LineId { get; set; }
    }
}
