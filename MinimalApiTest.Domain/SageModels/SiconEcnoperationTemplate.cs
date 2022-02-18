using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconEcnoperationTemplate
    {
        public long SiconEcnoperationTemplateId { get; set; }
        public string Description { get; set; } = null!;
        public string Comment { get; set; } = null!;
        public string SiconTeam { get; set; } = null!;
        public decimal DefaultLengthHours { get; set; }
    }
}
