using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class PopauthPrincipalContent
    {
        public long PopauthPrincipalContentId { get; set; }
        public long PopauthPrincipalId { get; set; }
        public long SourceId { get; set; }
        public long PopauthPrincipalContentTypeId { get; set; }
        public long ReferenceId { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public bool Isolated { get; set; }
        public DateTime DateTimeUpdated { get; set; }

        public virtual PopauthPrincipal PopauthPrincipal { get; set; } = null!;
        public virtual PopauthPrincipalContentType PopauthPrincipalContentType { get; set; } = null!;
        public virtual Sysmodule Source { get; set; } = null!;
    }
}
