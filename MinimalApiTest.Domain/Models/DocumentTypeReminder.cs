namespace MinimalApiTest.Domain.Models
{
    public partial class DocumentTypeReminder
    {
        public long DocumentTypeReminderId { get; set; }
        public string? DocumentType { get; set; }
        public int? DayOfMonth { get; set; }
        public DateTime? NextSendTime { get; set; }
        public string? ReminderDescription { get; set; }
        public string? ReminderText { get; set; }
        public bool? IsEnabled { get; set; }
        public int? PriorityId { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string? UpdatedUser { get; set; }
        public string? ReminderInterval { get; set; }
        public int? DayOfWeek { get; set; }
        public DateTime? TimeOfDay { get; set; }
        public bool? SendNow { get; set; }
        public bool? UseOooalternate { get; set; }
        public string? ReminderOption { get; set; }
    }
}
