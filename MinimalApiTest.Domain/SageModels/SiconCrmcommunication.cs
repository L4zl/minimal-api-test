using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconCrmcommunication
    {
        public long SiconCrmcommunicationId { get; set; }
        public long? SiconCrmcommunicationTypeId { get; set; }
        public long? SiconCrmcompanyId { get; set; }
        public long? SiconCrmpersonId { get; set; }
        public long? SiconCrmtaskId { get; set; }
        public long? SiconCrmcaseId { get; set; }
        public long? SiconCrmopportunityId { get; set; }
        public short Direction { get; set; }
        public DateTime DateTime { get; set; }
        public string Sender { get; set; } = null!;
        public string Recipient { get; set; } = null!;
        public string Cc { get; set; } = null!;
        public string Bcc { get; set; } = null!;
        public string Subject { get; set; } = null!;
        public string Body { get; set; } = null!;
        public string Description { get; set; } = null!;
        public bool? Deleted { get; set; }
        public string CreatedUser { get; set; } = null!;
        public DateTime? CreatedDate { get; set; }
        public string UpdatedUser { get; set; } = null!;
        public DateTime? UpdatedDate { get; set; }
    }
}
