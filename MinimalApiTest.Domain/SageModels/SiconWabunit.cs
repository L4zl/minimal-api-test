using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconWabunit
    {
        public long SiconWabunitId { get; set; }
        public long UnitId { get; set; }
        public bool IsWeightingUnit { get; set; }
    }
}
