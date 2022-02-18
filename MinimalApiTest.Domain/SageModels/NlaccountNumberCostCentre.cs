using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class NlaccountNumberCostCentre
    {
        public NlaccountNumberCostCentre()
        {
            NlnominalAccounts = new HashSet<NlnominalAccount>();
        }

        public long NlaccountNumberCostCentreId { get; set; }
        public long NlaccountNumberId { get; set; }
        public long NlcostCentreId { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public DateTime DateTimeUpdated { get; set; }

        public virtual NlaccountNumber NlaccountNumber { get; set; } = null!;
        public virtual NlcostCentre NlcostCentre { get; set; } = null!;
        public virtual ICollection<NlnominalAccount> NlnominalAccounts { get; set; }
    }
}
