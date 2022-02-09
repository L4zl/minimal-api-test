﻿namespace MinimalApiTest.Domain.Models
{
    public partial class OrderLine
    {
        public long OrderLineId { get; set; }
        public long? OrderId { get; set; }
        public decimal? Quantity { get; set; }
        public string? Description { get; set; }
        public decimal? UnitPrice { get; set; }
        public decimal? Discount { get; set; }
        public long? AccountNumberId { get; set; }
        public bool? Deleted { get; set; }
        public long? WaitingForId { get; set; }
        public string? WaitingForApprovalType { get; set; }
        public string? LineStatus { get; set; }
        public bool? OverBudget { get; set; }
        public bool? SentToSage { get; set; }
        public decimal? SentToSageValue { get; set; }
        public decimal? TotalPrice { get; set; }
        public string? LineType { get; set; }
        public long? ProjectCodeId { get; set; }
        public long? ProjectItemId { get; set; }
        public long? ProjectPhaseId { get; set; }
        public long? ProjectStageId { get; set; }
        public long? ProjectSubStageId { get; set; }
        public long? ProjectVariationId { get; set; }
        public long? SageOrderLineId { get; set; }
        public int? LineStatusId { get; set; }
        public long? StockItemId { get; set; }
        public long? SageDatabaseId { get; set; }
        public string? ItemCode { get; set; }
        public long? TaxCodeId { get; set; }
        public long? WarehouseId { get; set; }
        public int? CurrentStep { get; set; }
        public long? ContractId { get; set; }
        public long? ContractItemId { get; set; }
        public decimal? QuantityReceived { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string? UpdatedUser { get; set; }
        public bool? ShowCommentOnSupplierDocs { get; set; }
        public string? PricingUnitDescription { get; set; }
        public string? BuyingUnitDescription { get; set; }
        public decimal? BuyingMultOfStockUnit { get; set; }
        public decimal? PricingMultOfStockUnit { get; set; }
        public DateTime? RequestedDeliveryDate { get; set; }
        public string? SupplierPartNo { get; set; }
        public bool? CustomRoute { get; set; }
        public long? CustomRouteId { get; set; }
        public string? RejectReason { get; set; }
        public long? CurrentStepApprovalCount { get; set; }
        public decimal? QuantityInvoiced { get; set; }
        public long? PccostItemId { get; set; }
        public bool? Submitted { get; set; }
        public long? ConstructVariationId { get; set; }
        public long? ConstructLineTypeId { get; set; }
        public long? LineNumber { get; set; }
        public bool? AmendedDescription { get; set; }
        public string? AmendedDescriptionText { get; set; }
        public long? PostedCostingDetailId { get; set; }
        public long? ConfirmationIntentType { get; set; }
        public decimal? MatchedExpenseLinesNetValue { get; set; }
        public string? ErrorMessage { get; set; }
        public string? IdentificationNumber { get; set; }
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
        public bool ResetRoute { get; set; }
        public string? MobileGuid { get; set; }
        public string? JobManager { get; set; }
        public long? PlannedPurchaseId { get; set; }
        public string? SpareText1 { get; set; }
        public string? SpareText2 { get; set; }
        public string? SpareText3 { get; set; }
        public DateTime? SpareDate1 { get; set; }
        public DateTime? SpareDate2 { get; set; }
        public DateTime? SpareDate3 { get; set; }
        public bool SpareBit1 { get; set; }
        public bool SpareBit2 { get; set; }
        public bool SpareBit3 { get; set; }
        public decimal? SpareNumber1 { get; set; }
        public decimal? SpareNumber2 { get; set; }
        public decimal? SpareNumber3 { get; set; }
        public long? ProjectRequisitionLineId { get; set; }
    }
}