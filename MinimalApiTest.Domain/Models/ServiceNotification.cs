namespace MinimalApiTest.Domain.Models
{
    public partial class ServiceNotification
    {
        public long ServiceNotificationId { get; set; }
        public string NotificationText { get; set; } = null!;
        public long? SageDatabaseId { get; set; }
        public DateTime? ExpiryTime { get; set; }
        public string Module { get; set; } = null!;
        public string DocumentType { get; set; } = null!;
        public string SystemMessageType { get; set; } = null!;
        public long? ForeignKey { get; set; }
        public bool? EmailSent { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string? UpdatedUser { get; set; }
    }
}
