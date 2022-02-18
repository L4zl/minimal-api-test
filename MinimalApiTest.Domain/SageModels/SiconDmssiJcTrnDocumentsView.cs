using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconDmssiJcTrnDocumentsView
    {
        public long SiJcJobId { get; set; }
        public string? JobNumber { get; set; }
        public string JobCustomerName { get; set; } = null!;
        public string JobManager { get; set; } = null!;
        public string JobDescription { get; set; } = null!;
        public string? DocumentReference { get; set; }
        public string? DocumentSecondReference { get; set; }
        public string? TraderAccountReference { get; set; }
        public string? TraderAccountName { get; set; }
        public long SiconDmsdocumentId { get; set; }
        public long? ForeignId { get; set; }
        public long SiconDmsentityId { get; set; }
        public string EntityName { get; set; } = null!;
        public string EntityFriendlyName { get; set; } = null!;
        public long SiconDmsmoduleId { get; set; }
        public string ModuleName { get; set; } = null!;
        public string ModuleFriendlyName { get; set; } = null!;
        public long SiconDmsdocumentTypeId { get; set; }
        public string DocumentTypeName { get; set; } = null!;
        public string DocumentTypeFriendlyName { get; set; } = null!;
    }
}
