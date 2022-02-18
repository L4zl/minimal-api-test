using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconWabvanPick
    {
        public long SiconWabvanPickId { get; set; }
        public string? Name { get; set; }
        public string? Reference { get; set; }
        public bool? ReadyToPick { get; set; }
        public bool? IsComplete { get; set; }
    }
}
