using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconDmsemailTemplate
    {
        public long SiconDmsemailTemplateId { get; set; }
        public long SiconDmsdocumentTypeEntityId { get; set; }
        public long? SiconDmsdistributionReportId { get; set; }
        public string Subject { get; set; } = null!;
        public string? Body { get; set; }
        public bool Deleted { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string UpdatedUser { get; set; } = null!;
    }
}
