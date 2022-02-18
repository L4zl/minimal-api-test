using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconDeferredTranView
    {
        public decimal? Amount { get; set; }
        public string? Month { get; set; }
        public DateTime? TransactionDate { get; set; }
        public string? AccountNumber { get; set; }
        public string? AccountCostCentre { get; set; }
        public string? AccountDepartment { get; set; }
        public string? AccountName { get; set; }
        public long? NlnominalAccountId { get; set; }
        public long? SiconContractLineId { get; set; }
        public int? LineNumber { get; set; }
        public string? ContractNumber { get; set; }
        public long? TransactionTypeId { get; set; }
        public long SiconContractId { get; set; }
        public string? PlaccountNumber { get; set; }
        public string? PlaccountCostCentre { get; set; }
        public string? PlaccountDepartment { get; set; }
        public string? PlaccountName { get; set; }
        public long? PlnlnominalAccountId { get; set; }
        public string? SopnominalAccountRef { get; set; }
        public string? SopnominalCostCentre { get; set; }
        public string? SopnominalDepartment { get; set; }
    }
}
