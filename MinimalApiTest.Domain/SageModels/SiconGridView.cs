using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconGridView
    {
        public long SiconGridViewId { get; set; }
        public string? Name { get; set; }
        public string? FormName { get; set; }
        public string? ObjectName { get; set; }
        public string? ControlName { get; set; }
        public int? Order { get; set; }
    }
}
