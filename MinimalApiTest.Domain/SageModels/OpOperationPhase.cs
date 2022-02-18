using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class OpOperationPhase
    {
        public OpOperationPhase()
        {
            BomCosts = new HashSet<BomCost>();
            BomOperationResources = new HashSet<BomOperationResource>();
            OpOperationResources = new HashSet<OpOperationResource>();
        }

        public long OpOperationPhaseId { get; set; }
        public string Name { get; set; } = null!;
        /// <summary>
        /// Required By ObjectStore
        /// </summary>
        public byte[] OpLock { get; set; } = null!;
        /// <summary>
        /// Required By ObjectStore
        /// </summary>
        public DateTime DateTimeCreated { get; set; }
        public DateTime DateTimeUpdated { get; set; }

        public virtual ICollection<BomCost> BomCosts { get; set; }
        public virtual ICollection<BomOperationResource> BomOperationResources { get; set; }
        public virtual ICollection<OpOperationResource> OpOperationResources { get; set; }
    }
}
