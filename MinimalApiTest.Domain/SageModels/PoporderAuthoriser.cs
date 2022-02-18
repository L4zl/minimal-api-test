using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class PoporderAuthoriser
    {
        public long PoporderAuthoriserId { get; set; }
        public long PoporderReturnId { get; set; }
        public long UserId { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public long? AlternativeAuthoriserId { get; set; }
        public long? PoporderAuthoriserParentId { get; set; }
        public long AuthorisationGroup { get; set; }
        public string AuthoriserLogonName { get; set; } = null!;
        public string AuthoriserName { get; set; } = null!;
        public long? SourceId { get; set; }
        public DateTime DateTimeUpdated { get; set; }

        public virtual PoporderReturn PoporderReturn { get; set; } = null!;
    }
}
