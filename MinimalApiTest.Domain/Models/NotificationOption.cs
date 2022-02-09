namespace MinimalApiTest.Domain.Models
{
    public partial class NotificationOption
    {
        public long NotificationOptionId { get; set; }
        public string? DocumentType { get; set; }
        public string? NotificationOptionType { get; set; }
        public bool? GenerateReminders { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string? UpdatedUser { get; set; }
    }
}
