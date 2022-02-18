using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiSmquote
    {
        public long SiSmquoteId { get; set; }
        public long? SiSmcaseId { get; set; }
        public string? QuoteNumber { get; set; }
        public int? QuoteStatus { get; set; }
        public DateTime? DateCreated { get; set; }
        public DateTime? DatePrinted { get; set; }
        public string? Description { get; set; }
    }
}
