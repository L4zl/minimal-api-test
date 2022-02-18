﻿using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiWorksOrderLine
    {
        public long SiWorksOrderLineId { get; set; }
        public long? SiWorksOrderId { get; set; }
        public long? LineTypeId { get; set; }
        public long? AllocationId { get; set; }
        public long? BomlineTypeId { get; set; }
        public long? ItemId { get; set; }
        public long? WarehouseId { get; set; }
        public long? BomcostItemId { get; set; }
        public decimal? Cost { get; set; }
        public decimal? UnitCost { get; set; }
        public bool? IsIssued { get; set; }
        public string? LineComment { get; set; }
        public string? Instructions { get; set; }
        public decimal? LineNumber { get; set; }
        public decimal? Quantity { get; set; }
        public string? SpareText1 { get; set; }
        public string? SpareText2 { get; set; }
        public string? SpareText3 { get; set; }
        public string? SpareText4 { get; set; }
        public string? SpareText5 { get; set; }
        public decimal? SpareNumber1 { get; set; }
        public decimal? SpareNumber2 { get; set; }
        public decimal? SpareNumber3 { get; set; }
        public decimal? SpareNumber4 { get; set; }
        public decimal? SpareNumber5 { get; set; }
        public string? SpareMemo1 { get; set; }
        public string? SpareMemo2 { get; set; }
        public string? BinName { get; set; }
        public decimal? LineCost { get; set; }
        public decimal? QuantityAllocated { get; set; }
        public decimal? QuantityIssued { get; set; }
        public int? EstimateHours { get; set; }
        public byte? EstimateMinutes { get; set; }
        public byte? EstimateSeconds { get; set; }
        public int? ActualHours { get; set; }
        public byte? ActualMinutes { get; set; }
        public byte? ActualSeconds { get; set; }
        public long? BomunitId { get; set; }
        public string? CostName { get; set; }
        public string? CostDescription { get; set; }
        public long? BomcostTypeId { get; set; }
        public long? ChildWoid { get; set; }
        public DateTime? EstimateEndDate { get; set; }
        public bool? Picked { get; set; }
        public decimal? FutureBuyPrice { get; set; }
        public string? ReasonForFutureBuyPrice { get; set; }
        public long? PlsupplierAccountId { get; set; }
        public string? ColourForExpediting { get; set; }
        public string? OrderReference { get; set; }
        public DateTime? EstimateStartDate { get; set; }
        public bool? TimeLineCompleted { get; set; }
        public long? TimeLineParentId { get; set; }
        public long? PoporderReturnId { get; set; }
        public string? SubContractDeliveryNotes { get; set; }
        public decimal? BudgetQuantity { get; set; }
        public decimal? BudgetUnitCost { get; set; }
        public decimal? UnitSellingPrice { get; set; }
        public bool? Deleted { get; set; }
        public bool? IncludedInBudget { get; set; }
        public long? UomrefId { get; set; }
        public decimal? Uomquantity { get; set; }
        public DateTime? Updateddate { get; set; }
        public string? Updateduser { get; set; }
        public string? LineStatus { get; set; }
        public bool FixedLength { get; set; }
        public decimal? FixedQuantity { get; set; }
        public bool OldSubContract { get; set; }
        public bool UseSupplierNominalCode { get; set; }
        public decimal? OriginalQuantity { get; set; }
        public string? LabourType { get; set; }
        public long? SiOperationId { get; set; }
        public long? OpOperationResourceId { get; set; }
        public string? LineText { get; set; }
        public decimal? ScrapPercentage { get; set; }
        public bool? IncludesScrap { get; set; }
        public bool? BulkIssueItem { get; set; }
        public string? LabourMachineReference { get; set; }
        public string? LabourMachineDescription { get; set; }
        public string? OperationReference { get; set; }
        public string? OperationDescription { get; set; }
        public string? OperationPhase { get; set; }
        public string? MachineType { get; set; }
        public string? ExpeditingColour { get; set; }
        public decimal? InitialBomquantity { get; set; }
        public long? SiOperationLineId { get; set; }
        public decimal? PickedQuantity { get; set; }
        public decimal? OverheadRecoveryPercentage { get; set; }
        public bool CommentOnSubContracts { get; set; }
        public decimal? BatchQuantity { get; set; }
        public decimal? PartQuantity { get; set; }
    }
}