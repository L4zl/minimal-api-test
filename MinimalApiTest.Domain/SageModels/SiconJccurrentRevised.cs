using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconJccurrentRevised
    {
        public long? Sijcjobid { get; set; }
        public string Headertype { get; set; } = null!;
        public decimal? CurrentRevised { get; set; }
        public string? LastRevisedIn { get; set; }
    }
}
