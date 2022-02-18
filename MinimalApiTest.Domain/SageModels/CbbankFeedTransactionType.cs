using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class CbbankFeedTransactionType
    {
        public CbbankFeedTransactionType()
        {
            CbbankFeedTransactions = new HashSet<CbbankFeedTransaction>();
        }

        public int CbbankFeedTransactionTypeId { get; set; }
        public string Name { get; set; } = null!;

        public virtual ICollection<CbbankFeedTransaction> CbbankFeedTransactions { get; set; }
    }
}
