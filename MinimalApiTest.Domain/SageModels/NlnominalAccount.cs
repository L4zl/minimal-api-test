using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class NlnominalAccount
    {
        public NlnominalAccount()
        {
            CbdirectDebitTrans = new HashSet<CbdirectDebitTran>();
            InternalAreas = new HashSet<InternalArea>();
            InverseParentNlnominalAccount = new HashSet<NlnominalAccount>();
            NlaccountMemos = new HashSet<NlaccountMemo>();
            NlaccountPeriodValues = new HashSet<NlaccountPeriodValue>();
            NlaccountYearValues = new HashSet<NlaccountYearValue>();
            NlcashFlowLayoutNominalAccounts = new HashSet<NlcashFlowLayoutNominalAccount>();
            NldefaultNominalAccounts = new HashSet<NldefaultNominalAccount>();
            NlpostedNominalTrans = new HashSet<NlpostedNominalTran>();
            NlreconciliationEnquirySettings = new HashSet<NlreconciliationEnquirySetting>();
            PopadditionalCharges = new HashSet<PopadditionalCharge>();
            Popsettings = new HashSet<Popsetting>();
            ProdGroupNominalCodes = new HashSet<ProdGroupNominalCode>();
            SopadditionalCharges = new HashSet<SopadditionalCharge>();
            SoporderReturnArches = new HashSet<SoporderReturnArch>();
            SoporderReturns = new HashSet<SoporderReturn>();
            SoppaymentMethods = new HashSet<SoppaymentMethod>();
            StockItemNominalCodes = new HashSet<StockItemNominalCode>();
            StockSettings = new HashSet<StockSetting>();
            Stocktakes = new HashSet<Stocktake>();
            WriteOffCategories = new HashSet<WriteOffCategory>();
        }

        public long NlnominalAccountId { get; set; }
        public long NlaccountNumberCostCentreId { get; set; }
        public long NldepartmentId { get; set; }
        public long? NlaccountReportCategoryId { get; set; }
        public long NlaccountTypeId { get; set; }
        public long NlcostCentreId { get; set; }
        public string? ConsolidatedAccountNumber { get; set; }
        public string? ConsolidatedCostCentre { get; set; }
        public string? ConsolidatedDepartment { get; set; }
        public long? ParentNlnominalAccountId { get; set; }
        public string AccountName { get; set; } = null!;
        public string? AccountNumber { get; set; }
        public string? AccountCostCentre { get; set; }
        public string? AccountDepartment { get; set; }
        public int PeriodsToKeepTransactions { get; set; }
        public bool? AllowJournalsToBePosted { get; set; }
        public bool DisplayBalancesInSelectionList { get; set; }
        public bool PostBatchTotalsOnly { get; set; }
        public decimal CreditYearToDate { get; set; }
        public decimal DebitYearToDate { get; set; }
        public decimal BroughtForwardBalance { get; set; }
        public decimal ConsolidatedAdjustment { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public DateTime DateTimeUpdated { get; set; }
        public long? NlreportCategoryBudgetId { get; set; }
        public long? NlaccountSofaCategoryId { get; set; }
        public string AnalysisCode1 { get; set; } = null!;
        public string AnalysisCode2 { get; set; } = null!;
        public string AnalysisCode3 { get; set; } = null!;
        public string AnalysisCode4 { get; set; } = null!;
        public string AnalysisCode5 { get; set; } = null!;
        public string AnalysisCode6 { get; set; } = null!;
        public string AnalysisCode7 { get; set; } = null!;
        public string AnalysisCode8 { get; set; } = null!;
        public string AnalysisCode9 { get; set; } = null!;
        public string AnalysisCode10 { get; set; } = null!;
        public string AnalysisCode11 { get; set; } = null!;
        public string AnalysisCode12 { get; set; } = null!;
        public string AnalysisCode13 { get; set; } = null!;
        public string AnalysisCode14 { get; set; } = null!;
        public string AnalysisCode15 { get; set; } = null!;
        public string AnalysisCode16 { get; set; } = null!;
        public string AnalysisCode17 { get; set; } = null!;
        public string AnalysisCode18 { get; set; } = null!;
        public string AnalysisCode19 { get; set; } = null!;
        public string AnalysisCode20 { get; set; } = null!;
        public long SysaccountStatusId { get; set; }
        public string StatusChangedBy { get; set; } = null!;
        public DateTime? StatusChangedDateTime { get; set; }

        public virtual NlaccountNumberCostCentre NlaccountNumberCostCentre { get; set; } = null!;
        public virtual NlaccountReportCategory? NlaccountReportCategory { get; set; }
        public virtual NlaccountReportCategory? NlaccountSofaCategory { get; set; }
        public virtual NlaccountType NlaccountType { get; set; } = null!;
        public virtual NlcostCentre NlcostCentre { get; set; } = null!;
        public virtual Nldepartment Nldepartment { get; set; } = null!;
        public virtual NlreportCategoryBudget? NlreportCategoryBudget { get; set; }
        public virtual NlnominalAccount? ParentNlnominalAccount { get; set; }
        public virtual SysaccountStatus SysaccountStatus { get; set; } = null!;
        public virtual ICollection<CbdirectDebitTran> CbdirectDebitTrans { get; set; }
        public virtual ICollection<InternalArea> InternalAreas { get; set; }
        public virtual ICollection<NlnominalAccount> InverseParentNlnominalAccount { get; set; }
        public virtual ICollection<NlaccountMemo> NlaccountMemos { get; set; }
        public virtual ICollection<NlaccountPeriodValue> NlaccountPeriodValues { get; set; }
        public virtual ICollection<NlaccountYearValue> NlaccountYearValues { get; set; }
        public virtual ICollection<NlcashFlowLayoutNominalAccount> NlcashFlowLayoutNominalAccounts { get; set; }
        public virtual ICollection<NldefaultNominalAccount> NldefaultNominalAccounts { get; set; }
        public virtual ICollection<NlpostedNominalTran> NlpostedNominalTrans { get; set; }
        public virtual ICollection<NlreconciliationEnquirySetting> NlreconciliationEnquirySettings { get; set; }
        public virtual ICollection<PopadditionalCharge> PopadditionalCharges { get; set; }
        public virtual ICollection<Popsetting> Popsettings { get; set; }
        public virtual ICollection<ProdGroupNominalCode> ProdGroupNominalCodes { get; set; }
        public virtual ICollection<SopadditionalCharge> SopadditionalCharges { get; set; }
        public virtual ICollection<SoporderReturnArch> SoporderReturnArches { get; set; }
        public virtual ICollection<SoporderReturn> SoporderReturns { get; set; }
        public virtual ICollection<SoppaymentMethod> SoppaymentMethods { get; set; }
        public virtual ICollection<StockItemNominalCode> StockItemNominalCodes { get; set; }
        public virtual ICollection<StockSetting> StockSettings { get; set; }
        public virtual ICollection<Stocktake> Stocktakes { get; set; }
        public virtual ICollection<WriteOffCategory> WriteOffCategories { get; set; }
    }
}
