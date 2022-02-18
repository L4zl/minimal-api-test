using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconHmassetCondition
    {
        public long SiconHmassetConditionId { get; set; }
        public string ConditionName { get; set; } = null!;
        public string HtmlColourCode { get; set; } = null!;
        public string LastUpdatedByUserId { get; set; } = null!;
        public DateTime? LastUpdatedDateTime { get; set; }
    }
}
