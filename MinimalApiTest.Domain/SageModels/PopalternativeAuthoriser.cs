using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class PopalternativeAuthoriser
    {
        public long PopalternativeAuthoriserId { get; set; }
        public long UserId { get; set; }
        public long AlternativeUserId { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public DateTime DateTimeUpdated { get; set; }
    }
}
