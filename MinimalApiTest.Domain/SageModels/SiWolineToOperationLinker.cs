using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiWolineToOperationLinker
    {
        public long SiWolineToOplinkerId { get; set; }
        public long SiWorksOrderLineId { get; set; }
        public long SiOperationId { get; set; }
    }
}
