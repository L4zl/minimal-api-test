using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class PlpendSupplierAccount
    {
        public PlpendSupplierAccount()
        {
            PlpendSupplierAnalyses = new HashSet<PlpendSupplierAnalysis>();
        }

        public long PlpendSupplierAccountId { get; set; }
        public string SupplierAccountNumber { get; set; } = null!;
        public string SupplierAccountName { get; set; } = null!;
        public string SupplierAccountShortName { get; set; } = null!;
        public decimal AccountBalance { get; set; }
        public decimal CreditLimit { get; set; }
        public string CurrencyIsocode { get; set; } = null!;
        public long SysexchangeRateTypeId { get; set; }
        public string CountryCode { get; set; } = null!;
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
        public DateTime DateAccountDetailsLastChanged { get; set; }
        public DateTime? DateOfLastTransaction { get; set; }
        public string? EuroAccountNumberCopiedFromTo { get; set; }
        public DateTime? DateEuroAccountCopied { get; set; }
        public bool UseTransactionEmail { get; set; }
        public string AddressLine1 { get; set; } = null!;
        public string AddressLine2 { get; set; } = null!;
        public string AddressLine3 { get; set; } = null!;
        public string AddressLine4 { get; set; } = null!;
        public string PostCode { get; set; } = null!;
        public long SysdocumentLayoutVersionId { get; set; }
        public string? TransactionEmail { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public string TradingTerms { get; set; } = null!;
        public string CreditReference { get; set; } = null!;
        public string CreditBureauName { get; set; } = null!;
        public string CreditPositionName { get; set; } = null!;
        public bool TermsAgreed { get; set; }
        public DateTime? AccountOpened { get; set; }
        public DateTime? LastCreditReview { get; set; }
        public DateTime? NextCreditReview { get; set; }
        public DateTime? ApplicationDate { get; set; }
        public DateTime? DateReceived { get; set; }
        public string? BankSortCode { get; set; }
        public string? BankAccountNumber { get; set; }
        public string? BankAccountName { get; set; }
        public string? BankPaymentReference { get; set; }
        public string Salutation { get; set; } = null!;
        public string FirstName { get; set; } = null!;
        public string MiddleName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string City { get; set; } = null!;
        public string County { get; set; } = null!;
        public string MainTelephoneCountryCode { get; set; } = null!;
        public string MainTelephoneAreaCode { get; set; } = null!;
        public string MainTelephoneSubscriberNumber { get; set; } = null!;
        public string MainFaxCountryCode { get; set; } = null!;
        public string MainFaxAreaCode { get; set; } = null!;
        public string MainFaxSubscriberNumber { get; set; } = null!;
        public string MainWebsite { get; set; } = null!;
        public string ContactValueTelephoneCountryCode { get; set; } = null!;
        public string ContactValueTelephoneAreaCode { get; set; } = null!;
        public string ContactValueTelephoneSubscriberNumber { get; set; } = null!;
        public string ContactValueFaxCountryCode { get; set; } = null!;
        public string ContactValueFaxAreaCode { get; set; } = null!;
        public string ContactValueFaxSubscriberNumber { get; set; } = null!;
        public string ContactValueMobileCountryCode { get; set; } = null!;
        public string ContactValueMobileAreaCode { get; set; } = null!;
        public string ContactValueMobileSubscriberNumber { get; set; } = null!;
        public string Country { get; set; } = null!;
        public string? BankIbannumber { get; set; }
        public string? BankBicnumber { get; set; }
        public string? BankRollNumber { get; set; }
        public string? BankBacsreference { get; set; }
        public string? BankAdditionalReference { get; set; }
        public string? BankNonUksortCode { get; set; }
        public string ContactValueWebsite { get; set; } = null!;
        public string ContactValueEmail { get; set; } = null!;
        public DateTime DateTimeUpdated { get; set; }
        public long SysaccountStatusId { get; set; }

        public virtual SystaxRate DefaultSystaxRate { get; set; } = null!;
        public virtual PlpaymentGroup PlpaymentGroup { get; set; } = null!;
        public virtual SysaccountStatus SysaccountStatus { get; set; } = null!;
        public virtual SysaccountType SysaccountType { get; set; } = null!;
        public virtual SysexchangeRateType SysexchangeRateType { get; set; } = null!;
        public virtual SyspaymentTermsBasis SyspaymentTermsBasis { get; set; } = null!;
        public virtual ICollection<PlpendSupplierAnalysis> PlpendSupplierAnalyses { get; set; }
    }
}
