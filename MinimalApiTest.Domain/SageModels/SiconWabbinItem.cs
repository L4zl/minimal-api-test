using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconWabbinItem
    {
        public long SiconWabbinItemId { get; set; }
        public long BinItemId { get; set; }
        public bool? Problem { get; set; }
        public string ProblemReason { get; set; } = null!;
    }
}
