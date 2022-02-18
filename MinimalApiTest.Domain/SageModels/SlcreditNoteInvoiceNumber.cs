using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SlcreditNoteInvoiceNumber
    {
        public long SlcreditNoteInvoiceNumberId { get; set; }
        public long NextCreditNoteNumber { get; set; }
        public long NextInvoiceNumber { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public DateTime DateTimeUpdated { get; set; }
    }
}
