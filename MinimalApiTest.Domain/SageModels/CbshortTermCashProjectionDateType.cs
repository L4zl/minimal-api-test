using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class CbshortTermCashProjectionDateType
    {
        public CbshortTermCashProjectionDateType()
        {
            CbshortTermCashProjectionHeaders = new HashSet<CbshortTermCashProjectionHeader>();
        }

        public long CbshortTermCashProjectionDateTypeId { get; set; }
        public string Name { get; set; } = null!;

        public virtual ICollection<CbshortTermCashProjectionHeader> CbshortTermCashProjectionHeaders { get; set; }
    }
}
