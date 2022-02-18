using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class CbpaymentFrequency
    {
        public CbpaymentFrequency()
        {
            CbdirectDebitTrans = new HashSet<CbdirectDebitTran>();
        }

        public long CbpaymentFrequencyId { get; set; }
        public string Name { get; set; } = null!;

        public virtual ICollection<CbdirectDebitTran> CbdirectDebitTrans { get; set; }
    }
}
