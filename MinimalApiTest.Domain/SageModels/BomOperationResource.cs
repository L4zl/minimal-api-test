using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class BomOperationResource
    {
        public long BomOperationResourceId { get; set; }
        public long BomOperationId { get; set; }
        public long OpOperationResourceTypeId { get; set; }
        public long OpOperationPhaseId { get; set; }
        public string Reference { get; set; } = null!;
        public string Description { get; set; } = null!;
        public decimal? ManningLevel { get; set; }
        public int Hours { get; set; }
        public byte Minutes { get; set; }
        public byte Seconds { get; set; }
        public bool FixedLength { get; set; }
        public decimal FixedLengthQuantity { get; set; }
        public decimal SequenceNumber { get; set; }
        public bool ExportToGraphicalPlanner { get; set; }
        public bool PrimaryResource { get; set; }
        public bool SecondaryResource { get; set; }
        public decimal CostRate { get; set; }
        public bool CostRateOverridden { get; set; }
        public decimal CostQuantity { get; set; }
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

        public virtual BomOperation BomOperation { get; set; } = null!;
        public virtual OpOperationPhase OpOperationPhase { get; set; } = null!;
        public virtual OpOperationResourceType OpOperationResourceType { get; set; } = null!;
    }
}
