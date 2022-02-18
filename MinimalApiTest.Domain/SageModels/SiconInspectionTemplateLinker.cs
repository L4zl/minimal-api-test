using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconInspectionTemplateLinker
    {
        public long SiTemplateLinkerId { get; set; }
        public long SiconInspectionTemplate { get; set; }
        public long ForeignId { get; set; }
        public string ForeignType { get; set; } = null!;
        public bool? Deleted { get; set; }
    }
}
