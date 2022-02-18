using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconJcbudgetTotal
    {
        public long? SiJcJobId { get; set; }
        public string? HeaderType { get; set; }
        public decimal? Budget { get; set; }
    }
}
