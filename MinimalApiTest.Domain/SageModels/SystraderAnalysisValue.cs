using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SystraderAnalysisValue
    {
        public long SystraderAnalysisValueId { get; set; }
        public long SystraderAnalysisHeadingId { get; set; }
        public string Name { get; set; } = null!;
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public DateTime DateTimeUpdated { get; set; }

        public virtual SystraderAnalysisHeading SystraderAnalysisHeading { get; set; } = null!;
    }
}
