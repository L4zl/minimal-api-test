using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconWabsop
    {
        public long SiconWabsopid { get; set; }
        public long? SoporderReturnId { get; set; }
        public bool? ReadyToPick { get; set; }
        public string? LastUpdatedBy { get; set; }
        public DateTime? LastUpdatedDate { get; set; }
        public long? AssignedToSiconWabuserId { get; set; }
    }
}
