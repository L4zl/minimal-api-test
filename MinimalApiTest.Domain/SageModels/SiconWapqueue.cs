using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconWapqueue
    {
        public long SiconWapqueueId { get; set; }
        public string EntityType { get; set; } = null!;
        public long? EntityId { get; set; }
        public string QueueType { get; set; } = null!;
        public string LastUpdatedByUserId { get; set; } = null!;
        public DateTime? LastUpdatedDateTime { get; set; }
    }
}
