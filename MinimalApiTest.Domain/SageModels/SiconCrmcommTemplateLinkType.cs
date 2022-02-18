using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconCrmcommTemplateLinkType
    {
        public long SiconCrmcommTemplateLinkTypeId { get; set; }
        public short CommTemplateLinkTypeNumber { get; set; }
        public string CommTemplateLinkTypeName { get; set; } = null!;
        public bool? Deleted { get; set; }
        public string CreatedUser { get; set; } = null!;
        public DateTime? CreatedDate { get; set; }
        public string UpdatedUser { get; set; } = null!;
        public DateTime? UpdatedDate { get; set; }
    }
}
