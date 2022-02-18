using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class NlcompletedConsolidation
    {
        public long NlcompletedConsolidationId { get; set; }
        public string UniqueIdentifier { get; set; } = null!;
    }
}
