using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class ReportMaximumBuildWarehouse
    {
        public long ReportMaximumBuildWarehouseId { get; set; }
        public long ReportMaximumBuildItemId { get; set; }
        public long ReportSessionId { get; set; }
        public string WarehouseName { get; set; } = null!;
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public DateTime DateTimeUpdated { get; set; }

        public virtual ReportMaximumBuildItem ReportMaximumBuildItem { get; set; } = null!;
        public virtual ReportSession ReportSession { get; set; } = null!;
    }
}
