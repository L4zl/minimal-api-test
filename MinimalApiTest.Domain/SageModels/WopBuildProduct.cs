using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class WopBuildProduct
    {
        public WopBuildProduct()
        {
            WopBuildComponents = new HashSet<WopBuildComponent>();
            WopBuildProductNominalPostings = new HashSet<WopBuildProductNominalPosting>();
            WopBuildTraceableProducts = new HashSet<WopBuildTraceableProduct>();
        }

        public long WopBuildProductId { get; set; }
        public long WopBuildId { get; set; }
        public string StockCode { get; set; } = null!;
        public decimal Quantity { get; set; }
        public decimal UnitCost { get; set; }
        public long UnitId { get; set; }
        public string UnitOfMeasure { get; set; } = null!;
        public long? BinItemId { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public long? MovementBalanceId { get; set; }
        public DateTime DateTimeUpdated { get; set; }

        public virtual WopBuild WopBuild { get; set; } = null!;
        public virtual ICollection<WopBuildComponent> WopBuildComponents { get; set; }
        public virtual ICollection<WopBuildProductNominalPosting> WopBuildProductNominalPostings { get; set; }
        public virtual ICollection<WopBuildTraceableProduct> WopBuildTraceableProducts { get; set; }
    }
}
