using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class NlstatementLayout
    {
        public NlstatementLayout()
        {
            NlstatementLayoutRows = new HashSet<NlstatementLayoutRow>();
        }

        public long NlstatementLayoutId { get; set; }
        public string LayoutName { get; set; } = null!;
        public long NlaccountReportTypeId { get; set; }
        public bool DefaultLayout { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public DateTime DateTimeUpdated { get; set; }

        public virtual NlaccountReportType NlaccountReportType { get; set; } = null!;
        public virtual ICollection<NlstatementLayoutRow> NlstatementLayoutRows { get; set; }
    }
}
