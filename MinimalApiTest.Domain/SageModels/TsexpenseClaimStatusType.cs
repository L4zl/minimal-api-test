using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class TsexpenseClaimStatusType
    {
        public TsexpenseClaimStatusType()
        {
            TsclaimSheets = new HashSet<TsclaimSheet>();
        }

        public long TsexpenseClaimStatusTypeId { get; set; }
        public string Description { get; set; } = null!;

        public virtual ICollection<TsclaimSheet> TsclaimSheets { get; set; }
    }
}
