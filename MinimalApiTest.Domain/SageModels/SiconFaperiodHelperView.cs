using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconFaperiodHelperView
    {
        public int SiconFixedAssetPeriodId { get; set; }
        public long? SysaccountingPeriodId { get; set; }
        public long FixedAssetId { get; set; }
        public decimal? Depreciation { get; set; }
        public decimal? CostAddition { get; set; }
        public decimal? CostDisposal { get; set; }
        public int? DateTimePosted { get; set; }
        public decimal? DepreciationDisposal { get; set; }
        public decimal? CostOpeningBalance { get; set; }
        public decimal? CostClosingBalance { get; set; }
        public decimal? DepreciationOpeningBalance { get; set; }
        public decimal? DepreciationClosingBalance { get; set; }
        public decimal? NbvopeningBalance { get; set; }
        public decimal? NbvclosingBalance { get; set; }
    }
}
