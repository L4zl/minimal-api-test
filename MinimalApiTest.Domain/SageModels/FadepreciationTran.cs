using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class FadepreciationTran
    {
        public long FadepreciationTranId { get; set; }
        public long FaassetId { get; set; }
        public DateTime TransactionDate { get; set; }
        public long FaassetTransactionTypeId { get; set; }
        public decimal OldValue { get; set; }
        public decimal NewValue { get; set; }
        public decimal PostingValue { get; set; }
        public long? SysaccountingPeriodId { get; set; }
        public long Urn { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public string UserName { get; set; } = null!;
        public int UserNumber { get; set; }
        public DateTime DateTimeUpdated { get; set; }

        public virtual Faasset Faasset { get; set; } = null!;
        public virtual FaassetTransactionType FaassetTransactionType { get; set; } = null!;
        public virtual SysaccountingPeriod? SysaccountingPeriod { get; set; }
    }
}
