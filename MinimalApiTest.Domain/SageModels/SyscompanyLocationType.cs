using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SyscompanyLocationType
    {
        public long SyscompanyLocationTypeId { get; set; }
        public string Name { get; set; } = null!;
    }
}
