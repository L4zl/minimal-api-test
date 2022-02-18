using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconCrmcompanyContactInfo
    {
        public long SiconCrmcompanyContactInfoId { get; set; }
        public string SiconCrmcompanyId { get; set; } = null!;
        public string SiconCrmcontactInfoId { get; set; } = null!;
        public bool? Deleted { get; set; }
        public string CreatedUser { get; set; } = null!;
        public DateTime? CreatedDate { get; set; }
        public string UpdatedUser { get; set; } = null!;
        public DateTime? UpdatedDate { get; set; }
    }
}
