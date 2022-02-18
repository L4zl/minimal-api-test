using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SysLockThreshold
    {
        public long SysLockThresholdsId { get; set; }
        public string FeatureArea { get; set; } = null!;
        public int LockThreshold { get; set; }
        public DateTime DateTimeCreated { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeUpdated { get; set; }
    }
}
