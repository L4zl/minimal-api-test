using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class NlnominalAccountBudgetsVw
    {
        public long NlnominalAccountId { get; set; }
        public long NlaccountTypeId { get; set; }
        public string? AccountNumber { get; set; }
        public string? CostCentre { get; set; }
        public string? Department { get; set; }
        public string Name { get; set; } = null!;
        public long? NlreportCategoryBudgetId { get; set; }
        public long? NlaccountReportCategoryId { get; set; }
        public string ReportCategory { get; set; } = null!;
        public decimal? PreviousYear { get; set; }
        public decimal? CurrentYear { get; set; }
        public decimal? CurrentYearPlus1 { get; set; }
        public decimal? CurrentYearPlus2 { get; set; }
        public decimal? CurrentYearPlus3 { get; set; }
        public decimal? CurrentYearPlus4 { get; set; }
        public decimal? CurrentYearPlus5 { get; set; }
        public long SysaccountStatusId { get; set; }
    }
}
