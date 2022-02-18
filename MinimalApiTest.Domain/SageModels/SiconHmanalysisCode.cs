using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconHmanalysisCode
    {
        public long SiconHmanalysisCodeId { get; set; }
        public string? Name { get; set; }
        public int? Sequence { get; set; }
        public bool? Enabled { get; set; }
        public bool? Mandatory { get; set; }
        public bool? MandatoryAtDespatch { get; set; }
        public bool? MandatoryAtReceive { get; set; }
        public string LastUpdatedByUserId { get; set; } = null!;
        public DateTime? LastUpdatedDateTime { get; set; }
    }
}
