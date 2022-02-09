namespace MinimalApiTest.Domain.Models
{
    public partial class PushNotificationToken
    {
        public long PushNotificationTokenId { get; set; }
        public long? UserId { get; set; }
        public string? Token { get; set; }
        public string? DeviceType { get; set; }
        public DateTime? LastUsedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
    }
}
