using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconJcdesktopView
    {
        public long? Id { get; set; }
        public long Sijcjobid { get; set; }
        public string? Jobnumber { get; set; }
        public string? Description { get; set; }
        public string? Jcstatus { get; set; }
        public decimal? Percentagecomplete { get; set; }
        public string? Jobmanager { get; set; }
        public long? TraderAccountId { get; set; }
        public string CustomerReference { get; set; } = null!;
        public string? Customername { get; set; }
        public string? Analysistype1 { get; set; }
        public string? Analysistype2 { get; set; }
        public string? Analysistype3 { get; set; }
        public string? Analysistype4 { get; set; }
        public string? Analysistype5 { get; set; }
        public string? AnalysisType6 { get; set; }
        public string? AnalysisType7 { get; set; }
        public DateTime? Plancompdate { get; set; }
        public string? LastC2cbyUser { get; set; }
        public DateTime? LastC2cdateTime { get; set; }
        public bool? ExcludeFromJobList { get; set; }
        public DateTime? ActualCompDate { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? JobCreatedDateTime { get; set; }
        public string PaidStatus { get; set; } = null!;
        public decimal BudgetRevenue { get; set; }
        public decimal CommittedRevenue { get; set; }
        public decimal ActualRevenue { get; set; }
        public decimal? TotalRevenue { get; set; }
        public decimal BudgetCost { get; set; }
        public decimal CommittedCost { get; set; }
        public decimal ActualCost { get; set; }
        public decimal? TotalCost { get; set; }
        public decimal? BudgetProfit { get; set; }
        public decimal? ActualProfit { get; set; }
        public decimal? RevenueVariance { get; set; }
        public decimal? CostVariance { get; set; }
        public decimal? BudgetComplete { get; set; }
        public decimal? ActualComplete { get; set; }
        public decimal? TotalCompletePc { get; set; }
        public decimal RevisedCost { get; set; }
        public decimal RevisedRevenue { get; set; }
        public string LastRevisedCostInPeriod { get; set; } = null!;
        public string LastRevisedRevenueInPeriod { get; set; } = null!;
        public decimal Applications { get; set; }
        public decimal Valuations { get; set; }
        public decimal Retentions { get; set; }
        public int LastC2cperiodId { get; set; }
        public string LastC2cperiodString { get; set; } = null!;
        public string LastRevisedInPeriod { get; set; } = null!;
        public decimal? TotalProfit { get; set; }
    }
}
