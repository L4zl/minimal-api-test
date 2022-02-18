using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SystranAnalysisCode
    {
        public long SystranAnalysisCodeId { get; set; }
        public string Code { get; set; } = null!;
        public string Description { get; set; } = null!;
        public bool? Active { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public DateTime DateTimeUpdated { get; set; }
    }
}
