using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class CbbankStatement
    {
        public long CbbankStatementId { get; set; }
        public long CbaccountId { get; set; }
        public int PageNumber { get; set; }
        public DateTime StatementDate { get; set; }
        public decimal StatementOpeningBalance { get; set; }
        public decimal StatementClosingBalance { get; set; }
        public decimal StatementCbaccountBalance { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public DateTime DateTimeUpdated { get; set; }

        public virtual Cbaccount Cbaccount { get; set; } = null!;
    }
}
