using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class TraceableMovementBal
    {
        public long TraceableMovementBalId { get; set; }
        public long TraceableBinItemId { get; set; }
        public long MovementBalanceId { get; set; }
        public decimal StockLevelIssued { get; set; }
        public decimal OpeningStockLevel { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public DateTime DateTimeUpdated { get; set; }

        public virtual MovementBalance MovementBalance { get; set; } = null!;
        public virtual TraceableBinItem TraceableBinItem { get; set; } = null!;
    }
}
