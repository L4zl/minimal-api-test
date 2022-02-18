using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class BomComponentLine
    {
        public BomComponentLine()
        {
            BomComponentReferences = new HashSet<BomComponentReference>();
            BomOperationComponents = new HashSet<BomOperationComponent>();
            WopBomComponentLineLinks = new HashSet<WopBomComponentLineLink>();
        }

        public long BomComponentLineId { get; set; }
        public long BomBuildPackageId { get; set; }
        public decimal SequenceNumber { get; set; }
        public long BomComponentLineTypeId { get; set; }
        public string? StockCode { get; set; }
        public string? Description { get; set; }
        public decimal? Quantity { get; set; }
        public decimal ScrapPercentage { get; set; }
        public bool FixedQuantity { get; set; }
        public bool Suspended { get; set; }
        public bool ShowCommentOnReport { get; set; }
        public string? DocumentFile { get; set; }
        public long? StockItemUnitId { get; set; }
        public string? UnitOfMeasure { get; set; }
        public long? BomRecordId { get; set; }
        /// <summary>
        /// Required By ObjectStore
        /// </summary>
        public byte[] OpLock { get; set; } = null!;
        /// <summary>
        /// Required By ObjectStore
        /// </summary>
        public DateTime DateTimeCreated { get; set; }
        public bool ConfirmationRequired { get; set; }
        public bool? Consumed { get; set; }
        public bool UseSpecificSubassemblyVersion { get; set; }
        public string Instructions { get; set; } = null!;
        public string Notes { get; set; } = null!;
        public string BomCommentLine { get; set; } = null!;
        public DateTime DateTimeUpdated { get; set; }

        public virtual BomBuildPackage BomBuildPackage { get; set; } = null!;
        public virtual BomComponentLineType BomComponentLineType { get; set; } = null!;
        public virtual ICollection<BomComponentReference> BomComponentReferences { get; set; }
        public virtual ICollection<BomOperationComponent> BomOperationComponents { get; set; }
        public virtual ICollection<WopBomComponentLineLink> WopBomComponentLineLinks { get; set; }
    }
}
