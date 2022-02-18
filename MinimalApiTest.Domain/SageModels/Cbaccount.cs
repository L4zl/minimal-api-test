using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class Cbaccount
    {
        public Cbaccount()
        {
            CbaccountContacts = new HashSet<CbaccountContact>();
            CbaccountMemos = new HashSet<CbaccountMemo>();
            CbbankFeedTransactions = new HashSet<CbbankFeedTransaction>();
            CbbankLocations = new HashSet<CbbankLocation>();
            CbbankStatements = new HashSet<CbbankStatement>();
            CbcloudBankAccounts = new HashSet<CbcloudBankAccount>();
            CbdirectDebitTrans = new HashSet<CbdirectDebitTran>();
            CbdraftBankStatements = new HashSet<CbdraftBankStatement>();
            CbpaymentCloudProviderBanks = new HashSet<CbpaymentCloudProviderBank>();
            CbpendAccountTrans = new HashSet<CbpendAccountTran>();
            CbpostedAccountTrans = new HashSet<CbpostedAccountTran>();
            Cbsettings = new HashSet<Cbsetting>();
            CbshortTermCashProjectionAccounts = new HashSet<CbshortTermCashProjectionAccount>();
            Nlsettings = new HashSet<Nlsetting>();
            PlhistoricalSupplierTrans = new HashSet<PlhistoricalSupplierTran>();
            PlpendSupplierBatchTrans = new HashSet<PlpendSupplierBatchTran>();
            PlpendSupplierTrans = new HashSet<PlpendSupplierTran>();
            PlpostedSupplierTrans = new HashSet<PlpostedSupplierTran>();
            SlhistoricalCustomerTrans = new HashSet<SlhistoricalCustomerTran>();
            SlpendCustomerBatchTrans = new HashSet<SlpendCustomerBatchTran>();
            SlpendCustomerTrans = new HashSet<SlpendCustomerTran>();
            SlpostedCustomerTrans = new HashSet<SlpostedCustomerTran>();
            SopinvoiceCreditArches = new HashSet<SopinvoiceCreditArch>();
            SopinvoiceCredits = new HashSet<SopinvoiceCredit>();
            SoporderReturnArches = new HashSet<SoporderReturnArch>();
            SoporderReturns = new HashSet<SoporderReturn>();
            SoppaymentMethods = new HashSet<SoppaymentMethod>();
            SysmerchantAccounts = new HashSet<SysmerchantAccount>();
            TshumanResources = new HashSet<TshumanResource>();
        }

        public long CbaccountId { get; set; }
        public string AccountCode { get; set; } = null!;
        public string AccountDescription { get; set; } = null!;
        public string? BankSortCode { get; set; }
        public string? AccountNumber { get; set; }
        public string? AccountName { get; set; }
        public long CbaccountTypeId { get; set; }
        public long AccountSyscurrencyId { get; set; }
        public decimal CurrentBalanceInAccntCurrency { get; set; }
        public decimal CurrentBalanceInBaseCurrency { get; set; }
        public decimal OverdraftLimit { get; set; }
        public DateTime? LastStatementDate { get; set; }
        public decimal StatementBalance { get; set; }
        public string? BankAccountHolderName { get; set; }
        public int LastStatementPageNumber { get; set; }
        public string? BankAccountNominalNumber { get; set; }
        public string? BankAccountNominalCostCentre { get; set; }
        public string? BankAccountNominalDepartment { get; set; }
        public string? BankChargesNominalNumber { get; set; }
        public string? BankChargesNominalCostCentre { get; set; }
        public string? BankChargesNominalDepartment { get; set; }
        public string? ExchangeDiffNominalNumber { get; set; }
        public string? ExchangeDiffNominalCostCentre { get; set; }
        public string? ExchangeDiffNominalDepartment { get; set; }
        public string? ElectronicBank { get; set; }
        public byte? ElectronicService { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public string? Ibannumber { get; set; }
        public string Bicnumber { get; set; } = null!;
        public DateTime DateTimeUpdated { get; set; }
        public long? CbbankFeedAccountId { get; set; }
        public bool IsBankCloudEnabled { get; set; }
        public DateTime? BankCloudDisabledDateTime { get; set; }
        public long SysaccountStatusId { get; set; }
        public string StatusChangedBy { get; set; } = null!;
        public DateTime? StatusChangedDateTime { get; set; }

        public virtual Syscurrency AccountSyscurrency { get; set; } = null!;
        public virtual CbaccountType CbaccountType { get; set; } = null!;
        public virtual CbbankFeedAccount? CbbankFeedAccount { get; set; }
        public virtual SysaccountStatus SysaccountStatus { get; set; } = null!;
        public virtual ICollection<CbaccountContact> CbaccountContacts { get; set; }
        public virtual ICollection<CbaccountMemo> CbaccountMemos { get; set; }
        public virtual ICollection<CbbankFeedTransaction> CbbankFeedTransactions { get; set; }
        public virtual ICollection<CbbankLocation> CbbankLocations { get; set; }
        public virtual ICollection<CbbankStatement> CbbankStatements { get; set; }
        public virtual ICollection<CbcloudBankAccount> CbcloudBankAccounts { get; set; }
        public virtual ICollection<CbdirectDebitTran> CbdirectDebitTrans { get; set; }
        public virtual ICollection<CbdraftBankStatement> CbdraftBankStatements { get; set; }
        public virtual ICollection<CbpaymentCloudProviderBank> CbpaymentCloudProviderBanks { get; set; }
        public virtual ICollection<CbpendAccountTran> CbpendAccountTrans { get; set; }
        public virtual ICollection<CbpostedAccountTran> CbpostedAccountTrans { get; set; }
        public virtual ICollection<Cbsetting> Cbsettings { get; set; }
        public virtual ICollection<CbshortTermCashProjectionAccount> CbshortTermCashProjectionAccounts { get; set; }
        public virtual ICollection<Nlsetting> Nlsettings { get; set; }
        public virtual ICollection<PlhistoricalSupplierTran> PlhistoricalSupplierTrans { get; set; }
        public virtual ICollection<PlpendSupplierBatchTran> PlpendSupplierBatchTrans { get; set; }
        public virtual ICollection<PlpendSupplierTran> PlpendSupplierTrans { get; set; }
        public virtual ICollection<PlpostedSupplierTran> PlpostedSupplierTrans { get; set; }
        public virtual ICollection<SlhistoricalCustomerTran> SlhistoricalCustomerTrans { get; set; }
        public virtual ICollection<SlpendCustomerBatchTran> SlpendCustomerBatchTrans { get; set; }
        public virtual ICollection<SlpendCustomerTran> SlpendCustomerTrans { get; set; }
        public virtual ICollection<SlpostedCustomerTran> SlpostedCustomerTrans { get; set; }
        public virtual ICollection<SopinvoiceCreditArch> SopinvoiceCreditArches { get; set; }
        public virtual ICollection<SopinvoiceCredit> SopinvoiceCredits { get; set; }
        public virtual ICollection<SoporderReturnArch> SoporderReturnArches { get; set; }
        public virtual ICollection<SoporderReturn> SoporderReturns { get; set; }
        public virtual ICollection<SoppaymentMethod> SoppaymentMethods { get; set; }
        public virtual ICollection<SysmerchantAccount> SysmerchantAccounts { get; set; }
        public virtual ICollection<TshumanResource> TshumanResources { get; set; }
    }
}
