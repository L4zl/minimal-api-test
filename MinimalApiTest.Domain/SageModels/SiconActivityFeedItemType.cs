using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconActivityFeedItemType
    {
        public long SiconActivityFeedItemTypeId { get; set; }
        public Guid ActivityTypeGuid { get; set; }
        public string ActivityTypeName { get; set; } = null!;
        public string Verb { get; set; } = null!;
        public string? ImageAssembly { get; set; }
        public string? ImageResource { get; set; }
        public bool Deleted { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedUser { get; set; } = null!;
        public DateTime? UpdatedDate { get; set; }
        public string UpdatedUser { get; set; } = null!;
    }
}
