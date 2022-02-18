using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconHmassetQuantityView
    {
        public long FixedAssetId { get; set; }
        public string? Code { get; set; }
        public decimal? FixedAssetQuantity { get; set; }
        public decimal? QuantityAllocatedNotReceived { get; set; }
        public int? AllocatedNotReceivedLineItemCount { get; set; }
    }
}
