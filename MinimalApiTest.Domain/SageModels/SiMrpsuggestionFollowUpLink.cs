using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiMrpsuggestionFollowUpLink
    {
        public long SiMrpsuggestionFollowUpLinkId { get; set; }
        public long? SuggestionId { get; set; }
        public long? SiMrpsuggestionFollowUpId { get; set; }
    }
}
