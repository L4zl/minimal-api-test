using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class CbdirectDebitDocumentType
    {
        public CbdirectDebitDocumentType()
        {
            CbdirectDebitTrans = new HashSet<CbdirectDebitTran>();
        }

        public long CbdirectDebitDocumentTypeId { get; set; }
        public string Name { get; set; } = null!;

        public virtual ICollection<CbdirectDebitTran> CbdirectDebitTrans { get; set; }
    }
}
