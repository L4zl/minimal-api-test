using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconWabbinItemLevel
    {
        public long SiconWabbinItemLevelId { get; set; }
        public long BinItemId { get; set; }
        public decimal Maximum { get; set; }
        public decimal Minimum { get; set; }
        public decimal Reorder { get; set; }
    }
}
