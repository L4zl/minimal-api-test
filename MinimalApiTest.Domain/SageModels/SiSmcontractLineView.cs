using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiSmcontractLineView
    {
        public long SiconContractLineId { get; set; }
        public int? LineNumber { get; set; }
        public long ItemId { get; set; }
        public string Code { get; set; } = null!;
        public string Name { get; set; } = null!;
        public long SiconContractId { get; set; }
        public string? ContractNumber { get; set; }
        public long? SlcustomerAccountId { get; set; }
        public string? CustomerAccountNumber { get; set; }
        public string? CustomerAccountName { get; set; }
        public long? AssociatedSlcustomerAccountId { get; set; }
        public string? AssociatedCustomerAccNumber { get; set; }
        public string? AssociatedCustomerAccName { get; set; }
        public long? SiconCrmassociatedCompanyId { get; set; }
        public string? SiconCrmassociatedCompanyName { get; set; }
        public long? SiconCrmcompanyId { get; set; }
        public string? SiconCrmcompanyName { get; set; }
        public string? CrmPersonDisplayName { get; set; }
        public DateTime? ContractStartDate { get; set; }
        public DateTime? ContractEndDate { get; set; }
        public bool? Trial { get; set; }
        public bool? IsLive { get; set; }
    }
}
