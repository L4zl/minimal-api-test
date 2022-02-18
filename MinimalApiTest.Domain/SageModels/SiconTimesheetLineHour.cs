using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconTimesheetLineHour
    {
        public long SiconTimesheetLineHourId { get; set; }
        public long? SiconTimesheetLineId { get; set; }
        public short DayOfWeekNumber { get; set; }
        public string DayOfWeekName { get; set; } = null!;
        public string HoursString { get; set; } = null!;
        public decimal HoursDecimal { get; set; }
        public DateTime? StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        public string Notes { get; set; } = null!;
        public long? PostedTransactionId { get; set; }
        public bool? HotUpdate { get; set; }
        public bool Deleted { get; set; }
        public string LastUpdatedByUserId { get; set; } = null!;
        public DateTime? LastUpdatedDateTime { get; set; }
    }
}
