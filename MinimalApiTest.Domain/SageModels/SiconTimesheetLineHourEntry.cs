using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconTimesheetLineHourEntry
    {
        public long SiconTimesheetLineHourEntryId { get; set; }
        public long? SiconTimesheetLineEntryId { get; set; }
        public short DayOfWeekNumber { get; set; }
        public string DayOfWeekName { get; set; } = null!;
        public string HoursString { get; set; } = null!;
        public decimal HoursDecimal { get; set; }
        public DateTime? StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        public string Notes { get; set; } = null!;
        public long? PostedTransactionId { get; set; }
        public bool Deleted { get; set; }
        public string LastUpdatedByUser { get; set; } = null!;
        public DateTime? LastUpdatedDateTime { get; set; }
    }
}
