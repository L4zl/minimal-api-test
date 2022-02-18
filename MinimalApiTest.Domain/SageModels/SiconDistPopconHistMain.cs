using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconDistPopconHistMain
    {
        public long SiconDistPopconHistMainId { get; set; }
        public int Type { get; set; }
        public bool Track { get; set; }
        public bool RequireReason { get; set; }
    }
}
