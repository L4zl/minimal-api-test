namespace MinimalApiTest.Domain.Models
{
    public partial class UserSetting
    {
        public long UserSettingId { get; set; }
        public long? UserId { get; set; }
        public bool? LoadNominalAccountLists { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string? UpdatedUser { get; set; }
        public string? StockSelectionMode { get; set; }
        public bool? ShowProjectSelectionOnExpenseEntry { get; set; }
        public bool? OrderTemplateAutoAddItemsWithQuantity { get; set; }
        public string? ThemeName { get; set; }
        public bool? PageCustomisation { get; set; }
        public bool PoemailIncludeMe { get; set; }
        public bool TimesheetEmailIncludeMe { get; set; }
        public bool TwoFactorAuthentication { get; set; }
        public bool? ShowQuickLinks { get; set; }
    }
}
