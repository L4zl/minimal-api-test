using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconAllocationForeignLineAllocatedQtyView
    {
        public long? ForeignId { get; set; }
        public long? TypeId { get; set; }
        public decimal? QuantityAllocated { get; set; }
    }
}
