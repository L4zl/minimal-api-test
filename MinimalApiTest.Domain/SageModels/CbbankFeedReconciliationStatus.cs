using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class CbbankFeedReconciliationStatus
    {
        public CbbankFeedReconciliationStatus()
        {
            CbbankFeedTransactions = new HashSet<CbbankFeedTransaction>();
        }

        public int CbbankFeedReconciliationStatusId { get; set; }
        public string Name { get; set; } = null!;

        public virtual ICollection<CbbankFeedTransaction> CbbankFeedTransactions { get; set; }
    }
}
