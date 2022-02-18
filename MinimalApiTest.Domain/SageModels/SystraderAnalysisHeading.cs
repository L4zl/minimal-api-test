using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SystraderAnalysisHeading
    {
        public SystraderAnalysisHeading()
        {
            SystraderAnalysisValues = new HashSet<SystraderAnalysisValue>();
        }

        public long SystraderAnalysisHeadingId { get; set; }
        public string Name { get; set; } = null!;
        public bool? UseForCustomerAccount { get; set; }
        public bool? UseForSupplierAccount { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public DateTime DateTimeUpdated { get; set; }

        public virtual ICollection<SystraderAnalysisValue> SystraderAnalysisValues { get; set; }
    }
}
