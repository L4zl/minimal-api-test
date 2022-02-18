using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconWabvanPickLine
    {
        public long SiconWabvanPickLineId { get; set; }
        public long SiconWabvanPickId { get; set; }
        public long SoporderReturnId { get; set; }
        public int Sequence { get; set; }
        public bool? IsComplete { get; set; }
        public bool? ReadyToVanOrderPick { get; set; }
    }
}
