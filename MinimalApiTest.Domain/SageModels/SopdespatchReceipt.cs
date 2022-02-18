using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SopdespatchReceipt
    {
        public SopdespatchReceipt()
        {
            SopdespatchReceiptLines = new HashSet<SopdespatchReceiptLine>();
            SopordCommentForDspNtes = new HashSet<SopordCommentForDspNte>();
        }

        public long SopdespatchReceiptId { get; set; }
        public long SopdespatchReceiptTypeId { get; set; }
        public string DocumentNo { get; set; } = null!;
        public DateTime DespatchReceiptDate { get; set; }
        public int UserId { get; set; }
        public string UserName { get; set; } = null!;
        public long SoporderId { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public DateTime DateTimeUpdated { get; set; }

        public virtual SopdespatchReceiptType SopdespatchReceiptType { get; set; } = null!;
        public virtual SoporderReturn Soporder { get; set; } = null!;
        public virtual ICollection<SopdespatchReceiptLine> SopdespatchReceiptLines { get; set; }
        public virtual ICollection<SopordCommentForDspNte> SopordCommentForDspNtes { get; set; }
    }
}
