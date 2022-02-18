using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class RtlstockItemMemo
    {
        public long RtlstockItemMemoId { get; set; }
        public long RtlstockItemId { get; set; }
        public string MemoText { get; set; } = null!;
        public string MemoCreatedBy { get; set; } = null!;
        public DateTime TimeAndDateMemoCreated { get; set; }
        public bool Active { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public DateTime DateTimeUpdated { get; set; }
    }
}
