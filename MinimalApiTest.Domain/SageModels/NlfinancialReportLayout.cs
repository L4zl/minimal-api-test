using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class NlfinancialReportLayout
    {
        public NlfinancialReportLayout()
        {
            NlfinancialReportRows = new HashSet<NlfinancialReportRow>();
        }

        public long NlfinancialReportLayoutId { get; set; }
        public long NlaccountReportTypeId { get; set; }
        public string Name { get; set; } = null!;
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public int BudgetShift { get; set; }
        public bool SystemReport { get; set; }
        public DateTime DateTimeUpdated { get; set; }

        public virtual NlaccountReportType NlaccountReportType { get; set; } = null!;
        public virtual ICollection<NlfinancialReportRow> NlfinancialReportRows { get; set; }
    }
}
