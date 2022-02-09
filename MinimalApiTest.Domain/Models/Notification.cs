namespace MinimalApiTest.Domain.Models
{
    public partial class Notification
    {
        public long NotificationId { get; set; }
        public string? Message { get; set; }
        public int? PriorityId { get; set; }
        public DateTime? NotifyTime { get; set; }
        public bool? NotifyRead { get; set; }
        public int? NotificationTypeId { get; set; }
        public long? ForeignKey { get; set; }
        public long? ForeignParentKey { get; set; }
        public long? UserId { get; set; }
        public bool? EmailSent { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string? UpdatedUser { get; set; }
        public string? DocumentType { get; set; }
        public bool? ConfirmRequired { get; set; }
        public bool? Urgent { get; set; }
        public long OutOfOfficeOriginalApproverId { get; set; }
        public long? SageDatabaseId { get; set; }
    }
}
