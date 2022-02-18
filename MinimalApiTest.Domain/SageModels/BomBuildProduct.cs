using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class BomBuildProduct
    {
        public long BomBuildProductId { get; set; }
        public long BomRecordId { get; set; }
        public string StockCode { get; set; } = null!;
        public string StockDescription { get; set; } = null!;
        public long MseStockItemId { get; set; }
        /// <summary>
        /// Required By ObjectStore
        /// </summary>
        public byte[] OpLock { get; set; } = null!;
        /// <summary>
        /// Required By ObjectStore
        /// </summary>
        public DateTime DateTimeCreated { get; set; }
        public DateTime DateTimeUpdated { get; set; }

        public virtual BomRecord BomRecord { get; set; } = null!;
        public virtual MseStockItem MseStockItem { get; set; } = null!;
    }
}
