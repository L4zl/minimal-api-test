using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconIccontrolAccountBank
    {
        public long SiconIccontrolAccountBankId { get; set; }
        public long? SiconIccontrolAccountId { get; set; }
        public long? BankId { get; set; }
        public string BankNo { get; set; } = null!;
        public string BankName { get; set; } = null!;
        public string Isocode { get; set; } = null!;
    }
}
