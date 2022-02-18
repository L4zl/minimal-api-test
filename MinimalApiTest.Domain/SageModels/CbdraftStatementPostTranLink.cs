using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class CbdraftStatementPostTranLink
    {
        public long CbdraftStatementPostTranLinkId { get; set; }
        public long CbdraftBankStatementId { get; set; }
        public long CbpostedAccountTranId { get; set; }
        public decimal DraftStatementValue { get; set; }

        public virtual CbdraftBankStatement CbdraftBankStatement { get; set; } = null!;
        public virtual CbpostedAccountTran CbpostedAccountTran { get; set; } = null!;
    }
}
