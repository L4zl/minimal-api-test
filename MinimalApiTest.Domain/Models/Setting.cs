namespace MinimalApiTest.Domain.Models
{
    public partial class Setting
    {
        public long SettingId { get; set; }
        public string? SettingName { get; set; }
        public string? SettingValue { get; set; }
        public string? SettingDescription { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string? UpdatedUser { get; set; }
    }
}
