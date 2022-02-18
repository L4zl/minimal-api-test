using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconWabcustomer
    {
        public long SiconWabcustomerId { get; set; }
        public long SlcustomerAccountId { get; set; }
        public bool? PrintSopinvoiceAtDespatch { get; set; }
    }
}
