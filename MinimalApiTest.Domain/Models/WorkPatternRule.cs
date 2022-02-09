namespace MinimalApiTest.Domain.Models
{
    public partial class WorkPatternRule
    {
        public long WorkPatternRuleId { get; set; }
        public string? WorkPatternRuleName { get; set; }
        public string? Description { get; set; }
        public long? Rate1Id { get; set; }
        public long? Rate2Id { get; set; }
        public long? Rate3Id { get; set; }
        public long? Rate4Id { get; set; }
        public string? Rate1Label { get; set; }
        public string? Rate2Label { get; set; }
        public string? Rate3Label { get; set; }
        public string? Rate4Label { get; set; }
        public decimal? HoursBeforeBreak { get; set; }
        public decimal? BreakAmount { get; set; }
        public bool? Deleted { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string? UpdatedUser { get; set; }
    }
}
