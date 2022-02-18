using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class CpallocationTran
    {
        public long CpallocationTranId { get; set; }
        public long PaymentCptranId { get; set; }
        public long RefundCptranId { get; set; }

        public virtual Cptran PaymentCptran { get; set; } = null!;
        public virtual Cptran RefundCptran { get; set; } = null!;
    }
}
