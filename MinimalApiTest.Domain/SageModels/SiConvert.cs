using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiConvert
    {
        public long SiConvertId { get; set; }
        public long? SopquoteId { get; set; }
        public long? SopquoteLineId { get; set; }
        public long? SoporderReturnId { get; set; }
        public long? SoporderReturnLineId { get; set; }
        public string? Status { get; set; }
        public string? LastUpdatedBy { get; set; }
        public DateTime? LastUpdatedDate { get; set; }
    }
}
