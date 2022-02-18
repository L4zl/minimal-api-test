using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class NljournalTemplate
    {
        public NljournalTemplate()
        {
            NlheldJournals = new HashSet<NlheldJournal>();
            NljournalTemplateTrans = new HashSet<NljournalTemplateTran>();
        }

        public long NljournalTemplateId { get; set; }
        public long NljournalTemplateTypeId { get; set; }
        public string Name { get; set; } = null!;
        public string CreatedByUserName { get; set; } = null!;
        public bool UnlimitedUses { get; set; }
        public int RepeatCount { get; set; }
        public int NumberOfTimesUsed { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public DateTime? DateLastUsed { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public DateTime DateTimeUpdated { get; set; }

        public virtual NljournalTemplateType NljournalTemplateType { get; set; } = null!;
        public virtual ICollection<NlheldJournal> NlheldJournals { get; set; }
        public virtual ICollection<NljournalTemplateTran> NljournalTemplateTrans { get; set; }
    }
}
