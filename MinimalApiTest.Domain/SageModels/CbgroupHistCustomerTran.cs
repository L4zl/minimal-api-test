using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class CbgroupHistCustomerTran
    {
        public long CbgroupHistCustomerTranId { get; set; }
        public long CbpostedAccountTranId { get; set; }
        public long SlhistoricalCustomerTranId { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public DateTime DateTimeUpdated { get; set; }

        public virtual CbpostedAccountTran CbpostedAccountTran { get; set; } = null!;
        public virtual SlhistoricalCustomerTran SlhistoricalCustomerTran { get; set; } = null!;
    }
}
