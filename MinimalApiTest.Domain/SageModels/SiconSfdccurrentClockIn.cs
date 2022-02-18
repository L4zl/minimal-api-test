using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconSfdccurrentClockIn
    {
        public DateTime? StartTime { get; set; }
        public string? FirstName { get; set; }
        public string? Surname { get; set; }
        public DateTime? EndTime { get; set; }
        public string DayOfWeekName { get; set; } = null!;
        public long SiJcEmpId { get; set; }
    }
}
