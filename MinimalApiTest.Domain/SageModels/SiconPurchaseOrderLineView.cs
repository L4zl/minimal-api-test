using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconPurchaseOrderLineView
    {
        public long SiconPurchaseOrderLineId { get; set; }
        public long SiconPurchaseOrderId { get; set; }
        public decimal? LineTotal { get; set; }
        public decimal? OnApplicationTotal { get; set; }
        public decimal? Outstanding { get; set; }
    }
}
