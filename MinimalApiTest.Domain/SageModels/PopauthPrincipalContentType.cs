using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class PopauthPrincipalContentType
    {
        public PopauthPrincipalContentType()
        {
            PopauthPrincipalContents = new HashSet<PopauthPrincipalContent>();
        }

        public long PopauthPrincipalContentTypeId { get; set; }
        public string Name { get; set; } = null!;

        public virtual ICollection<PopauthPrincipalContent> PopauthPrincipalContents { get; set; }
    }
}
