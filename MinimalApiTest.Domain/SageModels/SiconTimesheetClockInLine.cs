using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconTimesheetClockInLine
    {
        public long SiconTimesheetClockInLineId { get; set; }
        public long? SiconTimesheetId { get; set; }
        public long? SiconTimesheetLocationId { get; set; }
        public long? SiconTimesheetLeavingReasonId { get; set; }
        public bool Deleted { get; set; }
        public string LastUpdatedByUserId { get; set; } = null!;
        public DateTime? LastUpdatedDateTime { get; set; }
    }
}
