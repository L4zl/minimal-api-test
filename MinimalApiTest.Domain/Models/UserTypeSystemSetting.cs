namespace MinimalApiTest.Domain.Models
{
    public partial class UserTypeSystemSetting
    {
        public long UserTypeSystemSettingId { get; set; }
        public long SettingId { get; set; }
        public long UserTypeId { get; set; }
        public string? SettingValue { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string? UpdatedUser { get; set; }
    }
}
