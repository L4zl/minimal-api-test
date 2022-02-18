using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiPoplineExtra
    {
        public long SiPoplineExtraId { get; set; }
        public long? PoporderReturnLineId { get; set; }
        public bool? Confirmed { get; set; }
    }
}
