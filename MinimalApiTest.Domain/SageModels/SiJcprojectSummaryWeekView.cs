using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiJcprojectSummaryWeekView
    {
        public long Sijcjobid { get; set; }
        public string? JobNumber { get; set; }
        public string RevisedBudgetType { get; set; } = null!;
        public int Period { get; set; }
        public int PeriodYear { get; set; }
        public long SysAccountingPeriodId { get; set; }
        public int Week { get; set; }
        public int Year { get; set; }
        public string C2capplications { get; set; } = null!;
        public string C2cvaluations { get; set; } = null!;
        public string C2cinvoiced { get; set; } = null!;
        public string C2cretentions { get; set; } = null!;
        public decimal C2ctotalRevenue { get; set; }
        public decimal C2clabour { get; set; }
        public decimal C2cmaterial { get; set; }
        public decimal C2cplant { get; set; }
        public decimal C2csubcontract { get; set; }
        public decimal C2cother { get; set; }
        public decimal C2ctotalCosts { get; set; }
        public decimal? C2cmargin { get; set; }
        public decimal? C2cmarginPv { get; set; }
        public string BudApplications { get; set; } = null!;
        public string BudValuations { get; set; } = null!;
        public string BudInvoiced { get; set; } = null!;
        public string BudRetentions { get; set; } = null!;
        public decimal BudTotalRevenue { get; set; }
        public decimal BudLabour { get; set; }
        public decimal BudMaterial { get; set; }
        public decimal BudPlant { get; set; }
        public decimal BudSubcontract { get; set; }
        public decimal BudOther { get; set; }
        public decimal BudTotalCosts { get; set; }
        public decimal? BudMargin { get; set; }
        public decimal? BudMarginPv { get; set; }
        public decimal ActApplications { get; set; }
        public decimal ActValuations { get; set; }
        public decimal ActInvoiced { get; set; }
        public decimal ActRetentions { get; set; }
        public decimal? ActTotalRevenue { get; set; }
        public decimal ActLabour { get; set; }
        public decimal ActMaterial { get; set; }
        public decimal ActPlant { get; set; }
        public decimal ActSubcontract { get; set; }
        public decimal ActOther { get; set; }
        public decimal ActTotalCosts { get; set; }
        public decimal? ActMargin { get; set; }
        public decimal? ActMarginPv { get; set; }
        public string AccApplications { get; set; } = null!;
        public string AccValuations { get; set; } = null!;
        public string AccInvoiced { get; set; } = null!;
        public string AccRetentions { get; set; } = null!;
        public decimal AccTotalRevenue { get; set; }
        public decimal AccLabour { get; set; }
        public decimal AccMaterial { get; set; }
        public decimal AccPlant { get; set; }
        public decimal AccSubcontract { get; set; }
        public decimal AccOther { get; set; }
        public decimal? AccTotalCosts { get; set; }
        public decimal? AccMargin { get; set; }
        public decimal? AccMarginPv { get; set; }
        public int ComApplications { get; set; }
        public int ComValuations { get; set; }
        public decimal ComInvoiced { get; set; }
        public int ComRetentions { get; set; }
        public decimal ComTotalRevenue { get; set; }
        public decimal ComLabour { get; set; }
        public decimal ComMaterial { get; set; }
        public decimal ComPlant { get; set; }
        public decimal ComSubcontract { get; set; }
        public decimal ComOther { get; set; }
        public decimal ComTotalCosts { get; set; }
        public decimal? ComMargin { get; set; }
        public decimal? ComMarginPv { get; set; }
        public decimal Totapplications { get; set; }
        public decimal Totvaluations { get; set; }
        public decimal Totinvoiced { get; set; }
        public decimal Totretentions { get; set; }
        public decimal? TottotalRevenue { get; set; }
        public decimal Totlabour { get; set; }
        public decimal Totmaterial { get; set; }
        public decimal Totplant { get; set; }
        public decimal Totsubcontract { get; set; }
        public decimal Totother { get; set; }
        public decimal TottotalCosts { get; set; }
        public decimal? Totmargin { get; set; }
        public decimal? TotmarginPv { get; set; }
    }
}
