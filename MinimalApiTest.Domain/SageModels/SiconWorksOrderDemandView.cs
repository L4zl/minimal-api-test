using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconWorksOrderDemandView
    {
        public DateTime? WocreatedDate { get; set; }
        public DateTime? WodueDate { get; set; }
        public long SiWorksOrderId { get; set; }
        public long SiWorksOrderLineId { get; set; }
        public string? CostName { get; set; }
        public long? LineTypeId { get; set; }
        public string? Description { get; set; }
        public decimal? SequenceNo { get; set; }
        public decimal? Estimate { get; set; }
        public decimal? Actual { get; set; }
        public string? Code { get; set; }
        public string? Wostatus { get; set; }
    }
}
