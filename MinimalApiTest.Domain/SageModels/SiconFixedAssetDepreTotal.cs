using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconFixedAssetDepreTotal
    {
        public long SiconFixedAssetDepreTotalId { get; set; }
        public long FixedAssetId { get; set; }
        public long? SysfinancialYearId { get; set; }
        public decimal? DepreciationTotal { get; set; }
    }
}
