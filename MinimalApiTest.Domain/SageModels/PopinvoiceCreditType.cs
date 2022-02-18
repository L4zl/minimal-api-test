using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class PopinvoiceCreditType
    {
        public PopinvoiceCreditType()
        {
            PopinvCredDisputes = new HashSet<PopinvCredDispute>();
            PopinvCreditLineArches = new HashSet<PopinvCreditLineArch>();
            PopinvoiceCreditLines = new HashSet<PopinvoiceCreditLine>();
        }

        public long PopinvoiceCreditTypeId { get; set; }
        public string Name { get; set; } = null!;

        public virtual ICollection<PopinvCredDispute> PopinvCredDisputes { get; set; }
        public virtual ICollection<PopinvCreditLineArch> PopinvCreditLineArches { get; set; }
        public virtual ICollection<PopinvoiceCreditLine> PopinvoiceCreditLines { get; set; }
    }
}
