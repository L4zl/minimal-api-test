using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconNote
    {
        public long SiconNoteId { get; set; }
        public long? SiconNotesTabId { get; set; }
        public long? ParentId { get; set; }
        public string? ParentType { get; set; }
        public string? Note { get; set; }
        public string? LastUpdatedUserId { get; set; }
        public DateTime? LastUpdatedDateTime { get; set; }
    }
}
