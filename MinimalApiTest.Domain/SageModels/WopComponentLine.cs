using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class WopComponentLine
    {
        public WopComponentLine()
        {
            WopAllocationLines = new HashSet<WopAllocationLine>();
            WopBomComponentLineLinks = new HashSet<WopBomComponentLineLink>();
            WopBuildComponents = new HashSet<WopBuildComponent>();
            WopIssues = new HashSet<WopIssue>();
        }

        public long WopComponentLineId { get; set; }
        public long WopOrderId { get; set; }
        public long WopComponentLineTypeId { get; set; }
        public decimal SequenceNumber { get; set; }
        public string StockCode { get; set; } = null!;
        public string Description { get; set; } = null!;
        public decimal QuantityRequired { get; set; }
        public decimal QuantityAllocated { get; set; }
        public decimal QuantityIssued { get; set; }
        public long StockItemUnitId { get; set; }
        public string UnitOfMeasure { get; set; } = null!;
        public long PickingListPrintStatus { get; set; }
        public long? WopOrderLinkId { get; set; }
        public decimal LineUnitPrecision { get; set; }
        public decimal StockUnitPrecision { get; set; }
        public decimal MultipleOfStockUnit { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public decimal QuantityUsedInBuild { get; set; }
        public bool ShowCommentOnReport { get; set; }
        public string? DocumentFile { get; set; }
        public string CommentText { get; set; } = null!;
        public DateTime DateTimeUpdated { get; set; }

        public virtual WopComponentLineType WopComponentLineType { get; set; } = null!;
        public virtual WopOrder WopOrder { get; set; } = null!;
        public virtual ICollection<WopAllocationLine> WopAllocationLines { get; set; }
        public virtual ICollection<WopBomComponentLineLink> WopBomComponentLineLinks { get; set; }
        public virtual ICollection<WopBuildComponent> WopBuildComponents { get; set; }
        public virtual ICollection<WopIssue> WopIssues { get; set; }
    }
}
