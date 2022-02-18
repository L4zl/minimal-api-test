using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class InvinvoiceCreditType
    {
        public InvinvoiceCreditType()
        {
            InvinvoiceCredits = new HashSet<InvinvoiceCredit>();
        }

        public long InvinvoiceCreditTypeId { get; set; }
        public string Name { get; set; } = null!;

        public virtual ICollection<InvinvoiceCredit> InvinvoiceCredits { get; set; }
    }
}
