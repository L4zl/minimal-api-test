using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class NlaccountNumber
    {
        public NlaccountNumber()
        {
            NlaccountNumberCostCentres = new HashSet<NlaccountNumberCostCentre>();
        }

        public long NlaccountNumberId { get; set; }
        public string AccountNumber { get; set; } = null!;

        public virtual ICollection<NlaccountNumberCostCentre> NlaccountNumberCostCentres { get; set; }
    }
}
