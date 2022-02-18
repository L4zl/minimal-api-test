using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class TsauthGroupMember
    {
        public long TsauthGroupMembersId { get; set; }
        public long TspersonId { get; set; }
        public long TsauthorisationGroupId { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public DateTime DateTimeUpdated { get; set; }

        public virtual TsauthorisationGroup TsauthorisationGroup { get; set; } = null!;
        public virtual Tsperson Tsperson { get; set; } = null!;
    }
}
