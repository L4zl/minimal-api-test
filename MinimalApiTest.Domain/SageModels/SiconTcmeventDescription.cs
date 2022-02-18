using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconTcmeventDescription
    {
        public SiconTcmeventDescription()
        {
            SiconTcmeventSubscriptions = new HashSet<SiconTcmeventSubscription>();
        }

        public long SiconTcmeventDescriptionId { get; set; }
        public string Name { get; set; } = null!;
        public long SiconTcmeventDefId { get; set; }
        public long SiconTcmeventGroupId { get; set; }
        public int EventType { get; set; }
        public long? Filter1 { get; set; }
        public long? Filter2 { get; set; }
        public long? Filter3 { get; set; }
        public string? EventDescription { get; set; }
        public DateTime? DateTimeUpdated { get; set; }
        public DateTime? LastPollDateTime { get; set; }
        public DateTime? NextPollDateTime { get; set; }
        public string Cron { get; set; } = null!;
        public string? LastOccurrenceHash { get; set; }
        public bool? IsRunning { get; set; }
        public string HangfireJobNo { get; set; } = null!;
        public bool? IsEnabled { get; set; }

        public virtual SiconTcmeventDef SiconTcmeventDef { get; set; } = null!;
        public virtual SiconTcmeventGroup SiconTcmeventGroup { get; set; } = null!;
        public virtual ICollection<SiconTcmeventSubscription> SiconTcmeventSubscriptions { get; set; }
    }
}
