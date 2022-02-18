using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconAlreason
    {
        public long SiconAlreasonId { get; set; }
        public string Reason { get; set; } = null!;
    }
}
