using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiEstimateIncomeView
    {
        public long Id { get; set; }
        public string? LineType { get; set; }
        public long? SiJcJobId { get; set; }
        public string? Jobnumber { get; set; }
        public long? SiJcChdId { get; set; }
        public string? Costcode { get; set; }
        public long? SijobPhaseId { get; set; }
        public long? SijobStageId { get; set; }
        public long? SiJobActivityId { get; set; }
        public long? SiOperationId { get; set; }
        public string? ItemDescription { get; set; }
        public decimal? Quantity { get; set; }
        public decimal? UnitValue { get; set; }
        public decimal? LineTotal { get; set; }
    }
}
