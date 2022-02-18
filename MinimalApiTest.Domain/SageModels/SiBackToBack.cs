using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiBackToBack
    {
        public long SiBackToBackId { get; set; }
        public long? SoporderReturnId { get; set; }
        public long? SoporderReturnLineId { get; set; }
        public long? PoporderReturnId { get; set; }
        public long? PoporderReturnLineId { get; set; }
        public int? FulfilmentMethod { get; set; }
        public string? LastUpdatedUser { get; set; }
        public DateTime? LastUpdatedDate { get; set; }
    }
}
