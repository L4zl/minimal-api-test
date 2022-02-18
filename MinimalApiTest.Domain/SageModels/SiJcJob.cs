using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiJcJob
    {
        public long SiJcJobId { get; set; }
        public string? JobNumber { get; set; }
        public string? CustomerName { get; set; }
        public string? JobManager { get; set; }
        public string? Description { get; set; }
        public string? Deleted { get; set; }
        public long? JobAnalysisId { get; set; }
        public DateTime? StartDate { get; set; }
        public string? AnalysisType1 { get; set; }
        public string? AnalysisType2 { get; set; }
        public string? AnalysisType3 { get; set; }
        public string? AnalysisType4 { get; set; }
        public string? AnalysisType5 { get; set; }
        public string? AnalysisType6 { get; set; }
        public string? AnalysisType7 { get; set; }
        public DateTime? PlanCompDate { get; set; }
        public DateTime? ActualCompDate { get; set; }
        public decimal? PercentageComplete { get; set; }
        public decimal? JobWipvalue { get; set; }
        public decimal? JobProfitValue { get; set; }
        public decimal? MarkupPercentage { get; set; }
        public long? ParentId { get; set; }
        public long? TraderAccountId { get; set; }
        public string? JobNotes { get; set; }
        public int? DftResChargeRateNumber { get; set; }
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
        public DateTime? DeletedDate { get; set; }
        public string? DeletedUser { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string? UpdatedUser { get; set; }
        public decimal? Summary { get; set; }
        public string? Jcstatus { get; set; }
        public decimal? PercentStockCover { get; set; }
        public DateTime? PracticalCompletionDate { get; set; }
        public DateTime? DefectsEndDate { get; set; }
        public int? DftResCostRateNumber { get; set; }
        public int? ChargeableType { get; set; }
        public string? Ponumber { get; set; }
        public string? AddressPostalName { get; set; }
        public string? AddressLine1 { get; set; }
        public string? AddressLine2 { get; set; }
        public string? AddressLine3 { get; set; }
        public string? AddressLine4 { get; set; }
        public string? AddressCity { get; set; }
        public string? AddressPostCode { get; set; }
        public string? AddressContact { get; set; }
        public string? AddressTelephone { get; set; }
        public string? AddressFax { get; set; }
        public string? AddressEmail { get; set; }
        public long? CustDeliveryAddressId { get; set; }
        public long? SyscurrencyId { get; set; }
        public long? LastC2cperiodId { get; set; }
        public string? LastC2cbyUser { get; set; }
        public DateTime? LastC2cdateTime { get; set; }
        public string? LastC2cperiodString { get; set; }
        public long? LastR2cperiodId { get; set; }
        public string? LastR2cbyUser { get; set; }
        public DateTime? LastR2cdateTime { get; set; }
        public string? LastR2cperiodString { get; set; }
        public bool? JobDepartmentOverride { get; set; }
        public string? JobDepartmentOverrideCode { get; set; }
        public bool? JobCostCentreOverride { get; set; }
        public string? JobCostCentreOverrideCode { get; set; }
        public decimal? TotalRevisedCost { get; set; }
        public decimal? TotalRevisedRevenue { get; set; }
        public int? LastC2cweek { get; set; }
        public int? LastC2cyear { get; set; }
        public bool? ExcludeFromJobList { get; set; }
        public bool? IsEstimate { get; set; }
        public bool? IsTemplate { get; set; }
        public bool? AllJobHeadersAvailable { get; set; }
        public DateTime? JobCreatedDateTime { get; set; }
        public string? JobCreatedByUserId { get; set; }
        public bool? LockPlannedPurchaseBudgets { get; set; }
        public bool? UseJobChargeRates { get; set; }
        public string? SiteNotes { get; set; }
        public string? ObjectiveSummary { get; set; }
        public long? SiconCrmpersonId { get; set; }
        public bool? JobInternalAreaOverride { get; set; }
        public string? JobInternalAreaOverrideArea { get; set; }
    }
}
