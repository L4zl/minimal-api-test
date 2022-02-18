using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class NljournalRecurringDate
    {
        public long NljournalRecurringDateId { get; set; }
        public long NlheldJournalId { get; set; }
        public DateTime JournalDate { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public DateTime DateTimeUpdated { get; set; }

        public virtual NlheldJournal NlheldJournal { get; set; } = null!;
    }
}
