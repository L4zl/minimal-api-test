using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconJccostToCompleteView
    {
        public long SiJccostToCompleteId { get; set; }
        public string? RevisedBudgetType { get; set; }
        public int? Period { get; set; }
        public int? PeriodYear { get; set; }
        public int Week { get; set; }
        public int Year { get; set; }
        public long? SysaccountingPeriodId { get; set; }
        public long Sijcjobid { get; set; }
        public string? JobNumber { get; set; }
        public long Sijcchdid { get; set; }
        public string? CostCode { get; set; }
        public string? Description { get; set; }
        public string? HeaderType { get; set; }
        public string JobItemTypeCode { get; set; } = null!;
        public int SijcvariationId { get; set; }
        public string VariationDescription { get; set; } = null!;
        public long? SijcphaseId { get; set; }
        public string? PhaseDescription { get; set; }
        public long? SijcstageId { get; set; }
        public string? StageDescription { get; set; }
        public long? SijcactivityId { get; set; }
        public string? ActivityDescription { get; set; }
        public decimal OriginalBudget { get; set; }
        public decimal Budget { get; set; }
        public decimal PeriodBudget { get; set; }
        public decimal BudgetHours { get; set; }
        public decimal Planned { get; set; }
        public decimal? Variance { get; set; }
        public decimal Committed { get; set; }
        public decimal Actual { get; set; }
        public decimal? TotalCost { get; set; }
        public decimal? CostToComplete { get; set; }
        public decimal? HoursToComplete { get; set; }
        public decimal? TotalRevisedCost { get; set; }
        public int PreviousDifference { get; set; }
        public string? ReasonForChange { get; set; }
        public bool? IsAccrualPosted { get; set; }
        public string? LastRevisedIn { get; set; }
        public int IsLatest { get; set; }
        public DateTime? LastRevisedOnDateTime { get; set; }
        public string? LastRevisedByUser { get; set; }
        public DateTime? EndDate { get; set; }
        public DateTime? CurrantEndDate { get; set; }
        public decimal CurrentRevisedBudget { get; set; }
        public DateTime? DateLink { get; set; }
        public decimal ExchangeRate { get; set; }
    }
}
