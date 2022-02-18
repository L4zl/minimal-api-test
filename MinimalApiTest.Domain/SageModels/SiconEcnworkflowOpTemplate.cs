using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconEcnworkflowOpTemplate
    {
        public long SiconEcnworkflowOpTemplateId { get; set; }
        public long SiconEcnworkflowId { get; set; }
        public long SiconEcnoperationTemplate { get; set; }
        public int Sequence { get; set; }
    }
}
