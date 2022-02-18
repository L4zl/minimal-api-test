using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class NldefaultNominalAccount
    {
        public long NldefaultNominalAccountId { get; set; }
        public string Name { get; set; } = null!;
        public string? AccountNumber { get; set; }
        public long? NlaccountReportTypeId { get; set; }
        public DateTime DateTimeCreated { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public bool UseSpecified { get; set; }
        public long? NlnominalAccountId { get; set; }
        public bool UsedInStandard { get; set; }
        public DateTime DateTimeUpdated { get; set; }

        public virtual NlaccountReportType? NlaccountReportType { get; set; }
        public virtual NlnominalAccount? NlnominalAccount { get; set; }
    }
}
