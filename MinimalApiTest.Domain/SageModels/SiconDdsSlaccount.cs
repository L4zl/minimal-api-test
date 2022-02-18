using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconDdsSlaccount
    {
        public long SiconDdsSlaccountId { get; set; }
        public long? SiconDdsPaymentMethodId { get; set; }
        public long? SlcustomerAccountId { get; set; }
        public short PaymentDayOfMonth { get; set; }
        public short DefaultNumberOfPayments { get; set; }
        public string BankAccountNumber { get; set; } = null!;
        public string BankAccountName { get; set; } = null!;
        public string BankAccountSortCode { get; set; } = null!;
        public string BankPaymentReference { get; set; } = null!;
        public bool FirstDirectDebitGenerated { get; set; }
        public bool CancellationRequested { get; set; }
        public bool BacsinstructionSent { get; set; }
        public bool UseTaxInclusivePricing { get; set; }
        public string OverrideCustomerAccountRef { get; set; } = null!;
        public string Iban { get; set; } = null!;
        public string Bicswift { get; set; } = null!;
        public long? CbaccountId { get; set; }
        public bool Deleted { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string UpdatedUser { get; set; } = null!;
    }
}
