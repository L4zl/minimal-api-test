using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class PaymentInvCredLineType
    {
        public PaymentInvCredLineType()
        {
            SoppaymentInvCredLineArches = new HashSet<SoppaymentInvCredLineArch>();
            SoppaymentInvCredLines = new HashSet<SoppaymentInvCredLine>();
        }

        public long PaymentInvCredLineTypeId { get; set; }
        public string Name { get; set; } = null!;

        public virtual ICollection<SoppaymentInvCredLineArch> SoppaymentInvCredLineArches { get; set; }
        public virtual ICollection<SoppaymentInvCredLine> SoppaymentInvCredLines { get; set; }
    }
}
