using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconIcsoporderReturnLine
    {
        public long SiconIcsoporderReturnLineId { get; set; }
        public long? SiconIcsoporderReturnId { get; set; }
        public long? SoporderReturnLineId { get; set; }
        public long LinkedPoporderReturnLineId { get; set; }
        public string CompanyName { get; set; } = null!;
        public long CompanyNumber { get; set; }
    }
}
