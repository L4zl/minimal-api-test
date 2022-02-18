using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiJcPlannedPurchase
    {
        public long SiJcPlannedPurchaseId { get; set; }
        public long? SiJcJobId { get; set; }
        public long? SijobPhaseId { get; set; }
        public long? SijobStageId { get; set; }
        public long? SijobSubStageId { get; set; }
        public long? SijcvariationId { get; set; }
        public long? SioperationId { get; set; }
        public long? SiJcChdId { get; set; }
        public short? LineType { get; set; }
        public long? StockItemId { get; set; }
        public string? StockCode { get; set; }
        public string? StockDescription { get; set; }
        public decimal? QuantityRequired { get; set; }
        public decimal? QuantityPurchased { get; set; }
        public decimal? PlannedUnitPrice { get; set; }
        public decimal? UnitPrice { get; set; }
        public long? PlsupplierAccountId { get; set; }
        public long? WarehouseId { get; set; }
        public string? LineStatus { get; set; }
        public string? LastUpdatedByUserId { get; set; }
        public DateTime? LastUpdatedDateTime { get; set; }
        public string? CreatedByUserId { get; set; }
        public DateTime? CreatedDateTime { get; set; }
        public decimal? OriginalPlannedUnitPrice { get; set; }
        public decimal? OriginalQuantityRequired { get; set; }
        public decimal? TotalPricePurchased { get; set; }
        public string? OrderNumber { get; set; }
        public DateTime? OrderDueDate { get; set; }
        public long? NlnominalAccount { get; set; }
        public bool? BudgetLocked { get; set; }
        public decimal? LeadTime { get; set; }
        public long? LeadTimeUnitId { get; set; }
        public bool? AwaitingApproval { get; set; }
        public string? AwaitingApprovalBy { get; set; }
    }
}
