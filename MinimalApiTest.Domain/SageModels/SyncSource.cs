using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SyncSource
    {
        public long SyncSourceId { get; set; }
        public string EntityType { get; set; } = null!;
        public long EntityId { get; set; }
        public byte[] EntityOplock { get; set; } = null!;
        public int ExternalSystem { get; set; }
    }
}
