using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class TspostingMethodType
    {
        public TspostingMethodType()
        {
            TstimeFinancialsIntegrations = new HashSet<TstimeFinancialsIntegration>();
        }

        public long TspostingMethodId { get; set; }
        public string? Description { get; set; }

        public virtual ICollection<TstimeFinancialsIntegration> TstimeFinancialsIntegrations { get; set; }
    }
}
