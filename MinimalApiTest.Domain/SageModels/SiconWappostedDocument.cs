using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconWappostedDocument
    {
        public long SiconWappostedDocumentId { get; set; }
        public string DocumentType { get; set; } = null!;
        public int WapheaderId { get; set; }
        public int? WaplineId { get; set; }
        public long? SageHeaderId { get; set; }
        public long? SageLineId { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string UpdatedUser { get; set; } = null!;
    }
}
