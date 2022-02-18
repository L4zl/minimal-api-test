using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconConstructionMi
    {
        public long SiconConstructionMiid { get; set; }
        public long SiJcJobId { get; set; }
        public long SysaccountingPeriodId { get; set; }
        public decimal? CostAccrual1 { get; set; }
        public decimal? CostAccrual2 { get; set; }
        public decimal? CostAccrual3 { get; set; }
        public decimal? CostAccrual4 { get; set; }
        public decimal? CostAccrual5 { get; set; }
        public decimal? RevenueAccrual1 { get; set; }
        public decimal? RevenueAccrual2 { get; set; }
        public decimal? RevenueAccrual3 { get; set; }
        public decimal? RevenueAccrual4 { get; set; }
        public decimal? RevenueAccrual5 { get; set; }
        public decimal? ValuationOfWork { get; set; }
        public bool? Posted { get; set; }
        public string? CostAccrual1Note { get; set; }
        public string? CostAccrual2Note { get; set; }
        public string? CostAccrual3Note { get; set; }
        public string? CostAccrual4Note { get; set; }
        public string? CostAccrual5Note { get; set; }
        public string? RevenueAccrual1Note { get; set; }
        public string? RevenueAccrual2Note { get; set; }
        public string? RevenueAccrual3Note { get; set; }
        public string? RevenueAccrual4Note { get; set; }
        public string? RevenueAccrual5Note { get; set; }
    }
}
