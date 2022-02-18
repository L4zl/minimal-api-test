using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconConstructionAppGroup
    {
        public long SiconConstructionAppGroupId { get; set; }
        public long? SiJcJobId { get; set; }
        public string? GroupName { get; set; }
    }
}
