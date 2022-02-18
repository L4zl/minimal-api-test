using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconMrpsetting
    {
        public long SiconMrpsettingId { get; set; }
        public string? Module { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? Value { get; set; }
        public long? UserNumber { get; set; }
    }
}
