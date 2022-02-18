using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconTcmreminderType
    {
        public SiconTcmreminderType()
        {
            SiconTcmeventSubscriptions = new HashSet<SiconTcmeventSubscription>();
        }

        public long SiconTcmreminderTypeId { get; set; }
        public string ReminderTypeName { get; set; } = null!;
        public int Days { get; set; }
        public int Hours { get; set; }
        public int Minutes { get; set; }
        public DateTime? UpdatedDateTime { get; set; }
        public string UpdatedUser { get; set; } = null!;
        public bool Deleted { get; set; }

        public virtual ICollection<SiconTcmeventSubscription> SiconTcmeventSubscriptions { get; set; }
    }
}
