using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class NlfinancialReportCategory
    {
        public long NlfinancialReportCategoryId { get; set; }
        public long NlaccountReportTypeId { get; set; }
        public long NlfinancialReportRowId { get; set; }
        public long NlaccountReportCategoryId { get; set; }
        public DateTime DateTimeCreated { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeUpdated { get; set; }

        public virtual NlaccountReportCategory NlaccountReportCategory { get; set; } = null!;
        public virtual NlaccountReportType NlaccountReportType { get; set; } = null!;
        public virtual NlfinancialReportRow NlfinancialReportRow { get; set; } = null!;
    }
}
