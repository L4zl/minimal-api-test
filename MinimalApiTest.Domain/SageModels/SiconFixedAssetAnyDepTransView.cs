using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconFixedAssetAnyDepTransView
    {
        public long FixedAssetId { get; set; }
        public string? Code { get; set; }
        public int AnyDepreciationHistoryTransactions { get; set; }
    }
}
