using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconJobHireSuspension
    {
        public long SiconJobHireSuspensionId { get; set; }
        public long? SiconJobHireId { get; set; }
        public DateTime? DateFrom { get; set; }
        public DateTime? DateTo { get; set; }
        public string? Description { get; set; }
    }
}
