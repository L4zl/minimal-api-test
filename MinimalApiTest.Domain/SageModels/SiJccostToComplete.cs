using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiJccostToComplete
    {
        public long SiJccostToCompleteId { get; set; }
        public long? SiJcJobId { get; set; }
        public long? SiJcChdId { get; set; }
        public decimal? CostToComplete { get; set; }
        public decimal? HoursToComplete { get; set; }
        public decimal? TotalToComplete { get; set; }
        public bool? IsCurrent { get; set; }
        public string? ReasonForChange { get; set; }
        public int? Period { get; set; }
        public int? PeriodYear { get; set; }
        public DateTime? PeriodEndDate { get; set; }
        public long? SysaccountingPeriodId { get; set; }
        public string? LastUpdatedByUser { get; set; }
        public DateTime? LastUpdatedDateTime { get; set; }
        public string? RevisedBudgetType { get; set; }
        public int? Week { get; set; }
        public int? Year { get; set; }
        public long? SiJcPhaseId { get; set; }
        public long? SiJcStageId { get; set; }
        public long? SiJcActivityId { get; set; }
        public long? SiJcVariationId { get; set; }
        public bool? IsAccrualPosted { get; set; }
        public decimal? ExchangeRate { get; set; }
    }
}
