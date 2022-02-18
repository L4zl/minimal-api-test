using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconDdsBacsinstructionView
    {
        public long SlcustomerAccountId { get; set; }
        public string CustomerAccountNumber { get; set; } = null!;
        public string CustomerAccountShortName { get; set; } = null!;
        public string CustomerAccountName { get; set; } = null!;
        public long SiconDdsSlaccountId { get; set; }
        public bool BacsinstructionSent { get; set; }
        public bool CancellationRequested { get; set; }
        public bool FirstDirectDebitGenerated { get; set; }
        public long? SiconDdsPaymentMethodId { get; set; }
        public string PaymentMethodName { get; set; } = null!;
        public string PaymentMethodFriendlyName { get; set; } = null!;
    }
}
