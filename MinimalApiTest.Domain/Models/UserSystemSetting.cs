namespace MinimalApiTest.Domain.Models
{
    public partial class UserSystemSetting
    {
        public long UserSystemSettingId { get; set; }
        public long SettingId { get; set; }
        public long UserId { get; set; }
        public string? SettingValue { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string? UpdatedUser { get; set; }
    }
}
