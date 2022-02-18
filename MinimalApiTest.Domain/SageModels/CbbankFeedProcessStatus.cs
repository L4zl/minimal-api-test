using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class CbbankFeedProcessStatus
    {
        public CbbankFeedProcessStatus()
        {
            CbbankFeedTransactions = new HashSet<CbbankFeedTransaction>();
        }

        public long CbbankFeedProcessStatusId { get; set; }
        public string Name { get; set; } = null!;

        public virtual ICollection<CbbankFeedTransaction> CbbankFeedTransactions { get; set; }
    }
}
