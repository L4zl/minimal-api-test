using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiSmcaseSolutionOption
    {
        public long SiSmcaseSolutionOptionId { get; set; }
        public string? OptionText { get; set; }
        public long? SiSmfaultCodeId { get; set; }
    }
}
