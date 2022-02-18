using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconDistPoporderReturnLine
    {
        public long? SiconDistPoporderReturnLineId { get; set; }
        public long? PoporderReturnLineId { get; set; }
        public decimal? AllocatedStockInTransit { get; set; }
        public string? LastUpdatedByUserId { get; set; }
        public DateTime? LastUpdatedDateTime { get; set; }
        public long? SiconDistPclineId { get; set; }
        public long? SupplierId { get; set; }
        public DateTime? ConfirmedDate { get; set; }
        public DateTime? ReceivedDate { get; set; }
        public string Kpiperformance { get; set; } = null!;
        public long? SiconDistPoporderLineStatusId { get; set; }
        public string ExpectedTime { get; set; } = null!;
    }
}
