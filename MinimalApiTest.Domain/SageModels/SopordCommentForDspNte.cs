using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SopordCommentForDspNte
    {
        public long SopordCommentForDspNteId { get; set; }
        public long SoporderReturnLineId { get; set; }
        public long SopdespatchReceiptId { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public DateTime DateTimeUpdated { get; set; }

        public virtual SopdespatchReceipt SopdespatchReceipt { get; set; } = null!;
        public virtual SoporderReturnLine SoporderReturnLine { get; set; } = null!;
    }
}
