using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconInspection
    {
        public long SiconInspectionId { get; set; }
        public long? SiconInspectionTemplate { get; set; }
        public long ForeignId { get; set; }
        public string ForeignType { get; set; } = null!;
        public long? SiconInspectionStatus { get; set; }
        public bool? Deleted { get; set; }
        public string? ForeignReference { get; set; }
    }
}
