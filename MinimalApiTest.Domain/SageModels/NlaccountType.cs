using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class NlaccountType
    {
        public NlaccountType()
        {
            NlheldJournalTrans = new HashSet<NlheldJournalTran>();
            NlnominalAccounts = new HashSet<NlnominalAccount>();
            NlpendNominalAccounts = new HashSet<NlpendNominalAccount>();
        }

        public long NlaccountTypeId { get; set; }
        public string Code { get; set; } = null!;
        public string Name { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeUpdated { get; set; }

        public virtual ICollection<NlheldJournalTran> NlheldJournalTrans { get; set; }
        public virtual ICollection<NlnominalAccount> NlnominalAccounts { get; set; }
        public virtual ICollection<NlpendNominalAccount> NlpendNominalAccounts { get; set; }
    }
}
