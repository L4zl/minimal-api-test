namespace MinimalApiTest.Domain.Models
{
    public partial class SageDatabaseSystemSetting
    {
        public long SageDatabaseSystemSettingId { get; set; }
        public long SettingId { get; set; }
        public long SageDatabaseId { get; set; }
        public string? SettingValue { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string? UpdatedUser { get; set; }
    }
}
