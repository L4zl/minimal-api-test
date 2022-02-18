using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconSubscription
    {
        public long SiconSubscriptionId { get; set; }
        public string SubscriptionEntityType { get; set; } = null!;
        public long SubscriptionEntityId { get; set; }
        public short SubscriberTypeId { get; set; }
        public long SubscriberId { get; set; }
        public string SubscriptionDescription { get; set; } = null!;
        public bool Deleted { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedUser { get; set; } = null!;
        public DateTime? UpdatedDate { get; set; }
        public string UpdatedUser { get; set; } = null!;
    }
}
