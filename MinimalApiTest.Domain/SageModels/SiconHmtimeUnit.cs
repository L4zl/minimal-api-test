using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconHmtimeUnit
    {
        public long SiconHmtimeUnitId { get; set; }
        public string? UnitSysName { get; set; }
        public string Name { get; set; } = null!;
        public bool? RoundingRuleActivated { get; set; }
        public int? DurationRoundingUnitId { get; set; }
        public string? LastUpdatedByUserId { get; set; }
        public DateTime? LastUpdatedDateTime { get; set; }
    }
}
