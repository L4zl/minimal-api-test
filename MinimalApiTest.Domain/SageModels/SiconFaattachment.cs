using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconFaattachment
    {
        public long FaattachmentId { get; set; }
        public long FixedAssetId { get; set; }
        public string? Url { get; set; }
        public DateTime? DateTimeCreated { get; set; }
    }
}
