using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class RtlpromoProduct
    {
        public long PromoPrdId { get; set; }
        public long PromoId { get; set; }
        public long PrdHierNodeId { get; set; }
        public string SageStockItemCode { get; set; } = null!;
        public int? ThresholdValue { get; set; }
        public DateTime DateTimeCreated { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeUpdated { get; set; }
    }
}
