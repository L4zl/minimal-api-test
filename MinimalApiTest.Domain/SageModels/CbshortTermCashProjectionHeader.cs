using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class CbshortTermCashProjectionHeader
    {
        public CbshortTermCashProjectionHeader()
        {
            CbshortTermCashProjectionAccounts = new HashSet<CbshortTermCashProjectionAccount>();
            CbshortTermCashProjectionTrans = new HashSet<CbshortTermCashProjectionTran>();
        }

        public long CbshortTermCashProjectionHeaderId { get; set; }
        public long CbshortTermCashProjectionDateTypeId { get; set; }
        public DateTime DateFrom { get; set; }
        public DateTime DateTo { get; set; }
        public decimal BookBalanceForSelectedAccounts { get; set; }

        public virtual CbshortTermCashProjectionDateType CbshortTermCashProjectionDateType { get; set; } = null!;
        public virtual ICollection<CbshortTermCashProjectionAccount> CbshortTermCashProjectionAccounts { get; set; }
        public virtual ICollection<CbshortTermCashProjectionTran> CbshortTermCashProjectionTrans { get; set; }
    }
}
