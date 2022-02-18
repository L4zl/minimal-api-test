using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconIcpoporderReturnLine
    {
        public long SiconIcpoporderReturnLineId { get; set; }
        public long? SiconIcpoporderReturnId { get; set; }
        public long? PoporderReturnLineId { get; set; }
        public long LinkedSoporderReturnLineId { get; set; }
        public string CompanyName { get; set; } = null!;
        public long CompanyNumber { get; set; }
    }
}
