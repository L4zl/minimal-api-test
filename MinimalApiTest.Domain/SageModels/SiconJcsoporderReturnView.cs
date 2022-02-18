using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconJcsoporderReturnView
    {
        public long SoporderReturnId { get; set; }
        public string JobNumbers { get; set; } = null!;
    }
}
