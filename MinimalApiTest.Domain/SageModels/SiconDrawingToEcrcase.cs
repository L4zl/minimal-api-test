using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconDrawingToEcrcase
    {
        public long SiconDrawingToEcrcaseId { get; set; }
        public string SiconEcrcaseId { get; set; } = null!;
        public string SiconDrawingReference { get; set; } = null!;
    }
}
