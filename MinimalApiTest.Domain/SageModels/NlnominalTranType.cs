using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class NlnominalTranType
    {
        public NlnominalTranType()
        {
            NldeferredNominalTrans = new HashSet<NldeferredNominalTran>();
            NlpendNominalTrans = new HashSet<NlpendNominalTran>();
            NlpostedNominalTrans = new HashSet<NlpostedNominalTran>();
            Syscorrections = new HashSet<Syscorrection>();
        }

        public long NlnominalTranTypeId { get; set; }
        public string Name { get; set; } = null!;

        public virtual ICollection<NldeferredNominalTran> NldeferredNominalTrans { get; set; }
        public virtual ICollection<NlpendNominalTran> NlpendNominalTrans { get; set; }
        public virtual ICollection<NlpostedNominalTran> NlpostedNominalTrans { get; set; }
        public virtual ICollection<Syscorrection> Syscorrections { get; set; }
    }
}
