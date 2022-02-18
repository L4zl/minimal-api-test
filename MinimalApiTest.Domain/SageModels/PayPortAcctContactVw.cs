using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class PayPortAcctContactVw
    {
        public string CustomerAccountNumber { get; set; } = null!;
        public long SlcustomerAccountId { get; set; }
        public long SyscontactTypeId { get; set; }
        public int? ContactType { get; set; }
        public string ContactValue { get; set; } = null!;
        public string ContactName { get; set; } = null!;
    }
}
