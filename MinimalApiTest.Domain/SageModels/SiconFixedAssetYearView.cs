using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconFixedAssetYearView
    {
        public long? SysfinancialYearId { get; set; }
        public long FixedAssetId { get; set; }
        public string? Code { get; set; }
        public decimal? Depreciation { get; set; }
        public decimal? Addition { get; set; }
        public decimal? Disposal { get; set; }
    }
}
