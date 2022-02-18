using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiWorksOrderStage
    {
        public long SiWorksOrderStageId { get; set; }
        public long? StockItemId { get; set; }
        public long? SiWorksOrderDeptId { get; set; }
        public decimal? SequenceNo { get; set; }
    }
}
