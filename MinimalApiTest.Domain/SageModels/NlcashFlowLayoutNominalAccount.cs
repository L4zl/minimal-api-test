using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class NlcashFlowLayoutNominalAccount
    {
        public long NlcashFlowLayoutNominalAccountId { get; set; }
        public long NlfinancialReportLayoutId { get; set; }
        public long NlnominalAccountId { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public DateTime DateTimeUpdated { get; set; }

        public virtual NlnominalAccount NlnominalAccount { get; set; } = null!;
    }
}
