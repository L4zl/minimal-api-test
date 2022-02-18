using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class PopauthRoleType
    {
        public PopauthRoleType()
        {
            PopauthPrincipals = new HashSet<PopauthPrincipal>();
        }

        public long PopauthRoleTypeId { get; set; }
        public string Name { get; set; } = null!;

        public virtual ICollection<PopauthPrincipal> PopauthPrincipals { get; set; }
    }
}
