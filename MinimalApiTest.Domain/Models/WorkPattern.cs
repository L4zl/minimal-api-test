namespace MinimalApiTest.Domain.Models
{
    public partial class WorkPattern
    {
        public long WorkPatternId { get; set; }
        public string? WorkPatternName { get; set; }
        public bool? Deleted { get; set; }
        public bool? DefaultWorkPattern { get; set; }
        public string? DeductX { get; set; }
        public string? MoreThanXlate { get; set; }
        public string? LoginRoundUpX { get; set; }
        public string? LoginRoundUpAllowance { get; set; }
        public string? LogoutRoundDownX { get; set; }
        public string? LogoutRoundDownAllowance { get; set; }
        public string? RoundDeduct { get; set; }
        public string? WorkPatternType { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string? UpdatedUser { get; set; }
        public long? WorkPatternRuleId { get; set; }
        public decimal? BreakAmount { get; set; }
    }
}
