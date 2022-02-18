using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconPurchaseOrderLine
    {
        public long SiconPurchaseOrderLineId { get; set; }
        public long SiconPurchaseOrderId { get; set; }
        public long? LineTypeId { get; set; }
        public short QuantityTypeId { get; set; }
        public long? ItemId { get; set; }
        public DateTime? RequestedDate { get; set; }
        public decimal? UnitValue { get; set; }
        public decimal? Quantity { get; set; }
        public decimal? QuantityReceived { get; set; }
        public decimal? QuantityAppliedFor { get; set; }
        public decimal? QuantityOnApplication { get; set; }
        public string? Description { get; set; }
        public long? WarehouseItemId { get; set; }
        public decimal? QuantityToReceive { get; set; }
        public short? LineNumber { get; set; }
        public long? SiJcChdId { get; set; }
        public long NlnominalAccountId { get; set; }
        public long? SiJcTrnId { get; set; }
        public decimal? PreviousReceived { get; set; }
        public decimal? PercentageComplete { get; set; }
        public decimal? PercentageOnApplication { get; set; }
        public int? ReceiveMode { get; set; }
        public bool? ShowOnSupplierDocuments { get; set; }
        public long TaxCodeId { get; set; }
        public long? SiJcJobId { get; set; }
        public long? SiJcphaseId { get; set; }
        public long? SiJcStageId { get; set; }
        public long? SiJcActivityId { get; set; }
    }
}
