using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconDistPoporderReturn
    {
        public long SiconDistPoporderReturnId { get; set; }
        public long PoporderReturnId { get; set; }
        public bool Confirmed { get; set; }
        public bool LandedCostsConfirmed { get; set; }
        public long? SiconDistContainerId { get; set; }
        public string? LastUpdatedBy { get; set; }
        public DateTime? LastUpdatedDate { get; set; }
        public long? SiDistLandedCostTemplateId { get; set; }
    }
}
