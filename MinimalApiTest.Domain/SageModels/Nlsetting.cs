using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class Nlsetting
    {
        public long NlsettingId { get; set; }
        public bool UseSummaryAccountCreation { get; set; }
        public bool UpdateNominalLedgerImmediately { get; set; }
        public bool UseAdditionalTransAnalysis { get; set; }
        public bool KeepBudgetHistoryLastFiveYears { get; set; }
        public bool AllowPostingsToPreviousYear { get; set; }
        public DateTime? LastFinancialYearEndDate { get; set; }
        public bool? KeepTransactionsAfterPeriodEnd { get; set; }
        public short MonthsToKeepTransactions { get; set; }
        public bool ArchiveTransactionAfterKeeping { get; set; }
        public bool? UseCompanyConsolidation { get; set; }
        public bool? ParentUsesSameBaseCurrency { get; set; }
        public long? ThisCompanysCurrencyInParentId { get; set; }
        public bool ConsCompletedForCurrentPeriod { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public bool UseOnlineVatsubmissions { get; set; }
        public string? VatcontactFirstName { get; set; }
        public string? VatcontactLastName { get; set; }
        public string? VatcontactTelephone { get; set; }
        public string? VatcontactEmail { get; set; }
        public bool UseElectronicVatpayment { get; set; }
        public string HmrcsortCode { get; set; } = null!;
        public string HmrcaccountNumber { get; set; } = null!;
        public string HmrcaccountName { get; set; } = null!;
        public long? VatpaymentCbaccountId { get; set; }
        public string? VatliabilityNominalNumber { get; set; }
        public string? VatliabilityNominalCostCentre { get; set; }
        public string? VatliabilityNominalDepartment { get; set; }
        public bool PromptToPrintCheques { get; set; }
        public DateTime DateTimeUpdated { get; set; }
        public long SagePaymentsStatusId { get; set; }
        public string? SagePaymentsIdentifier { get; set; }
        public bool? RestrictNominalCodeEntry { get; set; }
        public bool UseOnlineVatpilot { get; set; }

        public virtual SagePaymentsSupplierStatus SagePaymentsStatus { get; set; } = null!;
        public virtual Cbaccount? VatpaymentCbaccount { get; set; }
    }
}
