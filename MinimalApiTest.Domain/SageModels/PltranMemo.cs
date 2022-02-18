using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class PltranMemo
    {
        public long PltranMemoId { get; set; }
        public long PlpostedSupplierTranId { get; set; }
        public string MemoText { get; set; } = null!;
        public string MemoCreatedBy { get; set; } = null!;
        public DateTime TimeAndDateMemoCreated { get; set; }
        public bool Active { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public DateTime TimeAndDateMemoLastUpdated { get; set; }
        public DateTime DateTimeUpdated { get; set; }

        public virtual PlpostedSupplierTran PlpostedSupplierTran { get; set; } = null!;
    }
}
