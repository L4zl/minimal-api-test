using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class NljournalTemplateType
    {
        public NljournalTemplateType()
        {
            NljournalTemplates = new HashSet<NljournalTemplate>();
        }

        public long NljournalTemplateTypeId { get; set; }
        public string Name { get; set; } = null!;

        public virtual ICollection<NljournalTemplate> NljournalTemplates { get; set; }
    }
}
