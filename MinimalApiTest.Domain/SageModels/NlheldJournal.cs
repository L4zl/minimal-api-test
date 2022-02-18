using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class NlheldJournal
    {
        public NlheldJournal()
        {
            NlheldJournalTrans = new HashSet<NlheldJournalTran>();
            NljournalRecurringDates = new HashSet<NljournalRecurringDate>();
        }

        public long NlheldJournalId { get; set; }
        public long? NljournalTemplateId { get; set; }
        public long NljournalTypeId { get; set; }
        public string CreatedByUserName { get; set; } = null!;
        public DateTime DateJournalCreated { get; set; }
        public DateTime? DateJournalLastAmended { get; set; }
        public DateTime? TransactionsDate { get; set; }
        public string JournalTitle { get; set; } = null!;
        public string? JournalReference { get; set; }
        public bool TransactionsBalance { get; set; }
        public DateTime? ReversalDate { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public long Source { get; set; }
        public DateTime DateTimeUpdated { get; set; }

        public virtual NljournalTemplate? NljournalTemplate { get; set; }
        public virtual NljournalType NljournalType { get; set; } = null!;
        public virtual ICollection<NlheldJournalTran> NlheldJournalTrans { get; set; }
        public virtual ICollection<NljournalRecurringDate> NljournalRecurringDates { get; set; }
    }
}
