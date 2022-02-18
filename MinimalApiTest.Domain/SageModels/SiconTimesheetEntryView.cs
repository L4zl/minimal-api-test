using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconTimesheetEntryView
    {
        public long SiconTimesheetLineHourId { get; set; }
        public DateTime? StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        public string Notes { get; set; } = null!;
        public decimal HoursDecimal { get; set; }
        public long SiconTimesheetLineId { get; set; }
        public long? SiconEmployeeId { get; set; }
        public long? SiconTimesheetLineStatusId { get; set; }
        public long? SiJcJobId { get; set; }
        public long? SiJcChdId { get; set; }
        public long? CostRateId { get; set; }
        public bool? Submitted { get; set; }
    }
}
