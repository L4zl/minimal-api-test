using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class PaymentType
    {
        public PaymentType()
        {
            SopinvoiceCreditArches = new HashSet<SopinvoiceCreditArch>();
            SopinvoiceCredits = new HashSet<SopinvoiceCredit>();
            SoporderReturnArches = new HashSet<SoporderReturnArch>();
            SoporderReturns = new HashSet<SoporderReturn>();
        }

        public long PaymentTypeId { get; set; }
        public string Name { get; set; } = null!;

        public virtual ICollection<SopinvoiceCreditArch> SopinvoiceCreditArches { get; set; }
        public virtual ICollection<SopinvoiceCredit> SopinvoiceCredits { get; set; }
        public virtual ICollection<SoporderReturnArch> SoporderReturnArches { get; set; }
        public virtual ICollection<SoporderReturn> SoporderReturns { get; set; }
    }
}
