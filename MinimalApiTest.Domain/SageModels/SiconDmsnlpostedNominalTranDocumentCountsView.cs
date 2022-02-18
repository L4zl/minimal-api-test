using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconDmsnlpostedNominalTranDocumentCountsView
    {
        public long UniqueReferenceNumber { get; set; }
        public long NlnominalAccountId { get; set; }
        public int? DocumentCount { get; set; }
    }
}
