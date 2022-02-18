using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class Cbsetting
    {
        public long CbsettingId { get; set; }
        public long? DefaultCbaccountId { get; set; }
        public int DefaultChargeDateOffset { get; set; }

        public virtual Cbaccount? DefaultCbaccount { get; set; }
    }
}
