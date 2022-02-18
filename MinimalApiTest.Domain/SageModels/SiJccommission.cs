using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiJccommission
    {
        public long SiJccommissionId { get; set; }
        public long? SiJcjobId { get; set; }
        public long? SiJcchdid { get; set; }
        public string? Description { get; set; }
        public bool? IsSales { get; set; }
        public decimal? Budget { get; set; }
        public decimal? Actual { get; set; }
        public decimal? Commission { get; set; }
        public decimal? ExcludeAmount { get; set; }
    }
}
