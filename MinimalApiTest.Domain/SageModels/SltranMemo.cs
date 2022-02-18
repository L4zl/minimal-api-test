using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SltranMemo
    {
        public long SltranMemoId { get; set; }
        public long SlpostedCustomerTranId { get; set; }
        public DateTime TimeAndDateMemoCreated { get; set; }
        public string MemoCreatedBy { get; set; } = null!;
        public string MemoText { get; set; } = null!;
        public bool Active { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public DateTime TimeAndDateMemoLastUpdated { get; set; }
        public DateTime DateTimeUpdated { get; set; }

        public virtual SlpostedCustomerTran SlpostedCustomerTran { get; set; } = null!;
    }
}
