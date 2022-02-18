using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconCrmcompanyLinkType
    {
        public long SiconCrmcompanyLinkTypeId { get; set; }
        public string LinkTypeName { get; set; } = null!;
        public long? OpposingLinkTypeId { get; set; }
        public long? SiconCrmaccountTypeId { get; set; }
        public bool? Deleted { get; set; }
        public string CreatedUser { get; set; } = null!;
        public DateTime? CreatedDate { get; set; }
        public string UpdatedUser { get; set; } = null!;
        public DateTime? UpdatedDate { get; set; }
    }
}
