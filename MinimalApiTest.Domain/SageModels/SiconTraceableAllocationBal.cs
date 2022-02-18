using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconTraceableAllocationBal
    {
        public long SiconTraceableAllocationBalId { get; set; }
        public long? TraceableBinItemId { get; set; }
        public long? TraceableItemId { get; set; }
        public long AllocationBalanceId { get; set; }
        public decimal? Quantity { get; set; }
        public long ForeignId { get; set; }
        public int AllocationTypeId { get; set; }
        public long BinItemId { get; set; }
        public string? Reference { get; set; }
    }
}
