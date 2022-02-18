using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SysmerchantAccount
    {
        public long SysmerchantAccountId { get; set; }
        public string Description { get; set; } = null!;
        public long? CbaccountId { get; set; }
        public string? AccountNumber { get; set; }
        public string? AccountCostCentre { get; set; }
        public string? AccountDepartment { get; set; }

        public virtual Cbaccount? Cbaccount { get; set; }
    }
}
