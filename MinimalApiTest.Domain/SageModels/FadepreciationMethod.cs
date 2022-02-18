using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class FadepreciationMethod
    {
        public FadepreciationMethod()
        {
            Faassets = new HashSet<Faasset>();
        }

        public long FadepreciationMethodId { get; set; }
        public string DepreciationMethodName { get; set; } = null!;
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public DateTime DateTimeUpdated { get; set; }

        public virtual ICollection<Faasset> Faassets { get; set; }
    }
}
