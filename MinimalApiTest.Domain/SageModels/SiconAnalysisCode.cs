using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconAnalysisCode
    {
        public long SiconAnalysisCodeId { get; set; }
        public int? Number { get; set; }
        public int? Module { get; set; }
        public int? Area { get; set; }
        public string Label { get; set; } = null!;
        public int? Type { get; set; }
        public bool? IsEnabled { get; set; }
        public bool? IsMandatory { get; set; }
        public bool? CopyFromContractLine { get; set; }
    }
}
