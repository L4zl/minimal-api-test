using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class TransactionGroup
    {
        public TransactionGroup()
        {
            TransactionTypes = new HashSet<TransactionType>();
        }

        public long TransactionGroupId { get; set; }
        public string TransactionGroupName { get; set; } = null!;

        public virtual ICollection<TransactionType> TransactionTypes { get; set; }
    }
}
