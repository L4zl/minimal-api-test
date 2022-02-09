namespace MinimalApiTest.Domain.Models
{
    public partial class HremployeeSalary
    {
        public long HremployeeSalaryId { get; set; }
        public long? UserId { get; set; }
        public decimal? DefaultHrsNo { get; set; }
        public decimal? DefaultRateAmt { get; set; }
        public decimal? HrsNoCur { get; set; }
        public decimal? HrsNoHol { get; set; }
        public decimal? RateAmtCur { get; set; }
        public decimal? RateAmtHol { get; set; }
        public decimal? AmtCur { get; set; }
        public decimal? AmtHol { get; set; }
        public decimal? AmtTotal { get; set; }
        public decimal? DefaultFactorMultiplier { get; set; }
        public decimal? FactorMultiplierCur { get; set; }
        public decimal? FactorMultiplierHol { get; set; }
        public bool? InUse { get; set; }
        public bool? Deleted { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string? UpdatedUser { get; set; }
    }
}
