using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SysdataKey
    {
        public long? SysdataKeyId { get; set; }
        public long? SysuserLoginId { get; set; }
        public long? ProcessId { get; set; }
        public long? DataKey { get; set; }
        public DateTime DateTimeCreated { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeUpdated { get; set; }
    }
}
