using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconRamsline
    {
        public long SiconRamslineId { get; set; }
        public long SiconRamsid { get; set; }
        public string? Description { get; set; }
        public long? ParentId { get; set; }
        public string? LastUpdatedByUserId { get; set; }
        public DateTime? LastUpdatedDateTime { get; set; }
    }
}
