using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconJcestimatesDesktopView
    {
        public long Sijcjobid { get; set; }
        public string? Jobnumber { get; set; }
        public string? Description { get; set; }
        public string? Jcstatus { get; set; }
        public string? Jobmanager { get; set; }
        public string? Customername { get; set; }
        public string? Analysistype1 { get; set; }
        public string? Analysistype2 { get; set; }
        public string? Analysistype3 { get; set; }
        public string? Analysistype4 { get; set; }
        public string? Analysistype5 { get; set; }
        public string? AnalysisType6 { get; set; }
        public string? AnalysisType7 { get; set; }
        public decimal BudgetRevenue { get; set; }
        public decimal BudgetCost { get; set; }
        public decimal? BudgetProfit { get; set; }
    }
}
