using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconCrmcommTemplate
    {
        public long SiconCrmcommTemplateId { get; set; }
        public long SiconCrmcommTemplateLinkTypeId { get; set; }
        public long? SiconCrmcommunicationTypeId { get; set; }
        public string Description { get; set; } = null!;
        public string Subject { get; set; } = null!;
        public string Body { get; set; } = null!;
        public bool? Deleted { get; set; }
        public string CreatedUser { get; set; } = null!;
        public DateTime? CreatedDate { get; set; }
        public string UpdatedUser { get; set; } = null!;
        public DateTime? UpdatedDate { get; set; }
    }
}
