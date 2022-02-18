using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class BomDrawing
    {
        public long BomDrawingId { get; set; }
        public long BomRecordId { get; set; }
        public long DrawDrawingId { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public DateTime DateTimeUpdated { get; set; }

        public virtual BomRecord BomRecord { get; set; } = null!;
        public virtual DrawDrawing DrawDrawing { get; set; } = null!;
    }
}
