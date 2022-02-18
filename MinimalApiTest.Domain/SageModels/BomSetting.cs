﻿using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class BomSetting
    {
        public long BomSettingId { get; set; }
        public bool UseVersionControl { get; set; }
        public bool KeepChangeHistory { get; set; }
        public decimal ComponentSequenceStart { get; set; }
        public decimal ComponentSequenceInterval { get; set; }
        public decimal OperationSequenceStart { get; set; }
        public decimal OperationSequenceInterval { get; set; }
        public bool OrderSequenceByStockCode { get; set; }
        public bool OrderSequenceByReference { get; set; }
        public bool AllowBomCreationForComponent { get; set; }
        public bool WarnForDuplicateComponents { get; set; }
        public bool SummariseNominalPostings { get; set; }
        public bool AllowEditOfActiveBoms { get; set; }
        public decimal DefaultBuildQuantity { get; set; }
        public decimal DefaultCostQuantity { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public decimal? VersionNumberIncrement { get; set; }
        public bool AlwaysRecostSubAssemblies { get; set; }
        public bool DefaultToRollUpCosts { get; set; }
        public bool IncludeMiscellaneousCosts { get; set; }
        public bool CalculateOverheads { get; set; }
        public bool RecostWhenSaving { get; set; }
        public bool? PromptWhenZeroStockLevels { get; set; }
        public bool? PromptWhenStockHasZeroCosts { get; set; }
        public bool PostUnitCostsAfterCosting { get; set; }
        public bool PostUnitCostsForPhantoms { get; set; }
        public bool UseManningLevel { get; set; }
        public short CostSubAssemblyUsingType { get; set; }
        public bool CostBasisPriceType { get; set; }
        public bool AllowDecimalMaximumBuild { get; set; }
        public bool TrialKittingTreatStockOnOrderAsAvailable { get; set; }
        public bool TrialKittingOnlyShowShortages { get; set; }
        public bool TrialKittingReportComponentShortages { get; set; }
        public bool TrialKittingReportSubassemblyShortages { get; set; }
        public short TrialKittingSubassemblyTreatmentType { get; set; }
        public bool UseSpecificSubassemblyVersion { get; set; }
        public short DefaultBuildPackageType { get; set; }
        public short TrialKittingShortageFoundAction { get; set; }
        public bool AllowAllocationComponentChanges { get; set; }
        public bool AllowAllocationSubstitutions { get; set; }
        public bool AllowOverUnderAllocation { get; set; }
        public string WopNumberPrefix { get; set; } = null!;
        public short WopNumberZeros { get; set; }
        public long NextWopNumber { get; set; }
        public bool UseMostRecentCostForComponents { get; set; }
        public bool UseLastCalculatedPriceForSubassemblies { get; set; }
        public bool BuildReportAutomaticallyPrinted { get; set; }
        public bool UseAllocationNumberForBuildPostings { get; set; }
        public bool CalculateScrapWhenTrialKitting { get; set; }
        public bool CalculateScrapWhenCosting { get; set; }
        public bool CalculateScrapWhenAllocating { get; set; }
        public bool CalculateScrapWhenRecordingBuiltItems { get; set; }
        public bool CalculateScrapWhenPerformingMaximumBuild { get; set; }
        public bool CalculateScrapWhenExploding { get; set; }
        public bool CalculateScrapWhenImploding { get; set; }
        public bool? PrintConsolidatedPickingList { get; set; }
        public string HierarchySeparator { get; set; } = null!;
        public bool PromptForSupplier { get; set; }
        public short ResourceCostRateSource { get; set; }
        public bool PrintPickingListAfterAllocation { get; set; }
        public bool PrintReportAfterUndoAllocation { get; set; }
        public bool PrintReverseBuildReport { get; set; }
        public byte CostAnalysisDateRange { get; set; }
        public bool CostAnalysisFilterByQuantity { get; set; }
        public byte CostAnalysisFilterOperator { get; set; }
        public byte CostAnalysisShowSubassemblyCostings { get; set; }
        public byte CostAnalysisShowAllVersions { get; set; }
        public bool? CostAnalysisShowUnitCostIncludingOverheads { get; set; }
        public bool CostAnalysisShowUnitCost { get; set; }
        public bool CostAnalysisShowSuggestedSellingPrice { get; set; }
        public bool CostAnalysisShowProfit { get; set; }
        public byte CostAnalysisColourPalette { get; set; }
        public bool CostAnalysisShowPointLabels { get; set; }
        public bool? CostAnalysisIncludeOverheadsInDistribution { get; set; }
        public bool CostAnalysisGroupDistributionByCostHeadingType { get; set; }
        public byte CostAnalysisShowDistributionAs { get; set; }
        public long? BuildRoundingNominalAccountId { get; set; }
        public string? BuildRoundingNominalAccountNumber { get; set; }
        public string? BuildRoundingNominalAccountCostCentre { get; set; }
        public string? BuildRoundingNominalAccountDepartment { get; set; }
        public bool CalculateAndPostWeightWhenSaving { get; set; }
        public bool UseTopLevelBomBuildPackageMarkup { get; set; }
        public DateTime DateTimeUpdated { get; set; }
    }
}
