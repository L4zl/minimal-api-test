using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconHmorderLineCommentLine
    {
        public long SiconHmorderLineCommentLineId { get; set; }
        public string? Description { get; set; }
        public long SiconHmorderLineId { get; set; }
        public int? ItemSequenceNo { get; set; }
        public bool? IsShowOnCustomerDocs { get; set; }
        public string? LastUpdatedByUserId { get; set; }
        public DateTime? LastUpdatedDateTime { get; set; }
    }
}
