using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SopprospectQuoteSettingView
    {
        public long MmspqsSopsettingId { get; set; }
        public bool MmspqsAllowProspectQuoted { get; set; }
        public long? MmspqsProspectQuoteAccountId { get; set; }
    }
}
