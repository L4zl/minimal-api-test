using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class BomOperation
    {
        public BomOperation()
        {
            BomOperationResources = new HashSet<BomOperationResource>();
            BomOperationSubcontractSuppliers = new HashSet<BomOperationSubcontractSupplier>();
        }

        public long BomOperationId { get; set; }
        public long BomOperationLineId { get; set; }
        public string Reference { get; set; } = null!;
        public string Description { get; set; } = null!;
        public decimal QuantityPerRun { get; set; }
        public int DefaultRunTimeHours { get; set; }
        public byte DefaultRunTimeMinutes { get; set; }
        public byte DefaultRunTimeSeconds { get; set; }
        public int DelayHours { get; set; }
        public byte DelayMinutes { get; set; }
        public byte DelaySeconds { get; set; }
        public decimal? OverlapPercentage { get; set; }
        public decimal? OverlapQuantity { get; set; }
        public bool Subcontract { get; set; }
        public bool NonPrinting { get; set; }
        public decimal Shrinkage { get; set; }
        public bool Archived { get; set; }
        /// <summary>
        /// Required By ObjectStore
        /// </summary>
        public byte[] OpLock { get; set; } = null!;
        /// <summary>
        /// Required By ObjectStore
        /// </summary>
        public DateTime DateTimeCreated { get; set; }
        public string Notes { get; set; } = null!;
        public DateTime DateTimeUpdated { get; set; }

        public virtual BomOperationLine BomOperationLine { get; set; } = null!;
        public virtual ICollection<BomOperationResource> BomOperationResources { get; set; }
        public virtual ICollection<BomOperationSubcontractSupplier> BomOperationSubcontractSuppliers { get; set; }
    }
}
