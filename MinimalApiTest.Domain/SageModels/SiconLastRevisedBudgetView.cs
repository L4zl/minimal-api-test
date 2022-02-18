using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconLastRevisedBudgetView
    {
        public long? Sijcjobid { get; set; }
        public string? Headertype { get; set; }
        public string? LastRevisedIn { get; set; }
        public int IsLatest { get; set; }
    }
}
