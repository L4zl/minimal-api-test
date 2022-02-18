using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class DeprecationScript
    {
        public long AutoId { get; set; }
        public string ObjectName { get; set; } = null!;
        public string? Scripts { get; set; }
        public string? Detail { get; set; }
        public string? Error { get; set; }
        public DateTime DateRun { get; set; }
    }
}
