using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class ExtensionVersion
    {
        public string Name { get; set; } = null!;
        public int Version { get; set; }
    }
}
