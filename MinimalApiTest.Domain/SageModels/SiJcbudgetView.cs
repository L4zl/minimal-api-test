using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiJcbudgetView
    {
        public long SiJcBudId { get; set; }
        public long Sijcjobid { get; set; }
        public long Sijcchdid { get; set; }
        public int SiJcVariationId { get; set; }
        public long? SijobPhaseId { get; set; }
        public long? SijobStageId { get; set; }
        public long? SijobSubStageId { get; set; }
        public string? Jobnumber { get; set; }
        public string? Costcode { get; set; }
        public string? PhaseDescription { get; set; }
        public string? StageDescription { get; set; }
        public string? SubStageDescription { get; set; }
        public string Description { get; set; } = null!;
        public string? Headertype { get; set; }
        public string ProjectGroup { get; set; } = null!;
        public decimal? BudgetAmount { get; set; }
        public decimal? OriginalBudgetAmount { get; set; }
        public decimal? Committed { get; set; }
        public decimal? Actual { get; set; }
        public decimal Total { get; set; }
        public decimal? BudgetHours { get; set; }
        public decimal? OriginalBudgetHours { get; set; }
        public decimal ActualHours { get; set; }
        public decimal? HoursVariance { get; set; }
        public decimal? Variance { get; set; }
        public string? Jobitemtypecode { get; set; }
        public string? Costcodetype { get; set; }
        public string? BudgetType { get; set; }
        public decimal Planned { get; set; }
    }
}
