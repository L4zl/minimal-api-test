using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class NlfinancialReportLineType
    {
        public NlfinancialReportLineType()
        {
            NlfinancialReportRows = new HashSet<NlfinancialReportRow>();
        }

        public long NlfinancialReportLineTypeId { get; set; }
        public string Name { get; set; } = null!;

        public virtual ICollection<NlfinancialReportRow> NlfinancialReportRows { get; set; }
    }
}
