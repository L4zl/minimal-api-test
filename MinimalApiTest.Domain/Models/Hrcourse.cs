namespace MinimalApiTest.Domain.Models
{
    public partial class Hrcourse
    {
        public long HrcourseId { get; set; }
        public long? UserId { get; set; }
        public long? CreatorId { get; set; }
        public bool? IsLocked { get; set; }
        public string? Title { get; set; }
        public string? Notes { get; set; }
        public string? CourseType { get; set; }
        public long? CourseTypeId { get; set; }
        public string? CourseStatus { get; set; }
        public DateTime? DateAdded { get; set; }
        public DateTime? CourseStartDate { get; set; }
        public DateTime? CourseEndDate { get; set; }
        public DateTime? QualificationStartDate { get; set; }
        public DateTime? QualificationExpiryDate { get; set; }
        public DateTime? ReminderDate { get; set; }
        public bool? NotifyUsers { get; set; }
        public bool? RequireReadConfirmation { get; set; }
        public bool? Deleted { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string? UpdatedUser { get; set; }
        public bool? Expiresin3NotificationSent { get; set; }
        public bool? Expiresin1NotificationSent { get; set; }
        public bool? ExpiredNotificationSent { get; set; }
        public bool? ReminderSent { get; set; }
    }
}
