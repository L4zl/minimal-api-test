using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconDmscustomer
    {
        public long SiconDmscustomerId { get; set; }
        public long SlcustomerAccountId { get; set; }
        public bool MultipleInvoicesPerEmail { get; set; }
        public bool Deleted { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string UpdatedUser { get; set; } = null!;
    }
}
