using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconMppoline
    {
        public long SiconMppolineId { get; set; }
        public long? PoporderReturnLineId { get; set; }
        public long? SiWorksOrderLineId { get; set; }
        public string? Reason { get; set; }
        public long? SoporderReturnLineId { get; set; }
        public bool? Deleted { get; set; }
    }
}
