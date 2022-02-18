using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiWorksOrderSop
    {
        public long SiWorksOrderSopid { get; set; }
        public long? SoporderReturnId { get; set; }
        public string? WorksOrderText { get; set; }
        public bool? AskToCreateWo { get; set; }
        public string? LastUpdatedBy { get; set; }
        public DateTime? LastUpdatedDate { get; set; }
    }
}
