using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class DeprecatedObject
    {
        public long AutoId { get; set; }
        public string ObjectName { get; set; } = null!;
        public DateTime DateAdded { get; set; }
    }
}
