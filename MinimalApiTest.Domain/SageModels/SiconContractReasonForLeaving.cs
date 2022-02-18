using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconContractReasonForLeaving
    {
        public long ReasonForLeavingId { get; set; }
        public string? Code { get; set; }
        public string? Description { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string? UpdatedUser { get; set; }
    }
}
