using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconFixedAssetPeriodView
    {
        public long? SysaccountingPeriodId { get; set; }
        public long FixedAssetId { get; set; }
        public string? Code { get; set; }
        public decimal? Depreciation { get; set; }
        public decimal? DepreciationYearToDate { get; set; }
        public decimal? Addition { get; set; }
        public decimal? AdditionYearToDate { get; set; }
        public decimal? Disposal { get; set; }
        public decimal? DisposalYearToDate { get; set; }
        public DateTime? DateTimePosted { get; set; }
    }
}
