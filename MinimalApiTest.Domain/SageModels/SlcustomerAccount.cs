using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SlcustomerAccount
    {
        public SlcustomerAccount()
        {
            CbdirectDebitTrans = new HashSet<CbdirectDebitTran>();
            CustDeliveryAddresses = new HashSet<CustDeliveryAddress>();
            InverseAssociatedHeadOfficeAccount = new HashSet<SlcustomerAccount>();
            InvinvoiceCredits = new HashSet<InvinvoiceCredit>();
            PcanalysisFieldValues = new HashSet<PcanalysisFieldValue>();
            SlaccountMemos = new HashSet<SlaccountMemo>();
            SlallocationHeaders = new HashSet<SlallocationHeader>();
            SlcustomerAlerts = new HashSet<SlcustomerAlert>();
            SlcustomerCardReferences = new HashSet<SlcustomerCardReference>();
            SlcustomerContacts = new HashSet<SlcustomerContact>();
            SlcustomerDocuments = new HashSet<SlcustomerDocument>();
            SlcustomerLocations = new HashSet<SlcustomerLocation>();
            SlcustomerPeriodValues = new HashSet<SlcustomerPeriodValue>();
            SlcustomerPriceMappings = new HashSet<SlcustomerPriceMapping>();
            SlcustomerYearValues = new HashSet<SlcustomerYearValue>();
            SlhistoricalCustomerTrans = new HashSet<SlhistoricalCustomerTran>();
            SlpendCustomerBatchTrans = new HashSet<SlpendCustomerBatchTran>();
            SlpendCustomerTrans = new HashSet<SlpendCustomerTran>();
            SlpostedCustomerTrans = new HashSet<SlpostedCustomerTran>();
            SopinvoiceCreditArches = new HashSet<SopinvoiceCreditArch>();
            SopinvoiceCredits = new HashSet<SopinvoiceCredit>();
            SoporderReturnArches = new HashSet<SoporderReturnArch>();
            SoporderReturns = new HashSet<SoporderReturn>();
            SoppreferredItems = new HashSet<SoppreferredItem>();
            SopsettingCashOrderAccounts = new HashSet<Sopsetting>();
            SopsettingProspectQuoteAccounts = new HashSet<Sopsetting>();
            TemcustProdMappings = new HashSet<TemcustProdMapping>();
        }

        public long SlcustomerAccountId { get; set; }
        public string CustomerAccountNumber { get; set; } = null!;
        public string CustomerAccountName { get; set; } = null!;
        public string CustomerAccountShortName { get; set; } = null!;
        public decimal AccountBalance { get; set; }
        public decimal CreditLimit { get; set; }
        public long SyscurrencyId { get; set; }
        public long SysexchangeRateTypeId { get; set; }
        public long SyscountryCodeId { get; set; }
        public long DefaultSystaxRateId { get; set; }
        public string TaxRegistrationNumber { get; set; } = null!;
        public short MonthsToKeepTransactionsFor { get; set; }
        public string DefaultOrderPriority { get; set; } = null!;
        public long? SlfinanceChargeId { get; set; }
        public string DefaultNominalAccountNumber { get; set; } = null!;
        public string DefaultNominalCostCentre { get; set; } = null!;
        public string DefaultNominalDepartment { get; set; } = null!;
        public long SysaccountTypeId { get; set; }
        public decimal EarlySettlementDiscountPercent { get; set; }
        public short DaysEarlySettlementDiscApplies { get; set; }
        public short PaymentTermsInDays { get; set; }
        public long SyspaymentTermsBasisId { get; set; }
        public bool UseConsolidatedBilling { get; set; }
        public decimal InvoiceLineDiscountPercent { get; set; }
        public decimal InvoiceDiscountPercent { get; set; }
        public long SlassociatedOfficeTypeId { get; set; }
        public long? AssociatedHeadOfficeAccountId { get; set; }
        public bool SendCopyStatementToBranch { get; set; }
        public long? CustomerDiscountGroupId { get; set; }
        public long? PriceBandId { get; set; }
        public long? OrderValueDiscountId { get; set; }
        public bool AccountIsOnHold { get; set; }
        public decimal ValueOfCurrentOrdersInSop { get; set; }
        public DateTime DateAccountDetailsLastChanged { get; set; }
        public DateTime? DateOfLastTransaction { get; set; }
        public string? EuroAccountNumberCopiedFromTo { get; set; }
        public DateTime? DateEuroAccountCopied { get; set; }
        public bool UseTransactionEmail { get; set; }
        public DateTime? DateFinanceChargeLastRun { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public long? SyscreditBureauId { get; set; }
        public long? SyscreditPositionId { get; set; }
        public string TradingTerms { get; set; } = null!;
        public string CreditReference { get; set; } = null!;
        public int AverageTimeToPay { get; set; }
        public DateTime? AccountOpened { get; set; }
        public DateTime? LastCreditReview { get; set; }
        public DateTime? NextCreditReview { get; set; }
        public DateTime? ApplicationDate { get; set; }
        public DateTime? DateReceived { get; set; }
        public bool TermsAgreed { get; set; }
        public bool UseTaxCodeAsDefault { get; set; }
        public DateTime? AvgTimeToPayDateLastUpdated { get; set; }
        public string SpareText1 { get; set; } = null!;
        public string SpareText2 { get; set; } = null!;
        public string SpareText3 { get; set; } = null!;
        public decimal SpareNumber1 { get; set; }
        public decimal SpareNumber2 { get; set; }
        public decimal SpareNumber3 { get; set; }
        public DateTime? SpareDate1 { get; set; }
        public DateTime? SpareDate2 { get; set; }
        public DateTime? SpareDate3 { get; set; }
        public bool SpareBit1 { get; set; }
        public bool SpareBit2 { get; set; }
        public bool SpareBit3 { get; set; }
        public string Dunscode { get; set; } = null!;
        public string MainTelephoneAreaCode { get; set; } = null!;
        public string MainTelephoneCountryCode { get; set; } = null!;
        public string MainTelephoneSubscriberNumber { get; set; } = null!;
        public string MainFaxAreaCode { get; set; } = null!;
        public string MainFaxCountryCode { get; set; } = null!;
        public string MainFaxSubscriberNumber { get; set; } = null!;
        public string MainWebsite { get; set; } = null!;
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
        public DateTime DateTimeUpdated { get; set; }
        public long SysaccountStatusId { get; set; }
        public string StatusReason { get; set; } = null!;
        public string PaymentCloudCustomerId { get; set; } = null!;
        public long SlcustomerSyncStatusTypeId { get; set; }

        public virtual SlcustomerAccount? AssociatedHeadOfficeAccount { get; set; }
        public virtual CustomerDiscountGroup? CustomerDiscountGroup { get; set; }
        public virtual SystaxRate DefaultSystaxRate { get; set; } = null!;
        public virtual OrderValueDiscount? OrderValueDiscount { get; set; }
        public virtual PriceBand? PriceBand { get; set; }
        public virtual SlofficeType SlassociatedOfficeType { get; set; } = null!;
        public virtual SlcustomerSyncStatusType SlcustomerSyncStatusType { get; set; } = null!;
        public virtual SlfinanceCharge? SlfinanceCharge { get; set; }
        public virtual SysaccountStatus SysaccountStatus { get; set; } = null!;
        public virtual SysaccountType SysaccountType { get; set; } = null!;
        public virtual SyscountryCode SyscountryCode { get; set; } = null!;
        public virtual SyscreditBureau? SyscreditBureau { get; set; }
        public virtual SyscreditPosition? SyscreditPosition { get; set; }
        public virtual Syscurrency Syscurrency { get; set; } = null!;
        public virtual SysexchangeRateType SysexchangeRateType { get; set; } = null!;
        public virtual SyspaymentTermsBasis SyspaymentTermsBasis { get; set; } = null!;
        public virtual TemcustomerMapping TemcustomerMapping { get; set; } = null!;
        public virtual ICollection<CbdirectDebitTran> CbdirectDebitTrans { get; set; }
        public virtual ICollection<CustDeliveryAddress> CustDeliveryAddresses { get; set; }
        public virtual ICollection<SlcustomerAccount> InverseAssociatedHeadOfficeAccount { get; set; }
        public virtual ICollection<InvinvoiceCredit> InvinvoiceCredits { get; set; }
        public virtual ICollection<PcanalysisFieldValue> PcanalysisFieldValues { get; set; }
        public virtual ICollection<SlaccountMemo> SlaccountMemos { get; set; }
        public virtual ICollection<SlallocationHeader> SlallocationHeaders { get; set; }
        public virtual ICollection<SlcustomerAlert> SlcustomerAlerts { get; set; }
        public virtual ICollection<SlcustomerCardReference> SlcustomerCardReferences { get; set; }
        public virtual ICollection<SlcustomerContact> SlcustomerContacts { get; set; }
        public virtual ICollection<SlcustomerDocument> SlcustomerDocuments { get; set; }
        public virtual ICollection<SlcustomerLocation> SlcustomerLocations { get; set; }
        public virtual ICollection<SlcustomerPeriodValue> SlcustomerPeriodValues { get; set; }
        public virtual ICollection<SlcustomerPriceMapping> SlcustomerPriceMappings { get; set; }
        public virtual ICollection<SlcustomerYearValue> SlcustomerYearValues { get; set; }
        public virtual ICollection<SlhistoricalCustomerTran> SlhistoricalCustomerTrans { get; set; }
        public virtual ICollection<SlpendCustomerBatchTran> SlpendCustomerBatchTrans { get; set; }
        public virtual ICollection<SlpendCustomerTran> SlpendCustomerTrans { get; set; }
        public virtual ICollection<SlpostedCustomerTran> SlpostedCustomerTrans { get; set; }
        public virtual ICollection<SopinvoiceCreditArch> SopinvoiceCreditArches { get; set; }
        public virtual ICollection<SopinvoiceCredit> SopinvoiceCredits { get; set; }
        public virtual ICollection<SoporderReturnArch> SoporderReturnArches { get; set; }
        public virtual ICollection<SoporderReturn> SoporderReturns { get; set; }
        public virtual ICollection<SoppreferredItem> SoppreferredItems { get; set; }
        public virtual ICollection<Sopsetting> SopsettingCashOrderAccounts { get; set; }
        public virtual ICollection<Sopsetting> SopsettingProspectQuoteAccounts { get; set; }
        public virtual ICollection<TemcustProdMapping> TemcustProdMappings { get; set; }
    }
}
