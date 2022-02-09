namespace MinimalApiTest.Domain.Models
{
    public partial class CostDeptRule
    {
        public long CostDeptRuleId { get; set; }
        public long? CostDeptId { get; set; }
        public decimal? ValueUpTo { get; set; }
        public long? NumberOfApprovers { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string? UpdatedUser { get; set; }
    }
}
