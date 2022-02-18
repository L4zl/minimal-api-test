using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class NlreportCategoryYearBudgetsView
    {
        public long NlreportCategoryBudgetId { get; set; }
        public string BudgetName { get; set; } = null!;
        public decimal? PreviousYearBudget { get; set; }
        public decimal? CurrentYearBudget { get; set; }
        public decimal? CurrentYearPlus1Budget { get; set; }
        public decimal? CurrentYearPlus2Budget { get; set; }
        public decimal? CurrentYearPlus3Budget { get; set; }
        public decimal? CurrentYearPlus4Budget { get; set; }
        public decimal? CurrentYearPlus5Budget { get; set; }
        public decimal? PreviousYearAllocated { get; set; }
        public decimal? CurrentYearAllocated { get; set; }
        public decimal? CurrentYearPlus1Allocated { get; set; }
        public decimal? CurrentYearPlus2Allocated { get; set; }
        public decimal? CurrentYearPlus3Allocated { get; set; }
        public decimal? CurrentYearPlus4Allocated { get; set; }
        public decimal? CurrentYearPlus5Allocated { get; set; }
    }
}
