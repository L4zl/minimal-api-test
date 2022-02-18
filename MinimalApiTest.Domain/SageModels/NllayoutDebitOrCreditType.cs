using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class NllayoutDebitOrCreditType
    {
        public NllayoutDebitOrCreditType()
        {
            NlfinancialReportRows = new HashSet<NlfinancialReportRow>();
            NlstatementLayoutRows = new HashSet<NlstatementLayoutRow>();
        }

        public long NllayoutDebitOrCreditTypeId { get; set; }
        public string Name { get; set; } = null!;

        public virtual ICollection<NlfinancialReportRow> NlfinancialReportRows { get; set; }
        public virtual ICollection<NlstatementLayoutRow> NlstatementLayoutRows { get; set; }
    }
}
