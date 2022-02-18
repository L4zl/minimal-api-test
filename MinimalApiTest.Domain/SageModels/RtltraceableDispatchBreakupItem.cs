using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class RtltraceableDispatchBreakupItem
    {
        public long RtltraceableDispatchBreakupItemId { get; set; }
        public long RtldispatchBrkId { get; set; }
        public decimal? Quantity { get; set; }
        public string? IdentificationNo { get; set; }
        public long? TraceableItemStatusId { get; set; }
        public long? StockItemId { get; set; }
    }
}
