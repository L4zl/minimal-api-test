using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class RtlstockBinItem
    {
        public long Sibid { get; set; }
        public long PrdHierNodeId { get; set; }
        public string WarehouseCode { get; set; } = null!;
        public string? Bin { get; set; }
        public decimal? ReOrderAmount { get; set; }
        public decimal? MinimumAmount { get; set; }
        public decimal? MaximumAmount { get; set; }
        public DateTime DateTimeCreated { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public long AllocationPriority { get; set; }
        public DateTime DateTimeUpdated { get; set; }
    }
}
