using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class BomOperationComponent
    {
        public long BomOperationComponentId { get; set; }
        public long BomComponentLineId { get; set; }
        public long BomOperationLineId { get; set; }
        public decimal Quantity { get; set; }
        /// <summary>
        /// Required By ObjectStore
        /// </summary>
        public byte[] OpLock { get; set; } = null!;
        /// <summary>
        /// Required By ObjectStore
        /// </summary>
        public DateTime DateTimeCreated { get; set; }
        public DateTime DateTimeUpdated { get; set; }

        public virtual BomComponentLine BomComponentLine { get; set; } = null!;
        public virtual BomOperationLine BomOperationLine { get; set; } = null!;
    }
}
