using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class PcprojectStatusUpdateVw
    {
        public long PcprojectItemId { get; set; }
        public long PctopLevelParentId { get; set; }
        public long ProjectStatusId { get; set; }
        public bool? ProjectLevelFeatureEnabled { get; set; }
        public bool? ItemTypeFeatureEnabled { get; set; }
        public bool? GroupLevelFeatureEnabled { get; set; }
    }
}
