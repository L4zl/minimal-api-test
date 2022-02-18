using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconHmorderLineStockAlloc
    {
        public long SiconHmorderLineStockAllocId { get; set; }
        public long SiconHmorderLineStockLineId { get; set; }
        public long? AllocationId { get; set; }
        public long? AllocationTransactionHistoryId { get; set; }
        public decimal? QuantityAllocated { get; set; }
    }
}
