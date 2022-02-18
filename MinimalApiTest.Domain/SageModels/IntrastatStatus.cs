using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class IntrastatStatus
    {
        public IntrastatStatus()
        {
            IntrastatEntries = new HashSet<IntrastatEntry>();
            PoprcptReturnLineArches = new HashSet<PoprcptReturnLineArch>();
            PoprcptRtnInvCrdLineArches = new HashSet<PoprcptRtnInvCrdLineArch>();
            PoprcptRtnInvCredLines = new HashSet<PoprcptRtnInvCredLine>();
            PopreceiptReturnLines = new HashSet<PopreceiptReturnLine>();
            SopdespatchReceiptLines = new HashSet<SopdespatchReceiptLine>();
        }

        public long IntrastatStatusId { get; set; }
        public string Name { get; set; } = null!;

        public virtual ICollection<IntrastatEntry> IntrastatEntries { get; set; }
        public virtual ICollection<PoprcptReturnLineArch> PoprcptReturnLineArches { get; set; }
        public virtual ICollection<PoprcptRtnInvCrdLineArch> PoprcptRtnInvCrdLineArches { get; set; }
        public virtual ICollection<PoprcptRtnInvCredLine> PoprcptRtnInvCredLines { get; set; }
        public virtual ICollection<PopreceiptReturnLine> PopreceiptReturnLines { get; set; }
        public virtual ICollection<SopdespatchReceiptLine> SopdespatchReceiptLines { get; set; }
    }
}
