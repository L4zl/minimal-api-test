using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class NllayoutPositionType
    {
        public NllayoutPositionType()
        {
            NlfinancialReportRows = new HashSet<NlfinancialReportRow>();
        }

        public long NllayoutPositionTypeId { get; set; }
        public string Name { get; set; } = null!;

        public virtual ICollection<NlfinancialReportRow> NlfinancialReportRows { get; set; }
    }
}
