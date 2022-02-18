using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconMrpreasonLink
    {
        public long SiconMrpreasonLinkId { get; set; }
        public long? Suggestion { get; set; }
        public int? SuggestionType { get; set; }
        public string? SuggestionDocumentNo { get; set; }
        public long? Reason { get; set; }
        public int? ReasonType { get; set; }
        public string? ReasonDocumentNo { get; set; }
        public decimal? Quantity { get; set; }
    }
}
