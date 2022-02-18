using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconMachine
    {
        public long SiconMachineId { get; set; }
        public long? MachMachineResourceId { get; set; }
        public string? Reference { get; set; }
        public string? Description { get; set; }
        public long? SiconMachineGroupId { get; set; }
        public long? WorkPatternId { get; set; }
    }
}
