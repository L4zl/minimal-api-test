using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconMaintenanceActivityType
    {
        public long SiconMaintenanceActivityTypeId { get; set; }
        public string Name { get; set; } = null!;
        public int Colour { get; set; }
    }
}
