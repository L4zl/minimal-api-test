using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class TstimeProjectIntegration
    {
        public long TstimeProjectIntegrationId { get; set; }
        public bool? IsIntegrated { get; set; }
        public bool PostAutomatically { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public DateTime DateTimeUpdated { get; set; }
    }
}
