using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class PcprojectEntryVw
    {
        public long PcprojectEntryId { get; set; }
        public decimal ChargeRateInBaseCurrency { get; set; }
        public decimal CostRateInBaseCurrency { get; set; }
        public long? UnitOfMeasure { get; set; }
        public DateTime? TransactionDate { get; set; }
        public long PcprojectEntryDescriptorId { get; set; }
        public decimal GoodsAmountInBaseCurrency { get; set; }
        public decimal UpliftValueInBaseCurrency { get; set; }
        public string Narrative { get; set; } = null!;
        public string NominalAccountNumber { get; set; } = null!;
        public string NominalCostCentre { get; set; } = null!;
        public string NominalDepartment { get; set; } = null!;
        public long ProjectItemId { get; set; }
        public decimal Quantity { get; set; }
        public string Reference { get; set; } = null!;
        public string SecondReference { get; set; } = null!;
        public long? SourceEntryId { get; set; }
        public long? NominalAccountingPeriodId { get; set; }
        public decimal TaxAmountInBaseCurrency { get; set; }
        public string TaxCode { get; set; } = null!;
        public string TransactionAnalysisCode { get; set; } = null!;
        public decimal ValueToBillInBaseCurrency { get; set; }
        public long? TshumanResourceId { get; set; }
        public long SysmoduleId { get; set; }
        public long Urn { get; set; }
        public string User { get; set; } = null!;
        public int UserNumber { get; set; }
        public string UnitDescription { get; set; } = null!;
        public long EntryTypeId { get; set; }
        public long? ParentEntryId { get; set; }
        public decimal RevenueRateInBaseCurrency { get; set; }
        public decimal TotalOverheadInBaseCurrency { get; set; }
        public string ProjectCode { get; set; } = null!;
        public long BillStatusId { get; set; }
        public string ItemName { get; set; } = null!;
        public long PcfinancialClassificationId { get; set; }
        public long? Source { get; set; }
        public string InQueryIndicator { get; set; } = null!;
        public decimal ExchangeRate { get; set; }
        public decimal SettlementDiscountAmount { get; set; }
        public long DocumentCurrencyId { get; set; }
        public decimal ChargeRateInDocCurrency { get; set; }
        public decimal CostRateInDocCurrency { get; set; }
        public decimal GoodsAmountInDocCurrency { get; set; }
        public decimal UpliftValueInDocCurrency { get; set; }
        public decimal ValueToBillInDocCurrency { get; set; }
        public decimal TaxAmountInDocCurrency { get; set; }
        public decimal RevenueRateInDocCurrency { get; set; }
        public decimal TotalOverheadInDocCurrency { get; set; }
        public decimal DiscountAmountInDocCurrency { get; set; }
        public decimal DiscountAmountInBaseCurrency { get; set; }
        public string CustomerAccountNumber { get; set; } = null!;
        public string SupplierAccountNumber { get; set; } = null!;
        public string StockItemCode { get; set; } = null!;
        public long ProjectUrn { get; set; }
        public string WipnominalAccountNumber { get; set; } = null!;
        public string WipnominalCostCentre { get; set; } = null!;
        public string WipnominalDepartment { get; set; } = null!;
        public decimal WipvalueInBaseCurrency { get; set; }
        public string? FinalisationBillNumber { get; set; }
        public DateTime? FinalisationBillDate { get; set; }
        public bool IsWiptransaction { get; set; }
        public decimal FinalisedCostValue { get; set; }
        public decimal FinalisedUpliftValue { get; set; }
        public decimal PotentialGoodsAmount { get; set; }
        public decimal ActualGoodsAmount { get; set; }
        public decimal PotentialUpliftValue { get; set; }
        public decimal ActualUpliftValue { get; set; }
        public decimal AmountBilledInBaseCurrency { get; set; }
    }
}
