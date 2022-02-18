using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconSalesOrderLine
    {
        public long SiconSalesOrderLineId { get; set; }
        public long SiconSalesOrderId { get; set; }
        public long? LineTypeId { get; set; }
        public short QuantityTypeId { get; set; }
        public long? ItemId { get; set; }
        public DateTime? DeliveryDate { get; set; }
        public decimal? UnitValue { get; set; }
        public decimal? Quantity { get; set; }
        public decimal? QuantityAllocated { get; set; }
        public decimal? QuantityDespatched { get; set; }
        public decimal? QuantityAppliedFor { get; set; }
        public decimal? QuantityOnApplication { get; set; }
        public decimal? PercentageComplete { get; set; }
        public decimal? PercentageOnApplication { get; set; }
        public string? Description { get; set; }
        public long? WarehouseItemId { get; set; }
        public decimal? QuantityToAllocate { get; set; }
        public decimal? QuantityToDespatch { get; set; }
        public short? LineNumber { get; set; }
        public long? SiJcChdId { get; set; }
        public long? NlnominalAccountId { get; set; }
        public long? SiJcTrnId { get; set; }
        public decimal? PreviousAllocated { get; set; }
        public decimal? PreviousDespatched { get; set; }
        public bool? ShowOnCustomerDocuments { get; set; }
        public bool? ShowOnPickingList { get; set; }
        public long TaxCodeId { get; set; }
        public long? SiJcJobId { get; set; }
        public long? SiJcphaseId { get; set; }
        public long? SiJcStageId { get; set; }
        public long? SiJcActivityId { get; set; }
        public long? PurchaseOrderLineId { get; set; }
        public decimal? MarkUpPc { get; set; }
        public decimal? UnitCostPrice { get; set; }
        public DateTime? PorequestedDate { get; set; }
        public long? PosupplierId { get; set; }
        public decimal? OriginalUnitCostPrice { get; set; }
        public long? OriginalPosupplierId { get; set; }
    }
}
