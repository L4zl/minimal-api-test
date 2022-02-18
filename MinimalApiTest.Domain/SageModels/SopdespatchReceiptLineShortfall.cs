using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SopdespatchReceiptLineShortfall
    {
        public long SopdespatchReceiptLineShortfallId { get; set; }
        public long SopdespatchReceiptLineId { get; set; }
        public long MovementBalanceId { get; set; }
        public decimal Quantity { get; set; }
        public DateTime DateTimeCreated { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeUpdated { get; set; }

        public virtual MovementBalance MovementBalance { get; set; } = null!;
        public virtual SopdespatchReceiptLine SopdespatchReceiptLine { get; set; } = null!;
    }
}
