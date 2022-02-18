using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class InvoiceCreditUpdateStatusType
    {
        public InvoiceCreditUpdateStatusType()
        {
            InvinvoiceCredits = new HashSet<InvinvoiceCredit>();
            SopinvoiceCreditArches = new HashSet<SopinvoiceCreditArch>();
            SopinvoiceCredits = new HashSet<SopinvoiceCredit>();
        }

        public long InvoiceCreditUpdateStatusTypeId { get; set; }
        public string Name { get; set; } = null!;

        public virtual ICollection<InvinvoiceCredit> InvinvoiceCredits { get; set; }
        public virtual ICollection<SopinvoiceCreditArch> SopinvoiceCreditArches { get; set; }
        public virtual ICollection<SopinvoiceCredit> SopinvoiceCredits { get; set; }
    }
}
