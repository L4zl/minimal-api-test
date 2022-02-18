using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiJcsubJobStructureView
    {
        public long? SiJcJobId { get; set; }
        public string? JobNumber { get; set; }
        public int? Level { get; set; }
        public long? TopLeveljobId { get; set; }
    }
}
