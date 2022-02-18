using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconHeldVatanalysis
    {
        public long SiconHeldVatanalysisId { get; set; }
        public long NlheldJournalId { get; set; }
        public long NlheldJournalTranId { get; set; }
        public string? ExtendedVatanalysisGrouping { get; set; }
    }
}
