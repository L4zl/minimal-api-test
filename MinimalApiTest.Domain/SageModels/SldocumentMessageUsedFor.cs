using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SldocumentMessageUsedFor
    {
        public SldocumentMessageUsedFor()
        {
            SldocumentMessages = new HashSet<SldocumentMessage>();
        }

        public long SldocumentMessageUsedForId { get; set; }
        public string Name { get; set; } = null!;

        public virtual ICollection<SldocumentMessage> SldocumentMessages { get; set; }
    }
}
