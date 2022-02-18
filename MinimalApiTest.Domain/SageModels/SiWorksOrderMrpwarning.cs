using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiWorksOrderMrpwarning
    {
        public long SiWorksOrderMrpwarningId { get; set; }
        public string? Message { get; set; }
        public string? ForiegnId { get; set; }
    }
}
