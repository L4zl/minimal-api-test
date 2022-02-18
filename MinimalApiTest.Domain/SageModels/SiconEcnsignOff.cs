using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconEcnsignOff
    {
        public long SiconEcnsignOffId { get; set; }
        public string Task { get; set; } = null!;
        public string SiconEcnworkflowId { get; set; } = null!;
    }
}
