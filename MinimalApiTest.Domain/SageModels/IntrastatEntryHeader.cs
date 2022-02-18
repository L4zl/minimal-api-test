using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class IntrastatEntryHeader
    {
        public IntrastatEntryHeader()
        {
            IntrastatEntries = new HashSet<IntrastatEntry>();
        }

        public long IntrastatEntryHeaderId { get; set; }
        public long IntrastatEntryHeaderStatusId { get; set; }
        public long IntrastatDestinationTypeId { get; set; }
        public string HeaderDescription { get; set; } = null!;
        public DateTime HeaderDate { get; set; }
        public string CreatedBy { get; set; } = null!;
        public short TaxMonth { get; set; }
        public short TaxYear { get; set; }
        public string TaxRegistrationCode { get; set; } = null!;
        public string BranchIdcode { get; set; } = null!;
        public string AgentName { get; set; } = null!;
        public string AgentTaxRegistrationCode { get; set; } = null!;
        public string AgentBranchIdcode { get; set; } = null!;
        public bool DeletedEntries { get; set; }

        public virtual IntrastatDestinationType IntrastatDestinationType { get; set; } = null!;
        public virtual IntrastatEntryHeaderStatus IntrastatEntryHeaderStatus { get; set; } = null!;
        public virtual ICollection<IntrastatEntry> IntrastatEntries { get; set; }
    }
}
