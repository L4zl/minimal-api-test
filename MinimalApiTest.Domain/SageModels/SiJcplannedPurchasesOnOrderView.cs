using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiJcplannedPurchasesOnOrderView
    {
        public long? SiJcPlannedPurchaseId { get; set; }
        public decimal OnOrderQty { get; set; }
        public decimal? OnOrderUnit { get; set; }
        public decimal OnOrderTotal { get; set; }
    }
}
