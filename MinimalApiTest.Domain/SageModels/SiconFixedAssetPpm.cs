using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconFixedAssetPpm
    {
        public long SiconFixedAssetPpmid { get; set; }
        public DateTime? MaintenanceDate { get; set; }
        public string? CompletedBy { get; set; }
        public string? DocumentName { get; set; }
        public long FixedAssetId { get; set; }
    }
}
