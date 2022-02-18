using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class CbdraftBankStatement
    {
        public CbdraftBankStatement()
        {
            CbdraftStatementPostTranLinks = new HashSet<CbdraftStatementPostTranLink>();
        }

        public long CbdraftBankStatementId { get; set; }
        public long CbaccountId { get; set; }
        public int PageNumber { get; set; }
        public DateTime StatementDate { get; set; }
        public string Reference { get; set; } = null!;
        public decimal ProjectedClosingBalance { get; set; }
        public decimal OpeningBalance { get; set; }

        public virtual Cbaccount Cbaccount { get; set; } = null!;
        public virtual ICollection<CbdraftStatementPostTranLink> CbdraftStatementPostTranLinks { get; set; }
    }
}
