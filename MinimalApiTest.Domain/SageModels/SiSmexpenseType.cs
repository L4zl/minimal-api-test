using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiSmexpenseType
    {
        public long SiSmexpenseTypeId { get; set; }
        public string? Name { get; set; }
        public long? SiJcChdId { get; set; }
    }
}
