using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconMrpwarning
    {
        public long SiconMrpwarningId { get; set; }
        public long? ItemId { get; set; }
        public string? Warning { get; set; }
        public DateTime? Date { get; set; }
        public string? LastUpdatedBy { get; set; }
        public DateTime? LastUpdatedDate { get; set; }
        public long? SuggestionId { get; set; }
    }
}
