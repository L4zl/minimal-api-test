using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class TemstatusMessage
    {
        public TemstatusMessage()
        {
            TemsettingOrdInvAcceptedStatMesses = new HashSet<Temsetting>();
            TemsettingOrdInvDeletedStatMesses = new HashSet<Temsetting>();
            TemsettingOrdInvReceivedStatMesses = new HashSet<Temsetting>();
            TemsettingOrdInvRejectedStatMesses = new HashSet<Temsetting>();
        }

        public long TemstatusMessageId { get; set; }
        public string Name { get; set; } = null!;

        public virtual ICollection<Temsetting> TemsettingOrdInvAcceptedStatMesses { get; set; }
        public virtual ICollection<Temsetting> TemsettingOrdInvDeletedStatMesses { get; set; }
        public virtual ICollection<Temsetting> TemsettingOrdInvReceivedStatMesses { get; set; }
        public virtual ICollection<Temsetting> TemsettingOrdInvRejectedStatMesses { get; set; }
    }
}
