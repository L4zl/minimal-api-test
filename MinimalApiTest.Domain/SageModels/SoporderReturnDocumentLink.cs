using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SoporderReturnDocumentLink
    {
        public long SoporderReturnDocumentLinkId { get; set; }
        public long SourceTypeId { get; set; }
        public string SourceDocumentNo { get; set; } = null!;
        public long SourceId { get; set; }
        public long DocumentTypeId { get; set; }
        public string DocumentNo { get; set; } = null!;
        public long DocumentId { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public DateTime DateTimeUpdated { get; set; }

        public virtual SoporderReturn Document { get; set; } = null!;
        public virtual SoporderReturn Source { get; set; } = null!;
    }
}
