using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class TemmessageOrder
    {
        public long TemmessageOrderId { get; set; }
        public long TemmessageId { get; set; }
        public long SoporderId { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public DateTime DateTimeUpdated { get; set; }

        public virtual SoporderReturn Soporder { get; set; } = null!;
        public virtual Temmessage Temmessage { get; set; } = null!;
    }
}
