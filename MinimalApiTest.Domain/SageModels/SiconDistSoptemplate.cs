using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconDistSoptemplate
    {
        public long SiconDistSoptemplateId { get; set; }
        public string? TemplateName { get; set; }
        public bool? IsDeleted { get; set; }
        public string? LastUpdatedByUserId { get; set; }
        public DateTime? LastUpdatedDateTime { get; set; }
        public long? CustomerId { get; set; }
    }
}
