using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconDdsSiconContractLine
    {
        public long SiconDdsSiconContractLineId { get; set; }
        public long? SiconDdsPaymentMethodId { get; set; }
        public long? SiconContractId { get; set; }
        public long? SiconContractLineId { get; set; }
        public short NumberOfPayments { get; set; }
        public short PaymentDayOfMonth { get; set; }
        public bool Deleted { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string UpdatedUser { get; set; } = null!;
    }
}
