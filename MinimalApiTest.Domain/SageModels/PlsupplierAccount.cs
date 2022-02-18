using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class PlsupplierAccount
    {
        public PlsupplierAccount()
        {
            CbdirectDebitTrans = new HashSet<CbdirectDebitTran>();
            PcanalysisFieldValues = new HashSet<PcanalysisFieldValue>();
            PlaccountMemos = new HashSet<PlaccountMemo>();
            PlallocationHeaders = new HashSet<PlallocationHeader>();
            PlhistoricalSupplierTrans = new HashSet<PlhistoricalSupplierTran>();
            PlpendSupplierBatchTrans = new HashSet<PlpendSupplierBatchTran>();
            PlpendSupplierTrans = new HashSet<PlpendSupplierTran>();
            PlpostedSupplierTrans = new HashSet<PlpostedSupplierTran>();
            PlproposedPayments = new HashSet<PlproposedPayment>();
            PlsupplierBanks = new HashSet<PlsupplierBank>();
            PlsupplierContacts = new HashSet<PlsupplierContact>();
            PlsupplierDocuments = new HashSet<PlsupplierDocument>();
            PlsupplierFactorHouses = new HashSet<PlsupplierFactorHouse>();
            PlsupplierLocations = new HashSet<PlsupplierLocation>();
            PlsupplierPeriodValues = new HashSet<PlsupplierPeriodValue>();
            PlsupplierYearValues = new HashSet<PlsupplierYearValue>();
            PopinvCredDisputes = new HashSet<PopinvCredDispute>();
            PoporderReturnArches = new HashSet<PoporderReturnArch>();
            PoporderReturns = new HashSet<PoporderReturn>();
            PoprequisitionFulfilmentLines = new HashSet<PoprequisitionFulfilmentLine>();
            PoptoReorderWarehouses = new HashSet<PoptoReorderWarehouse>();
            StockItemSuppliers = new HashSet<StockItemSupplier>();
            TemsuppProdMappings = new HashSet<TemsuppProdMapping>();
            TsclaimSheets = new HashSet<TsclaimSheet>();
            TshumanResources = new HashSet<TshumanResource>();
        }

        public long PlsupplierAccountId { get; set; }
        public string SupplierAccountNumber { get; set; } = null!;
        public string SupplierAccountName { get; set; } = null!;
        public string SupplierAccountShortName { get; set; } = null!;
        public decimal AccountBalance { get; set; }
        public decimal CreditLimit { get; set; }
        public long SyscurrencyId { get; set; }
        public long SysexchangeRateTypeId { get; set; }
        public long SyscountryCodeId { get; set; }
        public long? PlfactorHouseId { get; set; }
        public long DefaultSystaxRateId { get; set; }
        public string? TaxRegistrationNumber { get; set; }
        public short MonthsToKeepTransactionsFor { get; set; }
        public string? DefaultOrderPriority { get; set; }
        public string DefaultNominalAccountNumber { get; set; } = null!;
        public string DefaultNominalCostCentre { get; set; } = null!;
        public string DefaultNominalDepartment { get; set; } = null!;
        public long SysaccountTypeId { get; set; }
        public long PlpaymentGroupId { get; set; }
        public decimal EarlySettlementDiscountPercent { get; set; }
        public short DaysEarlySettlementDiscApplies { get; set; }
        public short PaymentTermsInDays { get; set; }
        public long SyspaymentTermsBasisId { get; set; }
        public bool AccountIsOnHold { get; set; }
        public decimal ValueOfCurrentOrdersInPop { get; set; }
        public DateTime? DateAccountDetailsLastChanged { get; set; }
        public DateTime? DateOfLastTransaction { get; set; }
        public string? EuroAccountNumberCopiedFromTo { get; set; }
        public DateTime? DateEuroAccountCopied { get; set; }
        public bool UseTransactionEmail { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public long? SyscreditBureauId { get; set; }
        public long? SyscreditPositionId { get; set; }
        public string TradingTerms { get; set; } = null!;
        public string CreditReference { get; set; } = null!;
        public DateTime? AccountOpened { get; set; }
        public DateTime? LastCreditReview { get; set; }
        public DateTime? NextCreditReview { get; set; }
        public DateTime? ApplicationDate { get; set; }
        public DateTime? DateReceived { get; set; }
        public bool TermsAgreed { get; set; }
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
        public long SagePaymentsStatusId { get; set; }
        public string? SagePaymentsIdentifier { get; set; }
        public bool SagePaymentsHasNote { get; set; }
        public long SysaccountStatusId { get; set; }
        public string StatusReason { get; set; } = null!;

        public virtual SystaxRate DefaultSystaxRate { get; set; } = null!;
        public virtual PlfactorHouse? PlfactorHouse { get; set; }
        public virtual PlpaymentGroup PlpaymentGroup { get; set; } = null!;
        public virtual SagePaymentsSupplierStatus SagePaymentsStatus { get; set; } = null!;
        public virtual SysaccountStatus SysaccountStatus { get; set; } = null!;
        public virtual SysaccountType SysaccountType { get; set; } = null!;
        public virtual SyscountryCode SyscountryCode { get; set; } = null!;
        public virtual SyscreditBureau? SyscreditBureau { get; set; }
        public virtual SyscreditPosition? SyscreditPosition { get; set; }
        public virtual Syscurrency Syscurrency { get; set; } = null!;
        public virtual SysexchangeRateType SysexchangeRateType { get; set; } = null!;
        public virtual SyspaymentTermsBasis SyspaymentTermsBasis { get; set; } = null!;
        public virtual TemsupplierMapping TemsupplierMapping { get; set; } = null!;
        public virtual ICollection<CbdirectDebitTran> CbdirectDebitTrans { get; set; }
        public virtual ICollection<PcanalysisFieldValue> PcanalysisFieldValues { get; set; }
        public virtual ICollection<PlaccountMemo> PlaccountMemos { get; set; }
        public virtual ICollection<PlallocationHeader> PlallocationHeaders { get; set; }
        public virtual ICollection<PlhistoricalSupplierTran> PlhistoricalSupplierTrans { get; set; }
        public virtual ICollection<PlpendSupplierBatchTran> PlpendSupplierBatchTrans { get; set; }
        public virtual ICollection<PlpendSupplierTran> PlpendSupplierTrans { get; set; }
        public virtual ICollection<PlpostedSupplierTran> PlpostedSupplierTrans { get; set; }
        public virtual ICollection<PlproposedPayment> PlproposedPayments { get; set; }
        public virtual ICollection<PlsupplierBank> PlsupplierBanks { get; set; }
        public virtual ICollection<PlsupplierContact> PlsupplierContacts { get; set; }
        public virtual ICollection<PlsupplierDocument> PlsupplierDocuments { get; set; }
        public virtual ICollection<PlsupplierFactorHouse> PlsupplierFactorHouses { get; set; }
        public virtual ICollection<PlsupplierLocation> PlsupplierLocations { get; set; }
        public virtual ICollection<PlsupplierPeriodValue> PlsupplierPeriodValues { get; set; }
        public virtual ICollection<PlsupplierYearValue> PlsupplierYearValues { get; set; }
        public virtual ICollection<PopinvCredDispute> PopinvCredDisputes { get; set; }
        public virtual ICollection<PoporderReturnArch> PoporderReturnArches { get; set; }
        public virtual ICollection<PoporderReturn> PoporderReturns { get; set; }
        public virtual ICollection<PoprequisitionFulfilmentLine> PoprequisitionFulfilmentLines { get; set; }
        public virtual ICollection<PoptoReorderWarehouse> PoptoReorderWarehouses { get; set; }
        public virtual ICollection<StockItemSupplier> StockItemSuppliers { get; set; }
        public virtual ICollection<TemsuppProdMapping> TemsuppProdMappings { get; set; }
        public virtual ICollection<TsclaimSheet> TsclaimSheets { get; set; }
        public virtual ICollection<TshumanResource> TshumanResources { get; set; }
    }
}
