using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class StockHistoryShortfall
    {
        public long StockHistoryShortfallId { get; set; }
        public long MovementBalanceId { get; set; }
        public long TransactionHistoryId { get; set; }
        public decimal Quantity { get; set; }
        public DateTime DateTimeCreated { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeUpdated { get; set; }

        public virtual MovementBalance MovementBalance { get; set; } = null!;
        public virtual TransactionHistory TransactionHistory { get; set; } = null!;
    }
}
