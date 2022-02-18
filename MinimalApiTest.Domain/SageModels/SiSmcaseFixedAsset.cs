using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiSmcaseFixedAsset
    {
        public long SiSmcaseFixedAssetId { get; set; }
        public long SiSmcaseId { get; set; }
        public long FixedAssetId { get; set; }
    }
}
