using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiSmdocumentSubStatus
    {
        public long SiSmdocumentSubStatusId { get; set; }
        public string? Name { get; set; }
        public string? StatusName { get; set; }
        public bool? VisibleToEngineers { get; set; }
    }
}
