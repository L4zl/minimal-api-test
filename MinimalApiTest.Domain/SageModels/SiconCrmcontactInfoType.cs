using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconCrmcontactInfoType
    {
        public long SiconCrmcontactInfoTypeId { get; set; }
        public short ContactInfoTypeNumber { get; set; }
        public string ContactInfoTypeDescription { get; set; } = null!;
        public bool IsSystem { get; set; }
        public bool? Deleted { get; set; }
        public string CreatedUser { get; set; } = null!;
        public DateTime? CreatedDate { get; set; }
        public string UpdatedUser { get; set; } = null!;
        public DateTime? UpdatedDate { get; set; }
    }
}
