using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconNotesTab
    {
        public long SiconNotesTabId { get; set; }
        public string? ParentType { get; set; }
        public string? TabName { get; set; }
    }
}
