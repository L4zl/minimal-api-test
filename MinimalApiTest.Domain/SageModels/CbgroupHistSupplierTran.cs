using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class CbgroupHistSupplierTran
    {
        public long CbgroupHistSupplierTranId { get; set; }
        public long CbpostedAccountTranId { get; set; }
        public long PlhistoricalSupplierTranId { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public DateTime DateTimeUpdated { get; set; }

        public virtual CbpostedAccountTran CbpostedAccountTran { get; set; } = null!;
        public virtual PlhistoricalSupplierTran PlhistoricalSupplierTran { get; set; } = null!;
    }
}
