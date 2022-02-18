using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconInspectionTemplate
    {
        public long SiconInspectionTemplateId { get; set; }
        public string Name { get; set; } = null!;
        public bool? Deleted { get; set; }
        public bool StartInspection { get; set; }
    }
}
