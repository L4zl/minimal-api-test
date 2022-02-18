using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconContractOrderAllocLine
    {
        public long SiconContractOrderAllocLineId { get; set; }
        public long SiconContractEquipOrderLineId { get; set; }
        public long AllocationId { get; set; }
    }
}
