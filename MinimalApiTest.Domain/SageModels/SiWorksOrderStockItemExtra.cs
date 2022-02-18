using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiWorksOrderStockItemExtra
    {
        public long SiWorksOrderStockItemExtraId { get; set; }
        public long? ItemId { get; set; }
        public string? WorksOrderComment { get; set; }
        public string? ProductionUomname { get; set; }
        public string? PurchasingUomname { get; set; }
        public bool? DeletedItem { get; set; }
        public long? PurchasingRounding { get; set; }
        public bool SplitByEconomicalBatchSize { get; set; }
        public bool DoNotRoundUpLastWotoEcoSize { get; set; }
        public bool DoNotIncludeForSubcontract { get; set; }
        public bool BulkIssueItem { get; set; }
        public long AddingToWorksOrder { get; set; }
        public bool IssueFullBatch { get; set; }
        public bool AutoSelectTraceableNumbers { get; set; }
    }
}
