using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class TemcodePage
    {
        public long TemcodePageId { get; set; }
        public string Name { get; set; } = null!;
    }
}
