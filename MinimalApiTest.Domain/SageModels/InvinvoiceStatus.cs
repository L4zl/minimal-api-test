using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class InvinvoiceStatus
    {
        public InvinvoiceStatus()
        {
            InvinvoiceCredits = new HashSet<InvinvoiceCredit>();
        }

        public long InvinvoiceStatusId { get; set; }
        public string Name { get; set; } = null!;

        public virtual ICollection<InvinvoiceCredit> InvinvoiceCredits { get; set; }
    }
}
