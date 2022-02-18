using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiJcbudgetViewAll
    {
        public long? Id { get; set; }
        public string? JobNumber { get; set; }
        public string? Costcode { get; set; }
        public long Sijcjobid { get; set; }
        public long Sijcchdid { get; set; }
        public string? Description { get; set; }
        public string? Jobitemtypecode { get; set; }
        public string? Costcodetype { get; set; }
        public string? HeaderType { get; set; }
        public string ProjectGroup { get; set; } = null!;
        public string? BudgetType { get; set; }
        public decimal? BudgetAmount { get; set; }
        public decimal? OriginalBudgetAmount { get; set; }
        public decimal? OriginalBudgetHours { get; set; }
        public decimal? Planned { get; set; }
        public decimal? Actual { get; set; }
        public decimal? Committed { get; set; }
        public decimal? Total { get; set; }
        public decimal? Variance { get; set; }
        public decimal? BudgetHours { get; set; }
        public decimal? ActualHours { get; set; }
        public decimal? HoursVariance { get; set; }
    }
}
