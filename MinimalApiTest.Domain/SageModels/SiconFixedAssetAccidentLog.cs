using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconFixedAssetAccidentLog
    {
        public long SiconFixedAssetAccidentLogId { get; set; }
        public long FixedAssetId { get; set; }
        public DateTime? AccidentDate { get; set; }
        public string Description { get; set; } = null!;
    }
}
