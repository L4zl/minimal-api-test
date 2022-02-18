using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconJccostToCompleteTotalsView
    {
        public long? SiJcJobId { get; set; }
        public string HeaderType { get; set; } = null!;
        public decimal? CurrentRevised { get; set; }
    }
}
