using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiDistLandedCostTemplate
    {
        public long SiDistLandedCostTemplateId { get; set; }
        public string TemplateName { get; set; } = null!;
        public string LastUpdatedByUser { get; set; } = null!;
        public DateTime? LastUpdatedDate { get; set; }
    }
}
