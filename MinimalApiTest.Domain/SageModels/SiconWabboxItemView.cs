using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconWabboxItemView
    {
        public string IdentificationNo { get; set; } = null!;
        public string? SecondReference { get; set; }
        public int ShippingTypeId { get; set; }
        public string BinName { get; set; } = null!;
        public long? SiconWabboxItemId { get; set; }
        public long SiconWabboxId { get; set; }
        public decimal? Quantity { get; set; }
        public long? TraceableItemId { get; set; }
        public long? BinItemId { get; set; }
        public long? ItemId { get; set; }
        public long? PickAllocationId { get; set; }
        public long? ForeignId { get; set; }
    }
}
