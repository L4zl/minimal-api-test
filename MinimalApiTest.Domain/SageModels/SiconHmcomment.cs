using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconHmcomment
    {
        public long SiconHmcommentId { get; set; }
        public string? Comment { get; set; }
        public bool? IsShowOnCustomerDocs { get; set; }
        public string LastUpdatedByUserId { get; set; } = null!;
        public DateTime? LastUpdatedDateTime { get; set; }
    }
}
