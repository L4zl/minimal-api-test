using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconTcmeventSubscription
    {
        public SiconTcmeventSubscription()
        {
            SiconTcmeventSubCriteria = new HashSet<SiconTcmeventSubCriterion>();
        }

        public long SiconTcmeventSubscriptionId { get; set; }
        public long? SiconTcmeventDescriptionId { get; set; }
        public long SiconTcmeventSubscTypeId { get; set; }
        public string? ReportPath { get; set; }
        public string UserRef { get; set; } = null!;
        public string Description { get; set; } = null!;
        public long? DueAfterReminderTypeId { get; set; }
        public long? SiconTcmuserId { get; set; }
        public int RunOrder { get; set; }

        public virtual SiconTcmreminderType? DueAfterReminderType { get; set; }
        public virtual SiconTcmeventDescription? SiconTcmeventDescription { get; set; }
        public virtual SiconTcmeventSubscType SiconTcmeventSubscType { get; set; } = null!;
        public virtual ICollection<SiconTcmeventSubCriterion> SiconTcmeventSubCriteria { get; set; }
    }
}
