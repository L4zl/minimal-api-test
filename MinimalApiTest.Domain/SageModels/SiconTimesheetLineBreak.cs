using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconTimesheetLineBreak
    {
        public long SiconTimesheetLineBreakId { get; set; }
        public long? SiconTimesheet { get; set; }
        public long CostRateId { get; set; }
        public long ChargeRateId { get; set; }
        public long PayRateId { get; set; }
        public string Rate { get; set; } = null!;
        public bool Deleted { get; set; }
        public string LastUpdatedByUser { get; set; } = null!;
        public DateTime? LastUpdatedDateTime { get; set; }
    }
}
