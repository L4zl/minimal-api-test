using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class ReportTrialKittingWarehouse
    {
        public long ReportTrialKittingWarehouseId { get; set; }
        public long ReportSessionId { get; set; }
        public string WarehouseName { get; set; } = null!;
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public DateTime DateTimeUpdated { get; set; }

        public virtual ReportSession ReportSession { get; set; } = null!;
    }
}
