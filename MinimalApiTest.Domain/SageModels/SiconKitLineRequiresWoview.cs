using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconKitLineRequiresWoview
    {
        public long SiconKitLineId { get; set; }
        public string KitReference { get; set; } = null!;
        public string ItemCode { get; set; } = null!;
        public decimal? Quantity { get; set; }
    }
}
