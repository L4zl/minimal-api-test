using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconConstTransByPeriodView
    {
        public long SiJcJobId { get; set; }
        public string? JobNumber { get; set; }
        public decimal? PercentageComplete { get; set; }
        public string? Description { get; set; }
        public decimal PeriodPercentComplete { get; set; }
        public string LastC2cperiodString { get; set; } = null!;
        public string? LastC2cbyUser { get; set; }
        public long? SysaccountingPeriodId { get; set; }
        public decimal? ActualSalesValue { get; set; }
        public decimal RevisedSalesValue { get; set; }
        public decimal? AccrualSalesValue { get; set; }
        public decimal? ActualCostValue { get; set; }
        public decimal RevisedCostValue { get; set; }
        public decimal? AccrualCostValue { get; set; }
        public string? AnalysisType1 { get; set; }
        public string? AnalysisType2 { get; set; }
        public string? AnalysisType3 { get; set; }
        public string? AnalysisType4 { get; set; }
        public string? AnalysisType5 { get; set; }
        public string? AnalysisType6 { get; set; }
        public string? AnalysisType7 { get; set; }
        public int? YearRelativeToCurrentYear { get; set; }
        public short? PeriodNumber { get; set; }
        public long? SysfinancialYearId { get; set; }
        public string? JobManager { get; set; }
    }
}
