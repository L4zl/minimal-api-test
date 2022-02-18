using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class Syscorrection
    {
        public long SyscorrectionId { get; set; }
        public long OriginalUrn { get; set; }
        public long ReversalUrn { get; set; }
        public long NewUrn { get; set; }
        public long Source { get; set; }
        public long? SystraderTranTypeId { get; set; }
        public long? NlnominalTranTypeId { get; set; }
        public DateTime OriginalTransactionDate { get; set; }
        public DateTime TransactionDate { get; set; }
        public int UserNumber { get; set; }
        public string UserName { get; set; } = null!;
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public DateTime DateTimeUpdated { get; set; }

        public virtual NlnominalTranType? NlnominalTranType { get; set; }
        public virtual SystraderTranType? SystraderTranType { get; set; }
    }
}
