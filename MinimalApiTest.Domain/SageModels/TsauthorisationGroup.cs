using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class TsauthorisationGroup
    {
        public TsauthorisationGroup()
        {
            TsauthGroupAuthorisers = new HashSet<TsauthGroupAuthoriser>();
            TsauthGroupMembers = new HashSet<TsauthGroupMember>();
        }

        public long TsauthorisationGroupId { get; set; }
        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;
        public string Reference { get; set; } = null!;
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public DateTime DateTimeUpdated { get; set; }

        public virtual ICollection<TsauthGroupAuthoriser> TsauthGroupAuthorisers { get; set; }
        public virtual ICollection<TsauthGroupMember> TsauthGroupMembers { get; set; }
    }
}
