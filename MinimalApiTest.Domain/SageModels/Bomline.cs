using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class Bomline
    {
        public long BomlineId { get; set; }
        public long Bomid { get; set; }
        public int BomlineSequence { get; set; }
        public long BomlineTypeId { get; set; }
        public decimal Quantity { get; set; }
        public long? UnitId { get; set; }
        public string? BomLineComment { get; set; }
        public bool ShowCommentInReports { get; set; }
        public string? DocumentUrl { get; set; }
        public long? StockItemId { get; set; }
        public bool HasComponentRef { get; set; }
        public string? ComponentReferences { get; set; }
        public long? BomcostItemId { get; set; }
        public bool IsCostPerUnit { get; set; }
        public bool UseNewVersionForSubAss { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public string SpareText1 { get; set; } = null!;
        public string SpareText2 { get; set; } = null!;
        public string SpareText3 { get; set; } = null!;
        public decimal SpareNumber1 { get; set; }
        public decimal SpareNumber2 { get; set; }
        public decimal SpareNumber3 { get; set; }
        public DateTime? SpareDate1 { get; set; }
        public DateTime? SpareDate2 { get; set; }
        public DateTime? SpareDate3 { get; set; }
        public bool SpareBit1 { get; set; }
        public bool SpareBit2 { get; set; }
        public bool SpareBit3 { get; set; }
        public DateTime DateTimeUpdated { get; set; }

        public virtual Bom Bom { get; set; } = null!;
        public virtual BomcostItem? BomcostItem { get; set; }
        public virtual BomlineType BomlineType { get; set; } = null!;
    }
}
