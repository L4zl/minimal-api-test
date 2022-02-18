using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class BomlineCheckedOut
    {
        public long BomlineCheckedOutId { get; set; }
        public long? Bomid { get; set; }
        public long? BomcheckedOutId { get; set; }
        public int BomlineSequence { get; set; }
        public long BomlineTypeId { get; set; }
        public decimal Quantity { get; set; }
        public long? UnitId { get; set; }
        public string? BomLineCheckedOutComment { get; set; }
        public bool ShowCommentInReports { get; set; }
        public string? DocumentUrl { get; set; }
        public long? StockItemId { get; set; }
        public bool HasComponentReferences { get; set; }
        public string? ComponentReferences { get; set; }
        public long? BomcostItemId { get; set; }
        public bool IsCostPerUnit { get; set; }
        public bool UseNewVersionForSubAss { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public DateTime DateTimeUpdated { get; set; }

        public virtual BomcheckedOut? BomcheckedOut { get; set; }
        public virtual BomcostItem? BomcostItem { get; set; }
        public virtual BomlineType BomlineType { get; set; } = null!;
    }
}
