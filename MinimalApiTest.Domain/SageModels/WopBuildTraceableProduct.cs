using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class WopBuildTraceableProduct
    {
        public WopBuildTraceableProduct()
        {
            WopBuildComponentTraceabilities = new HashSet<WopBuildComponentTraceability>();
        }

        public long WopBuildTraceableProductId { get; set; }
        public long? WopBuildProductId { get; set; }
        public long TraceableItemId { get; set; }
        public string IdentificationNo { get; set; } = null!;
        public decimal Quantity { get; set; }
        public long UnitId { get; set; }
        public string UnitOfMeasure { get; set; } = null!;
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public DateTime DateTimeUpdated { get; set; }

        public virtual WopBuildProduct? WopBuildProduct { get; set; }
        public virtual ICollection<WopBuildComponentTraceability> WopBuildComponentTraceabilities { get; set; }
    }
}
