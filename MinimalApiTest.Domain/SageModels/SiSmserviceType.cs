using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiSmserviceType
    {
        public long SiSmserviceTypeId { get; set; }
        public long SiSmserviceTemplateId { get; set; }
        public string Name { get; set; } = null!;
        public long ItemId { get; set; }
        public long? SiSmcaseTypeId { get; set; }
    }
}
