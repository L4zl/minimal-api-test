using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class RtltraceableDispatchBreakup
    {
        public long DispatchBrkId { get; set; }
        public long? DispatchId { get; set; }
        public long? PrdHierNodeId { get; set; }
        public decimal? Quantity { get; set; }
        public string? PickListRef { get; set; }
        public string? StockItemCode { get; set; }
        public string? IdentificationNo { get; set; }
        public long? TraceableItemStatusId { get; set; }
        public long? StockItemId { get; set; }
        public long? TraceableItemId { get; set; }
    }
}
