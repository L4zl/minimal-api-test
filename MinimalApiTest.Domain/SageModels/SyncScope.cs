using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SyncScope
    {
        public long SyncScopeId { get; set; }
        public string EntityType { get; set; } = null!;
        public long EntityId { get; set; }
        public int ExternalSystem { get; set; }
        public int Scope { get; set; }
        public byte[] EntityOplock { get; set; } = null!;
    }
}
