using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconTeamColour
    {
        public long SiconTeamColourId { get; set; }
        public long? SiconTeamId { get; set; }
        public string? Phase { get; set; }
        public long Colour { get; set; }
    }
}
