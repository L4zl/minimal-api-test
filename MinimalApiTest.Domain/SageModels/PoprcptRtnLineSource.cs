using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class PoprcptRtnLineSource
    {
        public PoprcptRtnLineSource()
        {
            PoprcptReturnLineArches = new HashSet<PoprcptReturnLineArch>();
            PopreceiptReturnLines = new HashSet<PopreceiptReturnLine>();
        }

        public long PoprcptRtnLineSourceId { get; set; }
        public string Name { get; set; } = null!;

        public virtual ICollection<PoprcptReturnLineArch> PoprcptReturnLineArches { get; set; }
        public virtual ICollection<PopreceiptReturnLine> PopreceiptReturnLines { get; set; }
    }
}
