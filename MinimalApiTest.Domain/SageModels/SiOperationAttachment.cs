using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiOperationAttachment
    {
        public long SiOperationAttachmentId { get; set; }
        public long? SiOperationId { get; set; }
        public short Sequence { get; set; }
        public string? Description { get; set; }
        public string Title { get; set; } = null!;
        public DateTime CreatedDate { get; set; }
    }
}
