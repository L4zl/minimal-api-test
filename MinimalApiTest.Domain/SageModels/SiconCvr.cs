using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconCvr
    {
        public long SiconCvrid { get; set; }
        public long? SiJcJobId { get; set; }
        public long? SysaccountingPeriodId { get; set; }
        public decimal? Pccomplete { get; set; }
        public string? LastRevised { get; set; }
        public string? LastRevisedBy { get; set; }
        public decimal? PeractualSales { get; set; }
        public decimal? PeraccruedSales { get; set; }
        public decimal? PertotalSales { get; set; }
        public decimal? PeractualCosts { get; set; }
        public decimal? PeraccruedCosts { get; set; }
        public decimal? PertotalCosts { get; set; }
        public decimal? Peroverhead { get; set; }
        public decimal? Permargin { get; set; }
        public decimal? PermarginPc { get; set; }
        public decimal? YtdactualSales { get; set; }
        public decimal? YtdaccruedSales { get; set; }
        public decimal? YtdtotalSales { get; set; }
        public decimal? YtdactualCosts { get; set; }
        public decimal? YtdaccruedCosts { get; set; }
        public decimal? YtdtotalCosts { get; set; }
        public decimal? Ytdoverhead { get; set; }
        public decimal? Ytdmargin { get; set; }
        public decimal? YtdmarginPc { get; set; }
        public decimal? TotactualSales { get; set; }
        public decimal? TotaccruedSales { get; set; }
        public decimal? TottotalSales { get; set; }
        public decimal? TotactualCosts { get; set; }
        public decimal? TotaccruedCosts { get; set; }
        public decimal? TottotalCosts { get; set; }
        public decimal? Totoverhead { get; set; }
        public decimal? Totmargin { get; set; }
        public decimal? TotmarginPc { get; set; }
        public decimal? RevenueToCompletion { get; set; }
        public decimal? CostToCompletion { get; set; }
        public string? LastUpdateByUser { get; set; }
        public DateTime? LastUpdatedDateTime { get; set; }
    }
}
