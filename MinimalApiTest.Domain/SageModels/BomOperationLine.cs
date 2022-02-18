using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class BomOperationLine
    {
        public BomOperationLine()
        {
            BomOperationComponents = new HashSet<BomOperationComponent>();
            BomOperations = new HashSet<BomOperation>();
        }

        public long BomOperationLineId { get; set; }
        public long BomBuildPackageId { get; set; }
        public decimal SequenceNumber { get; set; }
        public long BomOperationLineTypeId { get; set; }
        public string? Description { get; set; }
        public bool ShowCommentOnReport { get; set; }
        public string? DocumentFile { get; set; }
        public long? OpOperationId { get; set; }
        public bool OperationRegisterOverridden { get; set; }
        /// <summary>
        /// Required By ObjectStore
        /// </summary>
        public byte[] OpLock { get; set; } = null!;
        /// <summary>
        /// Required By ObjectStore
        /// </summary>
        public DateTime DateTimeCreated { get; set; }
        public string BomCommentLine { get; set; } = null!;
        public DateTime DateTimeUpdated { get; set; }

        public virtual BomBuildPackage BomBuildPackage { get; set; } = null!;
        public virtual BomOperationLineType BomOperationLineType { get; set; } = null!;
        public virtual ICollection<BomOperationComponent> BomOperationComponents { get; set; }
        public virtual ICollection<BomOperation> BomOperations { get; set; }
    }
}
