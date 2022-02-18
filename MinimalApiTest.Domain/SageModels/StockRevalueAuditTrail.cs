using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class StockRevalueAuditTrail
    {
        public long StockRevalueAuditId { get; set; }
        public int UserNumber { get; set; }
        public string UserName { get; set; } = null!;
        public DateTime Date { get; set; }
        public long StockItemId { get; set; }
        public decimal OldValue { get; set; }
        public decimal NewValue { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public DateTime DateTimeUpdated { get; set; }

        public virtual StockItem StockItem { get; set; } = null!;
    }
}
