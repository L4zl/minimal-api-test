using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconDdsFailureMapping
    {
        public long SiconDdsFailureMappingId { get; set; }
        public string FailureReason { get; set; } = null!;
        public int FailureStrategy { get; set; }
        public string FailureStrategyString { get; set; } = null!;
        public bool Deleted { get; set; }
        public string UpdatedUser { get; set; } = null!;
        public DateTime? UpdatedDate { get; set; }
    }
}
