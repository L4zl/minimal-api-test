using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiWorksOrder
    {
        public long SiWorksOrderId { get; set; }
        public long? Bomid { get; set; }
        public long? StockItemId { get; set; }
        public long? Sijcjobid { get; set; }
        public long? Sijcchdid { get; set; }
        public decimal? Wocost { get; set; }
        public DateTime? WocreatedDate { get; set; }
        public string? Woname { get; set; }
        public string? Wonumber { get; set; }
        public decimal? Woquantity { get; set; }
        public string? Wostatus { get; set; }
        public decimal? WowaterDeviation { get; set; }
        public string? Wocomments { get; set; }
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
        public string? BomVersion { get; set; }
        public long? WarehouseId { get; set; }
        public long? ComponentWarehouseId { get; set; }
        public long? SoporderReturnLineId { get; set; }
        public DateTime? WodueDate { get; set; }
        public decimal? WoperBatchCost { get; set; }
        public decimal? WoperUnitCost { get; set; }
        public string? Workshop { get; set; }
        public long? SiWorksOrderStageId { get; set; }
        public long? ParentWolineId { get; set; }
        public decimal? WoproductionLeadTime { get; set; }
        public bool? Overtime { get; set; }
        public bool? Printed { get; set; }
        public decimal? PercentStockCover { get; set; }
        public bool? Scheduled { get; set; }
        public decimal? Margin { get; set; }
        public decimal? TotalUnitSellingPrice { get; set; }
        public bool? Deleted { get; set; }
        public long? ToWorksOrderId { get; set; }
        public bool? ConvertedToWo { get; set; }
        public long? Bomlevel { get; set; }
        public long? ParentWoid { get; set; }
        public long? ChildWoid { get; set; }
        public DateTime? StartDate { get; set; }
        public string? SopworksOrderText { get; set; }
        public string? SoplineWorksOrderText { get; set; }
        public bool UseDefaultStaging { get; set; }
        public long? SiconContractLineId { get; set; }
        public long? UltimateParentId { get; set; }
        public long? Level { get; set; }
        public long? SiJobPhaseId { get; set; }
        public long? SiJobStageId { get; set; }
        public long? SiJobSubStageId { get; set; }
        public long? SiJcVariationId { get; set; }
        public string? WonumberSequence { get; set; }
        public decimal? EstimateNumberOfHrsToComplete { get; set; }
        public long? JobManagerId { get; set; }
        public DateTime? Updateddate { get; set; }
        public string? Updateduser { get; set; }
        public decimal? OriginalEstimateCost { get; set; }
        public DateTime? WogeneratedDate { get; set; }
        public long? WostatusId { get; set; }
        public bool? Continuous { get; set; }
        public long? WostatusEnumId { get; set; }
        public decimal OverheadRecovery { get; set; }
        public bool? UnConfirmedCost { get; set; }
    }
}
