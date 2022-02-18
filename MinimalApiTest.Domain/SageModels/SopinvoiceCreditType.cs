using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SopinvoiceCreditType
    {
        public SopinvoiceCreditType()
        {
            SopinvoiceCreditArches = new HashSet<SopinvoiceCreditArch>();
            SopinvoiceCredits = new HashSet<SopinvoiceCredit>();
        }

        public long SopinvoiceCreditTypeId { get; set; }
        public string Name { get; set; } = null!;

        public virtual ICollection<SopinvoiceCreditArch> SopinvoiceCreditArches { get; set; }
        public virtual ICollection<SopinvoiceCredit> SopinvoiceCredits { get; set; }
    }
}
