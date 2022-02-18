using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconDrawingRevision
    {
        public long SiconDrawingRevisionId { get; set; }
        public string SiconDrawingReference { get; set; } = null!;
        public string ChangedBy { get; set; } = null!;
        public string ChangedOn { get; set; } = null!;
        public string? OldRevisionNumber { get; set; }
        public string NewRevisionNumber { get; set; } = null!;
        public string SiconEcrcaseId { get; set; } = null!;
    }
}
