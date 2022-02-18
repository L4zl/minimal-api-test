using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class CbgroupPostedCustomerTran
    {
        public long CbgroupPostedCustomerTranId { get; set; }
        public long CbpostedAccountTranId { get; set; }
        public long SlpostedCustomerTranId { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public DateTime DateTimeUpdated { get; set; }

        public virtual CbpostedAccountTran CbpostedAccountTran { get; set; } = null!;
        public virtual SlpostedCustomerTran SlpostedCustomerTran { get; set; } = null!;
    }
}
