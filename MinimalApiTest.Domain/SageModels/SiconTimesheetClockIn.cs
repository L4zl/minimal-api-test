using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconTimesheetClockIn
    {
        public long SiconTimesheetClockInId { get; set; }
        public long? SiconTimesheetClockInLineId { get; set; }
        public short DayOfWeekNumber { get; set; }
        public string DayOfWeekName { get; set; } = null!;
        public string HoursString { get; set; } = null!;
        public decimal HoursDecimal { get; set; }
        public DateTime? StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        public bool Deleted { get; set; }
        public string LastUpdatedByUserId { get; set; } = null!;
        public DateTime? LastUpdatedDateTime { get; set; }
    }
}
