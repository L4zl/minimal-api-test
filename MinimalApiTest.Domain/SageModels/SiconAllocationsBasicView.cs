using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconAllocationsBasicView
    {
        public long? ForeignId { get; set; }
        public long? TypeId { get; set; }
        public long? BinItemId { get; set; }
        public string BinName { get; set; } = null!;
        public decimal AllocatedQuantity { get; set; }
        public long AllocationId { get; set; }
    }
}
