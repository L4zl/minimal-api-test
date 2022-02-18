﻿using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class TraceSopdespRcptLine
    {
        public long TraceSopdespRcptLineId { get; set; }
        public long SopdespatchReceiptLineId { get; set; }
        public long TraceableBinItemId { get; set; }
        public decimal Quantity { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public DateTime DateTimeUpdated { get; set; }

        public virtual SopdespatchReceiptLine SopdespatchReceiptLine { get; set; } = null!;
        public virtual TraceableBinItem TraceableBinItem { get; set; } = null!;
    }
}
