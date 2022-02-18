using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class CbgroupPostedSupplierTran
    {
        public long CbgroupPostedSupplierTranId { get; set; }
        public long CbpostedAccountTranId { get; set; }
        public long PlpostedSupplierTranId { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public DateTime DateTimeUpdated { get; set; }

        public virtual CbpostedAccountTran CbpostedAccountTran { get; set; } = null!;
        public virtual PlpostedSupplierTran PlpostedSupplierTran { get; set; } = null!;
    }
}
