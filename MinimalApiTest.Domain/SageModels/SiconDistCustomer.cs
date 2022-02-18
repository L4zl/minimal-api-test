using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconDistCustomer
    {
        public long SiconDistCustomerId { get; set; }
        public long SlcustomerAccountId { get; set; }
        public decimal MinOrderValue { get; set; }
    }
}
