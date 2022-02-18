using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconTimesheetLineHourBreak
    {
        public long SiconTimesheetLineHourBreakId { get; set; }
        public long? SiconTimesheetLineBreakId { get; set; }
        public int DayOfWeekNumber { get; set; }
        public string DayOfWeekName { get; set; } = null!;
        public string HoursString { get; set; } = null!;
        public decimal HoursDecimal { get; set; }
        public DateTime? StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        public string Notes { get; set; } = null!;
        public bool Deleted { get; set; }
        public string LastUpdatedByUser { get; set; } = null!;
        public DateTime? LastUpdatedDateTime { get; set; }
    }
}
