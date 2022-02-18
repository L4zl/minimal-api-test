using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconFixedAssetsTransDetail
    {
        public long SiconFixedAssetsTransDetailId { get; set; }
        public long TransactionId { get; set; }
        public long NominalAccountId { get; set; }
        public decimal CreditAmount { get; set; }
        public decimal DebitAmount { get; set; }
    }
}
