using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class BomBuildPackage
    {
        public BomBuildPackage()
        {
            BomComponentLines = new HashSet<BomComponentLine>();
            BomCostSessions = new HashSet<BomCostSession>();
            BomGroupLinks = new HashSet<BomGroupLink>();
            BomOperationLines = new HashSet<BomOperationLine>();
        }

        public long BomBuildPackageId { get; set; }
        public long BomBuildPackageTypeId { get; set; }
        public long BomRecordId { get; set; }
        public string Reference { get; set; } = null!;
        public bool RequiresComponentReferences { get; set; }
        public DateTime CreationDate { get; set; }
        public string CreatedByUserName { get; set; } = null!;
        public DateTime LastModifiedDate { get; set; }
        public string LastModifiedByUserName { get; set; } = null!;
        public decimal DefaultCostingQuantity { get; set; }
        public decimal DefaultBuildQuantity { get; set; }
        public bool AutoOverheadComputation { get; set; }
        public decimal OverheadCost { get; set; }
        public bool IsActive { get; set; }
        public DateTime? LastCostedDateTime { get; set; }
        public long? LatestBomCostSessionId { get; set; }
        /// <summary>
        /// Required By ObjectStore
        /// </summary>
        public byte[] OpLock { get; set; } = null!;
        /// <summary>
        /// Required By ObjectStore
        /// </summary>
        public DateTime DateTimeCreated { get; set; }
        public decimal MarkupPercentage { get; set; }
        public string ManufacturingInstructions { get; set; } = null!;
        public DateTime DateTimeUpdated { get; set; }

        public virtual BomBuildPackageType BomBuildPackageType { get; set; } = null!;
        public virtual BomRecord BomRecord { get; set; } = null!;
        public virtual ICollection<BomComponentLine> BomComponentLines { get; set; }
        public virtual ICollection<BomCostSession> BomCostSessions { get; set; }
        public virtual ICollection<BomGroupLink> BomGroupLinks { get; set; }
        public virtual ICollection<BomOperationLine> BomOperationLines { get; set; }
    }
}
