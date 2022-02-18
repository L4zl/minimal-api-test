using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconCrmcompanyLink
    {
        public long SiconCrmcompanyLinkId { get; set; }
        public long SiconCrmcompanyLinkTypeId { get; set; }
        public long SiconCrmcompanyId { get; set; }
        public long LinkedSiconCrmcompanyId { get; set; }
        public bool? Deleted { get; set; }
        public string CreatedUser { get; set; } = null!;
        public DateTime? CreatedDate { get; set; }
        public string UpdatedUser { get; set; } = null!;
        public DateTime? UpdatedDate { get; set; }
    }
}
