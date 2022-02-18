using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconJcpoporderReturnView
    {
        public long PoporderReturnId { get; set; }
        public string JobNumbers { get; set; } = null!;
    }
}
