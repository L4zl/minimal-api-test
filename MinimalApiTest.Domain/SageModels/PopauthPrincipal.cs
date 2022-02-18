using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class PopauthPrincipal
    {
        public PopauthPrincipal()
        {
            PopauthPrincipalContents = new HashSet<PopauthPrincipalContent>();
        }

        public long PopauthPrincipalId { get; set; }
        public long PopauthRuleId { get; set; }
        public long PopauthRoleTypeId { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public DateTime DateTimeUpdated { get; set; }

        public virtual PopauthRoleType PopauthRoleType { get; set; } = null!;
        public virtual PopauthRule PopauthRule { get; set; } = null!;
        public virtual ICollection<PopauthPrincipalContent> PopauthPrincipalContents { get; set; }
    }
}
