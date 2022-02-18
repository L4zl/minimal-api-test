using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiJcfieldListValue
    {
        public long SiJcfieldListValueId { get; set; }
        public long? SiJcfieldId { get; set; }
        public string? Value { get; set; }
    }
}
