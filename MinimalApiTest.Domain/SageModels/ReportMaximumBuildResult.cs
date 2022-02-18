using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class ReportMaximumBuildResult
    {
        public long ReportMaximumBuildResultId { get; set; }
        public long ReportMaximumBuildItemId { get; set; }
        public long ReportSessionId { get; set; }
        public string StockCode { get; set; } = null!;
        public string Description { get; set; } = null!;
        public bool IsMiscellaneousItem { get; set; }
        public string LineTypeName { get; set; } = null!;
        public long? BomRecordId { get; set; }
        public decimal QuantityOnBom { get; set; }
        public decimal FreeStockQuantity { get; set; }
        public decimal CanMakeQuantity { get; set; }
        public string StockUnitName { get; set; } = null!;
        public string Properties { get; set; } = null!;
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public DateTime DateTimeUpdated { get; set; }

        public virtual ReportMaximumBuildItem ReportMaximumBuildItem { get; set; } = null!;
        public virtual ReportSession ReportSession { get; set; } = null!;
    }
}
