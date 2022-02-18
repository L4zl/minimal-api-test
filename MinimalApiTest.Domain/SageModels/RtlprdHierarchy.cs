using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class RtlprdHierarchy
    {
        public long PrdHierNodeId { get; set; }
        public string HierNodeName { get; set; } = null!;
        public long? ParentPrdHierNodeId { get; set; }
        public long? PrdLevelSeq { get; set; }
        public long? ProductId { get; set; }
        public DateTime? DateCreated { get; set; }
        public DateTime? DateModified { get; set; }
        public string? Description { get; set; }
        public string? BarCode { get; set; }
        public string? TaxCode { get; set; }
        public bool IsProduct { get; set; }
        public bool IsVariant { get; set; }
        public bool IsParentOfVariant { get; set; }
        public bool IsParentOfProduct { get; set; }
        public long? DimeSetId1 { get; set; }
        public long? DimeSetId2 { get; set; }
        public long? DimeSetId3 { get; set; }
        public long? DimeSubId1 { get; set; }
        public long? DimeSubId2 { get; set; }
        public long? DimeSubId3 { get; set; }
        public string? VariantSeparatorChar { get; set; }
        public DateTime DateTimeCreated { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public long? StockItemId { get; set; }
        public bool? DummyEntry { get; set; }
        public DateTime DateTimeUpdated { get; set; }
    }
}
