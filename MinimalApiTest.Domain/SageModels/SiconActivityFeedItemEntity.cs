using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconActivityFeedItemEntity
    {
        public long SiconActivityFeedItemEntityId { get; set; }
        public long SiconActivityFeedItemId { get; set; }
        public string EntityKey { get; set; } = null!;
        public long EntityForeignId { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedUser { get; set; } = null!;
    }
}
