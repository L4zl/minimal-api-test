using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconWabwaveOrder
    {
        public long SiconWabwaveOrderId { get; set; }
        public long SiconWabwaveId { get; set; }
        public long SoporderReturnId { get; set; }
        public long SiWorksOrderId { get; set; }
    }
}
