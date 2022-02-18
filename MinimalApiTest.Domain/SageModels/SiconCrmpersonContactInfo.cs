using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconCrmpersonContactInfo
    {
        public long SiconCrmpersonContactInfoId { get; set; }
        public string SiconCrmpersonId { get; set; } = null!;
        public long SiconCrmcontactInfoId { get; set; }
        public bool? Deleted { get; set; }
        public string CreatedUser { get; set; } = null!;
        public DateTime? CreatedDate { get; set; }
        public string UpdatedUser { get; set; } = null!;
        public DateTime? UpdatedDate { get; set; }
    }
}
