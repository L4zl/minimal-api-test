using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconCrmsoporderReturnLine
    {
        public long SiconCrmsoporderReturnLineId { get; set; }
        public long SiconCrmsoporderReturnId { get; set; }
        public long SoporderReturnId { get; set; }
        public long SoporderReturnLineId { get; set; }
        public long? SiconCrmopportunityId { get; set; }
        public long? SiconCrmcaseId { get; set; }
        public bool? Deleted { get; set; }
        public string CreatedUser { get; set; } = null!;
        public DateTime? CreatedDate { get; set; }
        public string UpdatedUser { get; set; } = null!;
        public DateTime? UpdatedDate { get; set; }
        public bool Selected { get; set; }
    }
}
