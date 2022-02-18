using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class NljournalType
    {
        public NljournalType()
        {
            NlheldJournals = new HashSet<NlheldJournal>();
        }

        public long NljournalTypeId { get; set; }
        public string Name { get; set; } = null!;

        public virtual ICollection<NlheldJournal> NlheldJournals { get; set; }
    }
}
