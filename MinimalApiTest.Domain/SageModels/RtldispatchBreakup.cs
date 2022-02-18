using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class RtldispatchBreakup
    {
        public long DispatchBrkId { get; set; }
        public long? DispatchId { get; set; }
        public long? PrdHierNodeId { get; set; }
        public decimal Quantity { get; set; }
        public string? PickListRef { get; set; }
        public string? StockItemCode { get; set; }
        public DateTime DateTimeCreated { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public string? WarehouseName { get; set; }
        public string? BinName { get; set; }
        public long? HistoryId { get; set; }
        public DateTime DateTimeUpdated { get; set; }
    }
}
