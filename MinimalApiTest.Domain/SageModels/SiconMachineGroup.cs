using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconMachineGroup
    {
        public long SiconMachineGroupId { get; set; }
        public long? MachMachineResourceGroupId { get; set; }
        public string? Reference { get; set; }
        public string? Description { get; set; }
        public long? WorkPatternId { get; set; }
        public int? DefaultMachineCount { get; set; }
    }
}
