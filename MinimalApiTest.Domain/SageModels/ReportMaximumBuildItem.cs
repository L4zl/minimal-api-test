using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class ReportMaximumBuildItem
    {
        public ReportMaximumBuildItem()
        {
            ReportMaximumBuildResults = new HashSet<ReportMaximumBuildResult>();
            ReportMaximumBuildWarehouses = new HashSet<ReportMaximumBuildWarehouse>();
        }

        public long ReportMaximumBuildItemId { get; set; }
        public long ReportSessionId { get; set; }
        public long BomRecordId { get; set; }
        public long BuildPackageId { get; set; }
        public decimal MaximumBuildQuantity { get; set; }
        public decimal FreeStockQuantity { get; set; }
        public decimal PossibleStockQuantity { get; set; }
        public string UnitOfMeasure { get; set; } = null!;
        public bool ConsiderStockLevelsForAllowNegativeItems { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public DateTime DateTimeUpdated { get; set; }

        public virtual ReportSession ReportSession { get; set; } = null!;
        public virtual ICollection<ReportMaximumBuildResult> ReportMaximumBuildResults { get; set; }
        public virtual ICollection<ReportMaximumBuildWarehouse> ReportMaximumBuildWarehouses { get; set; }
    }
}
