using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconDashboardActiveClockIn
    {
        public long SiJcEmpId { get; set; }
        public string? FirstName { get; set; }
        public string? Surname { get; set; }
        public string? Deleted { get; set; }
        public DateTime? WeekStartDate { get; set; }
        public DateTime? EndTime { get; set; }
        public DateTime? StartTime { get; set; }
        public string DayOfWeekName { get; set; } = null!;
    }
}
