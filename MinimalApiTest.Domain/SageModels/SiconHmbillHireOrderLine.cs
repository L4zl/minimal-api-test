using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconHmbillHireOrderLine
    {
        public long SiconHmbillHireOrderLineId { get; set; }
        public long SiconHmorderLineId { get; set; }
        public long SiconHmbillId { get; set; }
    }
}
