using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class NljournalTranTaxType
    {
        public NljournalTranTaxType()
        {
            NlheldJournalTrans = new HashSet<NlheldJournalTran>();
            NljournalTemplateTrans = new HashSet<NljournalTemplateTran>();
        }

        public long NljournalTranTaxTypeId { get; set; }
        public string Name { get; set; } = null!;

        public virtual ICollection<NlheldJournalTran> NlheldJournalTrans { get; set; }
        public virtual ICollection<NljournalTemplateTran> NljournalTemplateTrans { get; set; }
    }
}
