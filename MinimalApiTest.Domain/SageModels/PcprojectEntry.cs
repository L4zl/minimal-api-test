using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class PcprojectEntry
    {
        public PcprojectEntry()
        {
            PcprojectEntryPostings = new HashSet<PcprojectEntryPosting>();
            TsclaimRecords = new HashSet<TsclaimRecord>();
            TstimeRecords = new HashSet<TstimeRecord>();
        }

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
        public DateTime DateTimeCreated { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public long ProjectUrn { get; set; }
        public decimal AmountBilledInBaseCurrency { get; set; }
        public bool IsWiptransaction { get; set; }
        public decimal WipvalueInBaseCurrency { get; set; }
        public decimal WipvalueInDocCurrency { get; set; }
        public string WipnominalAccountNumber { get; set; } = null!;
        public string WipnominalCostCentre { get; set; } = null!;
        public string WipnominalDepartment { get; set; } = null!;
        public long? FinalisationBillId { get; set; }
        public DateTime? FinalisationBillDate { get; set; }
        public DateTime DateTimeUpdated { get; set; }

        public virtual PcbillStatus BillStatus { get; set; } = null!;
        public virtual Syscurrency DocumentCurrency { get; set; } = null!;
        public virtual PcentryType EntryType { get; set; } = null!;
        public virtual Blbill? FinalisationBill { get; set; }
        public virtual SysaccountingPeriod? NominalAccountingPeriod { get; set; }
        public virtual PcfinancialClassification PcfinancialClassification { get; set; } = null!;
        public virtual PcprojectEntryDescriptor PcprojectEntryDescriptor { get; set; } = null!;
        public virtual PcprojectItem ProjectItem { get; set; } = null!;
        public virtual TshumanResource? TshumanResource { get; set; }
        public virtual PcunitOfMeasure? UnitOfMeasureNavigation { get; set; }
        public virtual ICollection<PcprojectEntryPosting> PcprojectEntryPostings { get; set; }
        public virtual ICollection<TsclaimRecord> TsclaimRecords { get; set; }
        public virtual ICollection<TstimeRecord> TstimeRecords { get; set; }
    }
}
