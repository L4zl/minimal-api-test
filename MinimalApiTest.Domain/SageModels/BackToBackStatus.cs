using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class BackToBackStatus
    {
        public BackToBackStatus()
        {
            SoporderReturnLines = new HashSet<SoporderReturnLine>();
        }

        public long BackToBackStatusId { get; set; }
        public string Name { get; set; } = null!;

        public virtual ICollection<SoporderReturnLine> SoporderReturnLines { get; set; }
    }
}
