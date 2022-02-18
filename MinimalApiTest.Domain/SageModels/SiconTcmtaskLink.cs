using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconTcmtaskLink
    {
        public long SiconTcmtaskLinkId { get; set; }
        public long? SiconTcmtaskId { get; set; }
        public long? SiconTcmmoduleTypeId { get; set; }
        public long? ModuleTypeForeignId { get; set; }
        public long? SiJcJobId { get; set; }
        public long? SiJobPhaseId { get; set; }
        public long? SiJobStageId { get; set; }
        public long? SiJobActivityId { get; set; }
        public long? SiJcvariationId { get; set; }
        public bool? Deleted { get; set; }
        public DateTime? CreatedDateTime { get; set; }
        public DateTime? UpdatedDateTime { get; set; }
        public string UpdatedUser { get; set; } = null!;
    }
}
