using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class FaassetTransactionType
    {
        public FaassetTransactionType()
        {
            FadepreciationTrans = new HashSet<FadepreciationTran>();
        }

        public long FaassetTransactionTypeId { get; set; }
        public string TransactionTypeName { get; set; } = null!;
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public DateTime DateTimeUpdated { get; set; }

        public virtual ICollection<FadepreciationTran> FadepreciationTrans { get; set; }
    }
}
