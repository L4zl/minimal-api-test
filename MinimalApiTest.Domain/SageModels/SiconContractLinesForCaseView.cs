using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconContractLinesForCaseView
    {
        public long SiconContractLineId { get; set; }
        public int? LineNumber { get; set; }
        public string Code { get; set; } = null!;
        public string Name { get; set; } = null!;
        public string? ContractNumber { get; set; }
        public string? CustomerAccountNumber { get; set; }
        public string? CustomerAccountName { get; set; }
        public string? AssociatedCustomerAccNumber { get; set; }
        public string? AssociatedCustomerAccName { get; set; }
        public string? SiconCrmassociatedCompanyName { get; set; }
        public string? SiconCrmcompanyName { get; set; }
        public string? SiconCrmpersonDisplayName { get; set; }
        public DateTime? ContractStartDate { get; set; }
        public DateTime? ContractEndDate { get; set; }
        public bool? Trial { get; set; }
    }
}
