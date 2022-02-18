using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SlcustomerSyncStatusType
    {
        public SlcustomerSyncStatusType()
        {
            SlcustomerAccounts = new HashSet<SlcustomerAccount>();
        }

        public long SlcustomerSyncStatusTypeId { get; set; }
        public string Name { get; set; } = null!;

        public virtual ICollection<SlcustomerAccount> SlcustomerAccounts { get; set; }
    }
}
