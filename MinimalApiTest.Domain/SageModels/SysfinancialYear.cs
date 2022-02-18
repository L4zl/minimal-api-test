using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SysfinancialYear
    {
        public SysfinancialYear()
        {
            NlaccountYearValues = new HashSet<NlaccountYearValue>();
            NlcashFlowReportPeriodHeadings = new HashSet<NlcashFlowReportPeriodHeading>();
            NlcashFlowReports = new HashSet<NlcashFlowReport>();
            NlreportCategoryBudgetYearValues = new HashSet<NlreportCategoryBudgetYearValue>();
            PlsupplierYearValues = new HashSet<PlsupplierYearValue>();
            SlcustomerYearValues = new HashSet<SlcustomerYearValue>();
            SysaccountingPeriods = new HashSet<SysaccountingPeriod>();
        }

        public long SysfinancialYearId { get; set; }
        public DateTime FinancialYearStartDate { get; set; }
        public int YearRelativeToCurrentYear { get; set; }
        public short NumberOfPeriodsInYear { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public DateTime DateTimeUpdated { get; set; }

        public virtual ICollection<NlaccountYearValue> NlaccountYearValues { get; set; }
        public virtual ICollection<NlcashFlowReportPeriodHeading> NlcashFlowReportPeriodHeadings { get; set; }
        public virtual ICollection<NlcashFlowReport> NlcashFlowReports { get; set; }
        public virtual ICollection<NlreportCategoryBudgetYearValue> NlreportCategoryBudgetYearValues { get; set; }
        public virtual ICollection<PlsupplierYearValue> PlsupplierYearValues { get; set; }
        public virtual ICollection<SlcustomerYearValue> SlcustomerYearValues { get; set; }
        public virtual ICollection<SysaccountingPeriod> SysaccountingPeriods { get; set; }
    }
}
