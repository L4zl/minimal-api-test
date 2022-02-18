using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconCustomContactSetup
    {
        public long SiconCustomContactSetupId { get; set; }
        public int? Number { get; set; }
        public int? Module { get; set; }
        public int? Area { get; set; }
        public string? Label { get; set; }
        public bool? IsEnabled { get; set; }
        public bool? IsMandatory { get; set; }
    }
}
