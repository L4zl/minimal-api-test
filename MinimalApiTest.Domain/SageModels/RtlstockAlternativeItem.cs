using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class RtlstockAlternativeItem
    {
        public long SialtId { get; set; }
        public long PrdHierNodeId { get; set; }
        public string? AltStockItemCode { get; set; }
        public bool IsPreferred { get; set; }
        public DateTime DateTimeCreated { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeUpdated { get; set; }
    }
}
