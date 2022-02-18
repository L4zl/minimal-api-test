using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconFaaccountingPeriod
    {
        public long SysfinancialYearId { get; set; }
        public int YearRelativeToCurrentYear { get; set; }
        public DateTime FinancialYearStartDate { get; set; }
        public short NumberOfPeriodsInYear { get; set; }
        public long SysaccountingPeriodId { get; set; }
        public short PeriodNumber { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
