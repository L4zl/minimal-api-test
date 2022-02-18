using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconWotemplateAndBom
    {
        public long Id { get; set; }
        public string? FinishedItemCode { get; set; }
        public string? Description { get; set; }
        public string? Number { get; set; }
        public string TemplateType { get; set; } = null!;
    }
}
