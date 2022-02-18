using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconContractStockSopline
    {
        public long SiconContractStockSoplineId { get; set; }
        public long SoporderReturnLineId { get; set; }
        public long? LinkedSiconContractLineId { get; set; }
        public long? LinkedSoporderReturnLineId { get; set; }
    }
}
