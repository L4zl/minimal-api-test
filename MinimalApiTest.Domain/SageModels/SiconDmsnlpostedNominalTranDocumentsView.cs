using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconDmsnlpostedNominalTranDocumentsView
    {
        public long SiconDmsdocumentId { get; set; }
        public long? ForeignId { get; set; }
        public long SiconDmsmoduleId { get; set; }
        public string ModuleName { get; set; } = null!;
        public string ModuleFriendlyName { get; set; } = null!;
        public long SiconDmsentityId { get; set; }
        public string EntityName { get; set; } = null!;
        public string EntityFriendlyName { get; set; } = null!;
        public long SiconDmsdocumentTypeId { get; set; }
        public string DocumentTypeName { get; set; } = null!;
        public string DocumentTypeFriendlyName { get; set; } = null!;
        public long UniqueReferenceNumber { get; set; }
        public long NlnominalAccountId { get; set; }
        public DateTime TransactionDate { get; set; }
        public string Reference { get; set; } = null!;
        public string Narrative { get; set; } = null!;
        public long NlpostedNominalTranId { get; set; }
        public long NlnominalTranTypeId { get; set; }
        public long Source { get; set; }
    }
}
