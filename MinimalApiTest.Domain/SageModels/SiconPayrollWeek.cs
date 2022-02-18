using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconPayrollWeek
    {
        public long SiconPayrollWeekId { get; set; }
        public long? SysfinancialYearId { get; set; }
        public int? WeekNumber { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string? UpdatedUser { get; set; }
        public DateTime? UpdatedDate { get; set; }
    }
}
