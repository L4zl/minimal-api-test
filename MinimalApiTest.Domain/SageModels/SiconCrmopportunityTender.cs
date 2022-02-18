using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconCrmopportunityTender
    {
        public long SiconCrmopportunityTenderId { get; set; }
        public long SiconCrmtenderStageId { get; set; }
        public long? PrimaryOpportunityId { get; set; }
        public string Summary { get; set; } = null!;
        public DateTime? DueDateTime { get; set; }
        public bool? Deleted { get; set; }
        public string CreatedUser { get; set; } = null!;
        public DateTime? CreatedDate { get; set; }
        public string UpdatedUser { get; set; } = null!;
        public DateTime? UpdatedDate { get; set; }
        public string TenderReference { get; set; } = null!;
    }
}
