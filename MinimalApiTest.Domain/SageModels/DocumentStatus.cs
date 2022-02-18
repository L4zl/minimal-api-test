using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class DocumentStatus
    {
        public DocumentStatus()
        {
            PoporderReturnArches = new HashSet<PoporderReturnArch>();
            PoporderReturns = new HashSet<PoporderReturn>();
            SopinvoiceCreditArches = new HashSet<SopinvoiceCreditArch>();
            SopinvoiceCredits = new HashSet<SopinvoiceCredit>();
            SoporderReturnArches = new HashSet<SoporderReturnArch>();
            SoporderReturns = new HashSet<SoporderReturn>();
        }

        public long DocumentStatusId { get; set; }
        public string Name { get; set; } = null!;

        public virtual ICollection<PoporderReturnArch> PoporderReturnArches { get; set; }
        public virtual ICollection<PoporderReturn> PoporderReturns { get; set; }
        public virtual ICollection<SopinvoiceCreditArch> SopinvoiceCreditArches { get; set; }
        public virtual ICollection<SopinvoiceCredit> SopinvoiceCredits { get; set; }
        public virtual ICollection<SoporderReturnArch> SoporderReturnArches { get; set; }
        public virtual ICollection<SoporderReturn> SoporderReturns { get; set; }
    }
}
