using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiSmfaultCode
    {
        public long SiSmfaultCodeId { get; set; }
        public string? Code { get; set; }
        public string? Description { get; set; }
    }
}
