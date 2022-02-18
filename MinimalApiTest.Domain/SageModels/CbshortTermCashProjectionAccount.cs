using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class CbshortTermCashProjectionAccount
    {
        public long CbshortTermCashProjectionAccountId { get; set; }
        public long CbshortTermCashProjectionHeaderId { get; set; }
        public long CbaccountId { get; set; }
        public bool IncludeInForecast { get; set; }

        public virtual Cbaccount Cbaccount { get; set; } = null!;
        public virtual CbshortTermCashProjectionHeader CbshortTermCashProjectionHeader { get; set; } = null!;
    }
}
