using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiDistLandedCostTemplateLine
    {
        public long SiDistLandedCostTemplateLineId { get; set; }
        public long? SiDistLandedCostTemplateId { get; set; }
        public long? SiconDistLandedCostTypeId { get; set; }
        public decimal Value { get; set; }
        public decimal Percentage { get; set; }
        public string LastUpdatedByUser { get; set; } = null!;
        public DateTime? LastUpdatedDate { get; set; }
    }
}
