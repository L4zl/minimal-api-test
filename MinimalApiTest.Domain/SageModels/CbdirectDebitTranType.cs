using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class CbdirectDebitTranType
    {
        public CbdirectDebitTranType()
        {
            CbdirectDebitTrans = new HashSet<CbdirectDebitTran>();
        }

        public long CbdirectDebitTranTypeId { get; set; }
        public string Name { get; set; } = null!;

        public virtual ICollection<CbdirectDebitTran> CbdirectDebitTrans { get; set; }
    }
}
