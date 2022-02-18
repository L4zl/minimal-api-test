using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class PcprojectsForCostAndRevenueAnalysisVw
    {
        public long PcprojectItemId { get; set; }
        public string Code { get; set; } = null!;
        public long PcintegrationOptionId { get; set; }
    }
}
