using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class DsauditTrailView
    {
        public long SysauditTrailId { get; set; }
        public long SysnominalAuditTrailId { get; set; }
        public long SysauditTrailEntryTypeId { get; set; }
        public string TransactionType { get; set; } = null!;
        public long UniqueReferenceNumber { get; set; }
        public string Narrative { get; set; } = null!;
        public DateTime? TransactionDate { get; set; }
        public DateTime? FinancialYearStartDate { get; set; }
        public short? PeriodNumber { get; set; }
        public string AccountNumber { get; set; } = null!;
        public string AccountName { get; set; } = null!;
        public string NlaccNumber { get; set; } = null!;
        public string NlaccName { get; set; } = null!;
        public string Cccode { get; set; } = null!;
        public string? Department { get; set; }
        public string? CostCentre { get; set; }
        public string DepartmentCode { get; set; } = null!;
        public string TradingNominalAnalysisCode { get; set; } = null!;
        public string EntrySourceName { get; set; } = null!;
        public string Reference { get; set; } = null!;
        public string SecondReference { get; set; } = null!;
        public string BatchReference { get; set; } = null!;
        public int UserNumber { get; set; }
        public string UserName { get; set; } = null!;
        public DateTime? PostedDate { get; set; }
        public decimal? GoodsValueInDocumentCurrency { get; set; }
        public long? CurrencyCode { get; set; }
        public string? Currency { get; set; }
        public decimal TransactionToBaseExchangeRate { get; set; }
        public decimal NominalValue { get; set; }
        public string? NlaccRepCatCode { get; set; }
        public string? NlaccRepCatDesc { get; set; }
        public string? NlaccRepTypeName { get; set; }
        public DateTime? LastStatementDate { get; set; }
        public decimal? CreditYearToDate { get; set; }
        public decimal? DebitYearToDate { get; set; }
        public long? NlnominalAccountId { get; set; }
        public long? SlcustomerAccountId { get; set; }
        public long? PlsupplierAccountId { get; set; }
        public long? CbaccountId { get; set; }
    }
}
