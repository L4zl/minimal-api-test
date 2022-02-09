﻿namespace MinimalApiTest.Domain.Models
{
    public partial class ProjectRequisitionLine
    {
        public long ProjectRequisitionLineId { get; set; }
        public long? ProjectRequisitionId { get; set; }
        public long? ProjectId { get; set; }
        public long? ProjectItemId { get; set; }
        public long? ProjectPhaseId { get; set; }
        public long? ProjectStageId { get; set; }
        public long? ProjectSubStageId { get; set; }
        public long? ProjectVariationId { get; set; }
        public long? OrderLineId { get; set; }
        public long? SageDatabaseId { get; set; }
        public long? TaxCodeId { get; set; }
        public long? CurrentStep { get; set; }
        public long? CustomRouteId { get; set; }
        public long? CurrentStepApprovalCount { get; set; }
        public long? SupplierId { get; set; }
        public long? LineNumber { get; set; }
        public long? StockItemId { get; set; }
        public long? AccountNumberId { get; set; }
        public long? WarehouseId { get; set; }
        public long? LineStatusId { get; set; }
        public decimal? Quantity { get; set; }
        public decimal? UnitPrice { get; set; }
        public decimal? Discount { get; set; }
        public decimal? TotalPrice { get; set; }
        public decimal? BuyingMultOfStockUnit { get; set; }
        public decimal? PricingMultOfStockUnit { get; set; }
        public string? Description { get; set; }
        public string? LineStatus { get; set; }
        public string? ItemCode { get; set; }
        public string? UpdatedUser { get; set; }
        public string? PricingUnitDescription { get; set; }
        public string? BuyingUnitDescription { get; set; }
        public string? SupplierPartNo { get; set; }
        public string? RejectReason { get; set; }
        public string? ErrorMessage { get; set; }
        public string? LineType { get; set; }
        public bool? Deleted { get; set; }
        public bool? CustomRoute { get; set; }
        public bool? Submitted { get; set; }
        public bool? ResetRoute { get; set; }
        public bool? OverBudget { get; set; }
        public bool? AmendedDescription { get; set; }
        public string? AmendedDescriptionText { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public DateTime? RequestedDeliveryDate { get; set; }
        public string? Analysis1 { get; set; }
        public string? Analysis2 { get; set; }
        public string? Analysis3 { get; set; }
        public string? Analysis4 { get; set; }
        public string? Analysis5 { get; set; }
        public string? Analysis6 { get; set; }
        public string? Analysis7 { get; set; }
        public string? Analysis8 { get; set; }
        public string? Analysis9 { get; set; }
        public string? Analysis10 { get; set; }
        public string? Analysis11 { get; set; }
        public string? Analysis12 { get; set; }
        public string? Analysis13 { get; set; }
        public string? Analysis14 { get; set; }
        public string? Analysis15 { get; set; }
        public string? Analysis16 { get; set; }
        public string? Analysis17 { get; set; }
        public string? Analysis18 { get; set; }
        public string? Analysis19 { get; set; }
        public string? Analysis20 { get; set; }
        public long? PlannedPurchaseId { get; set; }
        public bool? Process { get; set; }
        public string? Note { get; set; }
        public long? OrderId { get; set; }
    }
}