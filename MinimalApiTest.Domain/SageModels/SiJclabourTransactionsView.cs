using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiJclabourTransactionsView
    {
        public long SiJcTrnId { get; set; }
        public long? SiJcJobId { get; set; }
        public long? PlpostedSupplierTranId { get; set; }
        public long? SlpostedCustomerTranId { get; set; }
        public string TransType { get; set; } = null!;
        public long? PoporderReturnId { get; set; }
        public long? SoporderReturnId { get; set; }
        public long? StockItemId { get; set; }
        public long? PlsupplierAccountId { get; set; }
        public long? SlcustomerAccountId { get; set; }
        public string? Deleted { get; set; }
        public string? StockType { get; set; }
        public long? SiJcchdId { get; set; }
        public long? SiJcEmpId { get; set; }
        public long? PoporderReturnLineId { get; set; }
        public long? SoporderReturnLineId { get; set; }
        public long? TransactionHistoryId { get; set; }
        public bool? IsPostedToNominal { get; set; }
        public long? NlpostedNominalTranId { get; set; }
        public long? NlpendingNominalTranId { get; set; }
        public long? TransId { get; set; }
        public DateTime? TransDate { get; set; }
        public string? StockItemText { get; set; }
        public decimal? Quantity { get; set; }
        public string? Completed { get; set; }
        public decimal? LabRate { get; set; }
        public decimal? CommitQuantity { get; set; }
        public decimal? ActualQuantity { get; set; }
        public decimal? UnitValue { get; set; }
        public decimal? ResourceChargeRateNumber { get; set; }
        public decimal? ResourceChargeRate { get; set; }
        public decimal? ResourcePercentageMarkup { get; set; }
        public string? InvoiceCreditNumber { get; set; }
        public DateTime? InvoiceCreditDate { get; set; }
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
        public DateTime? SpareDate1 { get; set; }
        public DateTime? SpareDate2 { get; set; }
        public DateTime? SpareDate3 { get; set; }
        public DateTime? SpareDate4 { get; set; }
        public DateTime? SpareDate5 { get; set; }
        public DateTime? DeletedDate { get; set; }
        public string? DeletedUser { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string? UpdatedUser { get; set; }
        public bool? DisplayNoCosts { get; set; }
        public long? WolineId { get; set; }
        public string? CaseNumber { get; set; }
        public long? CaseId { get; set; }
        public long? SysaccountingPeriodId { get; set; }
        public long? SysfinancialYearId { get; set; }
        public short? AccountingPeriod { get; set; }
        public short? AccountingPeriodYear { get; set; }
        public DateTime? PeriodStartDate { get; set; }
        public DateTime? PeriodEndDate { get; set; }
        public decimal? AutoIssuedQuantity { get; set; }
        public bool? Billed { get; set; }
        public DateTime? BilledDate { get; set; }
        public string? BilledInvoiceNo { get; set; }
        public long? BilledUrn { get; set; }
        public decimal? ApprovedPaymentAmount { get; set; }
        public long? SijobPhaseId { get; set; }
        public long? SijobStageId { get; set; }
        public long? SijobSubStageId { get; set; }
        public long? SioperationId { get; set; }
        public bool? IsNominalRec { get; set; }
        public decimal? UnitSellingPrice { get; set; }
        public bool? NonChargeable { get; set; }
        public decimal? PayRateValue { get; set; }
        public long? SiconConstructionApplicationId { get; set; }
        public long? SiJcVariationId { get; set; }
        public DateTime? WeekBeginDate { get; set; }
        public DateTime? WeekEndDate { get; set; }
        public bool? IsPopvariance { get; set; }
        public long? AllocationBalanceId { get; set; }
        public string? DocumentReference { get; set; }
        public int? SiconStockTransferItemId { get; set; }
        public long? PopaccrualUrn { get; set; }
        public decimal? StoredExchangeRate { get; set; }
        public long? StoredSyscurrencyId { get; set; }
        public long? NlnominalAccountId { get; set; }
        public bool? ExcludeTransaction { get; set; }
        public string? NlreportType { get; set; }
        public bool? SelfBilled { get; set; }
        public DateTime? SelfBilledDate { get; set; }
        public string? SelfBilledInvoiceNo { get; set; }
        public long? SelfBilledUrn { get; set; }
        public bool? IsApplications { get; set; }
        public string? CostRateDescription { get; set; }
        public string? ChargeOutRateDescription { get; set; }
    }
}
