using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiSmkit
    {
        public long? SiSmkitId { get; set; }
        public long? ItemId { get; set; }
        public long? SiSmfaultCodeId { get; set; }
        public string? Name { get; set; }
    }
}
