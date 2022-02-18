using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SysdocCaptureType
    {
        public SysdocCaptureType()
        {
            SysdocCaptures = new HashSet<SysdocCapture>();
        }

        public long SysdocCaptureTypeId { get; set; }
        public string Name { get; set; } = null!;

        public virtual ICollection<SysdocCapture> SysdocCaptures { get; set; }
    }
}
