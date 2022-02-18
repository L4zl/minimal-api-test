using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconHmanalysisCodeValue
    {
        public long SiconHmanalysisCodeValueId { get; set; }
        public long SiconHmanalysisCodeId { get; set; }
        public string? Value { get; set; }
    }
}
