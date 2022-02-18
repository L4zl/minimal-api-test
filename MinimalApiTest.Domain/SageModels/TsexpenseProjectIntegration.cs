using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class TsexpenseProjectIntegration
    {
        public long TsexpenseProjectIntegrationId { get; set; }
        public bool? IsIntegrated { get; set; }
        public bool PostAutomatically { get; set; }
        public DateTime DateTimeCreated { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeUpdated { get; set; }
    }
}
