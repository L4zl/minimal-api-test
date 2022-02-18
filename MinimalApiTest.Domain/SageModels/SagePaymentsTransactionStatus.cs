using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SagePaymentsTransactionStatus
    {
        public SagePaymentsTransactionStatus()
        {
            CbpostedAccountTrans = new HashSet<CbpostedAccountTran>();
        }

        public long SagePaymentsTransactionStatusId { get; set; }
        public string Name { get; set; } = null!;
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public DateTime DateTimeUpdated { get; set; }

        public virtual ICollection<CbpostedAccountTran> CbpostedAccountTrans { get; set; }
    }
}
