using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconIccontrolAccountCustomer
    {
        public long SiconIccontrolAccountCustId { get; set; }
        public long? SiconIccontrolAccountId { get; set; }
        public long? SyscurrencyId { get; set; }
        public string Isocode { get; set; } = null!;
        public long? CustomerId { get; set; }
        public string CustomerAccountNumber { get; set; } = null!;
        public string LastUpdatedByUser { get; set; } = null!;
        public DateTime? LastUpdatedDateTime { get; set; }
    }
}
